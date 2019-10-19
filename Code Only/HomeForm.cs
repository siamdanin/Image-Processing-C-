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
    public partial class HomeForm : Form
    {
 
        public HomeForm()
        {
            InitializeComponent();
        }

        //Area Based
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            AreaBased win = new AreaBased();
            win.Show();
            this.Hide();
        }
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            AreaBased win = new AreaBased();
            win.Show();
            this.Hide();
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            AreaBased win = new AreaBased();
            win.Show();
            this.Hide();
        }

        //Point Based
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            PointBased win = new PointBased();
            win.Show();
            this.Hide();
        }
        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            PointBased win = new PointBased();
            win.Show();
            this.Hide();
        }
        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            PointBased win = new PointBased();
            win.Show();
            this.Hide();
        }

        //Edge Detection
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            EdgeDetection win = new EdgeDetection();
            win.Show();
            this.Hide();
        }
        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            EdgeDetection win = new EdgeDetection();
            win.Show();
            this.Hide();
        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            EdgeDetection win = new EdgeDetection();
            win.Show();
            this.Hide();
        }

        //Shape Detection
        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            ShapeDetection win = new ShapeDetection();
            win.Show();
            this.Hide();
        }
        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            ShapeDetection win = new ShapeDetection();
            win.Show();
            this.Hide();
        }
        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            ShapeDetection win = new ShapeDetection();
            win.Show();
            this.Hide();
        }

        //Recognition Form
        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            ChooseRecogForm win = new ChooseRecogForm();
            win.Show();
            this.Hide();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            ChooseRecogForm win = new ChooseRecogForm();
            win.Show();
            this.Hide();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            ChooseRecogForm win = new ChooseRecogForm();
            win.Show();
            this.Hide();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            ChooseRecogForm win = new ChooseRecogForm();
            win.Show();
            this.Hide();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitialForm win = new InitialForm();
            win.Show();
            this.Hide();
        }
    }
}
