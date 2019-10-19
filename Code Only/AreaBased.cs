using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System.IO;

namespace Project_Akhir_Computer_Vision
{
    public partial class AreaBased : Form
    {
        Image<Bgr, byte> ori, blur, median, gaussian;
        
        public AreaBased()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.Enabled = true;
                ori = new Image<Bgr, byte>(openFileDialog1.FileName);
                pictureBox2.Image = ori.Bitmap;
                openFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png|All Files (*.*)|*.*";
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            ori = new Image<Bgr, Byte>(openFileDialog1.FileName);
            blur = new Image<Bgr, Byte>(ori.Width, ori.Height);
            median = new Image<Bgr, Byte>(ori.Width, ori.Height);
            gaussian = new Image<Bgr, Byte>(ori.Width, ori.Height);
            pictureBox2.Image = ori.Bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //smoothing
            if (comboBox1.SelectedItem == null)
            {
                label2.Text = "Please choose the smooth type";
            }
            else
            {
                int smoothValue = Int32.Parse(numericUpDown1.Text);
               
                if (comboBox1.SelectedIndex == 0)
                {
                    label2.Text = "";
                    CvInvoke.cvSmooth(ori, blur, SMOOTH_TYPE.CV_BLUR, smoothValue, smoothValue, 0, 0);
                    pictureBox2.Image = blur.ToBitmap();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label2.Text = "";
                    CvInvoke.cvSmooth(ori, median, SMOOTH_TYPE.CV_MEDIAN, smoothValue, smoothValue, 0, 0);
                    pictureBox2.Image = median.ToBitmap();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label2.Text = "";
                    CvInvoke.cvSmooth(ori, gaussian, SMOOTH_TYPE.CV_GAUSSIAN, smoothValue, smoothValue, 0, 0);
                    pictureBox2.Image = gaussian.ToBitmap();
                }
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

        private void AreaBased_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }
    }
}
