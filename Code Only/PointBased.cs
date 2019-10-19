using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;

namespace Project_Akhir_Computer_Vision
{
    public partial class PointBased : Form
    {
        Image<Bgr, Byte> ori;
        Image<Gray, Byte> gray;

        public PointBased()
        {
            InitializeComponent();
        }
        private void browsebtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.Enabled = true;
                ori = new Image<Bgr, byte>(openFileDialog1.FileName);
                openFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png|All Files (*.*)|*.*";
                pictureBox2.Image = ori.Bitmap;
            }
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ori = new Image<Bgr, Byte>(openFileDialog1.FileName);
            gray = new Image<Gray, Byte>(ori.Size);
            pictureBox2.Image = ori.Bitmap;
        }

        private void processbtn_Click(object sender, EventArgs e)
        {
            if (!radioGrayscale.Checked && !radioThreshold.Checked)
            {
                erorlabel.Text = "Please choose the mode";
            }
            else
            {
                erorlabel.Text = "";
                if (radioGrayscale.Checked)
                {
                    CvInvoke.cvCvtColor(ori, gray, COLOR_CONVERSION.CV_BGR2GRAY);
                    pictureBox2.Image = gray.Bitmap;
                }
                else if (radioThreshold.Checked)
                {
                    if (cbthreshold.SelectedItem == null)
                    {
                        erorlabel.Text = "Please choose the Threshold Type! ";
                    }
                    else
                    {
                        erorlabel.Text = "";
                        CvInvoke.cvCvtColor(ori, gray, COLOR_CONVERSION.CV_BGR2GRAY);
                        if (cbthreshold.SelectedIndex == 0)
                        {
                            CvInvoke.cvThreshold(gray, gray, (double)lowValue.Value, (double)HighValue.Value, THRESH.CV_THRESH_BINARY);
                            pictureBox2.Image = gray.Bitmap;
                        }
                        else if (cbthreshold.SelectedIndex == 1)
                        {
                            CvInvoke.cvThreshold(gray, gray, (double)lowValue.Value, (double)HighValue.Value, THRESH.CV_THRESH_BINARY_INV);
                            pictureBox2.Image = gray.Bitmap;
                        }
                        else if (cbthreshold.SelectedIndex == 2)
                        {
                            CvInvoke.cvThreshold(gray, gray, (double)lowValue.Value, (double)HighValue.Value, THRESH.CV_THRESH_TOZERO);
                            pictureBox2.Image = gray.Bitmap;
                        }
                        else if (cbthreshold.SelectedIndex == 3)
                        {
                            CvInvoke.cvThreshold(gray, gray, (double)lowValue.Value, (double)HighValue.Value, THRESH.CV_THRESH_TOZERO_INV);
                            pictureBox2.Image = gray.Bitmap;
                        }
                        else if (cbthreshold.SelectedIndex == 4)
                        {
                            CvInvoke.cvThreshold(gray, gray, (double)lowValue.Value, (double)HighValue.Value, THRESH.CV_THRESH_TRUNC);
                            pictureBox2.Image = gray.Bitmap;
                        }
                    }
                }
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Files (*.*)|*.*|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tiff)|*.tiff";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Success save the picture");
            }
        }

        private void PointBased_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }
    }
}
