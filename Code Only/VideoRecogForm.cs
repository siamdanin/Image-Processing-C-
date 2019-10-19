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
    public partial class VideoRecogForm : Form
    {
        Capture cap;
        public VideoRecogForm()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Video Files (*.mp4,*.wmv,*.3g2,*.3gp,*.3gp2,*.3gpp,*.amv,*.asf,*.avi,*.bin,*.cue,*.divx,*.dv,*.flv,*.gxf,*.iso,*.m1v,*.m2v,*.m2t,*.m2ts,*.m4v)|" +
                "*.mp4;*.wmv;*.3g2;*.3gp;*.3gp2;*.3gpp;*.amv;*.asf;*.avi;*.bin;*.cue;*.divx;*.dv;*.flv;*.gxf;*.iso;*.m1v;*.m2v;*.m2t;*.m2ts;*.m4v|All Files (*.*)|*.*";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            button2.Enabled = true;
            cap = new Capture(openFileDialog1.FileName);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image<Bgr,byte> ori = cap.QueryFrame();

            HaarCascade face = new HaarCascade("haarcascade_frontalface_alt.xml");

            if (checkBox1.Checked)
            {
                foreach (var item in face.Detect(ori.Convert<Gray, byte>()))
                {
                    ori.Draw(item.rect, new Bgr(Color.Red), 1);
                }
                pictureBox2.Image = ori.Bitmap;
            }
            else
            {
                pictureBox2.Image = ori.Bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void VideoRecogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }
    }
}
