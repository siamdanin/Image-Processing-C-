using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace Project_Akhir_Computer_Vision
{
    public partial class Login : Form
    {
        InitialForm temp;
        public Login(InitialForm Login)
        {
            InitializeComponent();
            temp = Login;
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            temp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lusername = textBox1.Text;
            String lpassword = textBox2.Text;
            string uname;
            string password;

            using (StreamReader sr = new StreamReader(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\data.txt"))
            {
                uname = sr.ReadLine();
                password = sr.ReadLine();
            }

            if (lusername != uname || lpassword != password)
            {
                eror.Text = "Invalid username and/or password";
            }
            else
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
        }
    }
}
