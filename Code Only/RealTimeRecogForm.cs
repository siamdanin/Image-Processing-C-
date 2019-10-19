using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Project_Akhir_Computer_Vision
{
    public partial class RealTimeRecogForm : Form
    {
        Capture cap;
        Image<Bgr, byte> ori;
        Image<Gray, byte> gray;
        HaarCascade hc;
   
        public RealTimeRecogForm()
        {
            InitializeComponent();
            button2.Enabled = false;
            cap = new Capture();
            hc = new HaarCascade("haarcascade_frontalface_alt.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ori = new Image<Bgr,byte>(cap.QueryFrame().ToBitmap());
            gray = new Image<Gray, byte>(ori.Size);

            CvInvoke.cvCvtColor(ori, gray, COLOR_CONVERSION.CV_BGR2GRAY);
            var faces = hc.Detect(gray);

            foreach (var face in faces)
            {
                ori.Draw(face.rect, new Bgr(Color.Green), 1);
            }
            pictureBox2.Image = ori.Bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RealTimeRecogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }

    }
}
