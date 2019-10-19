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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login page = new Login(this);
            page.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register page = new Register(this);
            page.Show();
            this.Hide();
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void InitialForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
