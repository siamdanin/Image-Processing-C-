using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Akhir_Computer_Vision
{
    public partial class ChooseRecogForm : Form
    {
        public ChooseRecogForm()
        {
            InitializeComponent();
        }

        //Image Recognition
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            ImageRecogForm win = new ImageRecogForm();
            win.Show();
            this.Hide();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            ImageRecogForm win = new ImageRecogForm();
            win.Show();
            this.Hide();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            ImageRecogForm win = new ImageRecogForm();
            win.Show();
            this.Hide();
        }

        //Video Recognition

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            VideoRecogForm win = new VideoRecogForm();
            win.Show();
            this.Hide();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            VideoRecogForm win = new VideoRecogForm();
            win.Show();
            this.Hide();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            VideoRecogForm win = new VideoRecogForm();
            win.Show();
            this.Hide();
        }

        //Realtime Recognition
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            RealTimeRecogForm win = new RealTimeRecogForm();
            win.Show();
            this.Hide();
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            RealTimeRecogForm win = new RealTimeRecogForm();
            win.Show();
            this.Hide();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            RealTimeRecogForm win = new RealTimeRecogForm();
            win.Show();
            this.Hide();
        }

        private void ChooseRecogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm win = new HomeForm();
            win.Show();
            this.Hide();
        }

    }
}
