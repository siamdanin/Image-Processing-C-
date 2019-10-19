using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;

namespace Project_Akhir_Computer_Vision
{
    public partial class ShapeDetection : Form
    {
        Image<Bgr, byte> ori;
        Image<Gray, byte> edit;

        public ShapeDetection()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                edit = new Image<Gray, byte>(openFileDialog1.FileName).Canny(new Gray(100), new Gray(40));
                ori = new Image<Bgr, byte>(openFileDialog1.FileName);
                pictureBox2.Image = ori.Bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                eror.Text = "Please choose the shape detection type";
            }
            else
            {
                eror.Text = "";
                if (checkBox1.Checked)
                {
                    LineSegment2D[] line = edit.HoughLinesBinary(2, Math.PI / 180, 50, 15, 10)[0]; //udah di canny

                    foreach (LineSegment2D /*atau pake var */ item in line)
                    {
                        ori.Draw(item, new Bgr(Color.Blue), 5);
                    }
                }
                if (checkBox2.Checked)
                {
                    CircleF[] circ = edit.HoughCircles(new Gray(130), new Gray(40), 1, 500, 40, 1000)[0];// FALSE positif -> sebenarnya gada jadi ada | False negatif -> sebenarnya gada sebenarnya ada
                    foreach (CircleF item in circ)
                    {
                        ori.Draw(item, new Bgr(Color.Yellow), 5);
                    }
                }
                if (checkBox3.Checked)
                {
                    List<Triangle2DF> trilist = new List<Triangle2DF>(); //nampung segitiga
                    MemStorage storage = new MemStorage();
                    for (Contour<Point> con = /* ganti jadi ori*/ori.Convert<Gray, byte>().FindContours(); con != null; con = con.HNext)
                    {
                        Contour<Point> con2 = con.ApproxPoly(con.Perimeter * 0.16, storage);
                        if (con.Area > 250)
                        {
                            if (con2.Total == 3)
                            {
                                Point[] pts = con2.ToArray();
                                trilist.Add(new Triangle2DF(pts[0], pts[1], pts[2]));
                            }
                        }
                    }
                    foreach (var item in trilist)
                    {
                        ori.Draw(item, new Bgr(Color.Green), 5);
                    }
                }
                if (checkBox4.Checked)
                {
                    List<MCvBox2D> boxlist = new List<MCvBox2D>(); //nampung kotak
                    MemStorage storage = new MemStorage();

                    for (Contour<Point> con = /* ganti jadi ori*/ori.Convert<Gray, byte>().FindContours(); con != null; con = con.HNext)
                    {
                        Contour<Point> con2 = con.ApproxPoly(con.Perimeter * 0.16, storage);
                        if (con.Area > 250)
                        {
                            if (con2.Total == 4)
                            {
                                bool rect = true;
                                Point[] pts = con2.ToArray();
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);
                                for (int i = 0; i < edges.Length; i++)
                                {
                                    double angle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                    if (angle < 85 || angle > 95)
                                    {
                                        rect = false;
                                        break;
                                    }
                                }
                                if (rect)
                                {
                                    boxlist.Add(con2.GetMinAreaRect());
                                }
                            }
                        }
                    }

                    foreach (MCvBox2D item in boxlist)
                    {
                        ori.Draw(item, new Bgr(Color.Violet), 5);
                    }
                }
                pictureBox2.Image = ori.Bitmap;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Files (*.*)|*.*|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tiff)|*.tiff";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Success save the picture");
            }
        }

        private void ShapeDetection_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }
    }
}
