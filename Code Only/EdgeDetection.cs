using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;

namespace Project_Akhir_Computer_Vision
{
    public partial class EdgeDetection : Form
    {
        Image<Bgr, byte> ori, edit;
        Image<Gray, byte> oriGray;

        Image<Gray, float> edge;

        public EdgeDetection()
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
                ori = new Image<Bgr, byte>(openFileDialog1.FileName);
                oriGray = new Image<Gray,byte>(ori.Size);
                edge = new Image<Gray,float>(ori.Size);
                pictureBox2.Image = ori.Bitmap;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1|| comboBox1.SelectedIndex == 2)
            {
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //PROCESS
            if (comboBox1.SelectedItem == null)
            {
                label4.Text = "Please choose the Edge Detection Type";
            }
            else{
                label4.Text = "";
                CvInvoke.cvCvtColor(ori, oriGray, COLOR_CONVERSION.CV_BGR2GRAY);
                int aperture = Convert.ToInt32(numericUpDown1.Value);
                if (comboBox1.SelectedIndex == 0)
                {
                    int low = Convert.ToInt32(numericUpDown3.Value);
                    int high = Convert.ToInt32(numericUpDown2.Value);
                    CvInvoke.cvCanny(oriGray, oriGray, low, high, aperture);
                    pictureBox2.Image = oriGray.Bitmap;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    CvInvoke.cvLaplace(oriGray, edge, aperture);
                    pictureBox2.Image = edge.Bitmap;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    CvInvoke.cvSobel(oriGray, edge, 0, 1, aperture);
                    pictureBox2.Image = edge.Bitmap;
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

        private void EdgeDetection_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }
    }
}
