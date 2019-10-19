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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Drawing.Imaging;

namespace Project_Akhir_Computer_Vision
{
    public partial class ImageRecogForm : Form
    {
        Image<Bgr, byte> ori, edit;
        Image<Gray, byte> gray;
        HaarCascade detect;//face
        HaarCascade detect2;//nose
        HaarCascade detect3;//mouth
        HaarCascade detect4;//upperbody

        public ImageRecogForm()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            detect = new HaarCascade("haarcascade_frontalface_alt.xml");
            detect2 = new HaarCascade("haarcascade_mcs_nose.xml");
            detect3 = new HaarCascade("haarcascade_mcs_mouth.xml");
            detect4 = new HaarCascade("haarcascade_mcs_upperbody.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png|All Files (*.*)|*.*";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            ori = new Image<Bgr, byte>(openFileDialog1.FileName);
            edit = new Image<Bgr, byte>(ori.Size);
            gray = new Image<Gray, byte>(ori.Size);

            pictureBox2.Image = ori.Bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                label1.Text = "Please choose the object detection type";
            }
            else
            {
                label1.Text = "";
                CvInvoke.cvCvtColor(ori, gray, COLOR_CONVERSION.CV_BGR2GRAY);
                if (checkBox1.Checked)
                {
                
                    var faces = detect.Detect(gray);
                    edit = ori.Clone();

                    foreach (var face in faces)
                    {
                        edit.Draw(face.rect, new Bgr(Color.Red), 5);
                    }
                }
                if (checkBox2.Checked)
                {
                
                    var noses = detect2.Detect(gray);
                    edit = ori.Clone();

                    foreach (var nose in noses)
                    {
                        edit.Draw(nose.rect, new Bgr(Color.Blue), 5);
                    }
                }
                if (checkBox3.Checked)
                {
                    var mouths = detect3.Detect(gray);
                    edit = ori.Clone();

                    foreach (var mouth in mouths)
                    {
                        edit.Draw(mouth.rect, new Bgr(Color.Yellow), 5);
                    }
                }
                if (checkBox4.Checked)
                {
                    var upperboddies = detect4.Detect(gray);
                    edit = ori.Clone();

                    foreach (var upperbody in upperboddies)
                    {
                        edit.Draw(upperbody.rect, new Bgr(Color.Green), 5);
                    }
                }
                pictureBox2.Image = edit.Bitmap;
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

        private void ImageRecogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }
    }
}
