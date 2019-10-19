using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Project_Akhir_Computer_Vision
{
    public partial class Register : Form
    {
        InitialForm temp;
        public Register(InitialForm Register)
        {
            InitializeComponent();
            temp = Register;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textUsername.Text;
            String password = textPassword.Text;
            String confirmpass = textConfirmPass.Text;
            String email = textEmail.Text;
            Regex validemail = new Regex(@"[A-Za-z0-9\._%+-]+[^\.]@[^\.][A-Za-z0-9\.-]+[^\.]\.com");
            Match match = validemail.Match(email);

            String[] strtext = new String[4];
            int error = 0;

            if (username == "")
            {
                strtext[error] = "Username"; error++;
            }
            if (password == "")
            {
                strtext[error] = "Password"; error++;
            }
            if (confirmpass == "")
            {
                strtext[error] = "Confirm Password"; error++;
            }
            if (email == "")
            {
                strtext[error] = "Email"; error++;
            }
            errortext.Text = "";
            if (error != 0)
            {
                for (int x = 0; x < error; x++)
                {
                    if(x == 0){
                        errortext.Text += strtext[x] + ((error == 2) ? " " : ((error == 1) ? "" : ", "));
                    }
                    if (x > 0 && x < error - 1)
                    {
                        errortext.Text +=  strtext[x] + ", ";}
                    if (x == (error - 1))
                    {
                        errortext.Text += ((x == 0) ? "" : ("and " + strtext[x])); }
                }
                errortext.Text += " must be filled";
            }
            else{
                errortext.Text = "";
            }

            if ((username.Length < 3 || username.Length > 10) && username != "")
            {
                errortext.Text += ((error == 0) ? "" : "\n") + "Username must be filled [3..10] characters"; error++;
            }
            if ((password.Length < 5 || password.Length > 11) && password != "")
            {
                errortext.Text += ((error == 0) ? "" : "\n") + "Password must be filled [5..11] characters"; error++;
            }
            if (((confirmpass != password) && password != "") && confirmpass != "")
            {
                errortext.Text += ((error == 0) ? "" : "\n") + "Password doesn't match"; error++;
            }
            if ((!match.Success) && email != "")
            {
                errortext.Text += ((error == 0) ? "" : "\n") + "Email doesnt valid"; error++;
            }
            if (!agreementbox.Checked)
            {
                errortext.Text += ((error == 0) ? "" : "\n") + "Agreement must be checked"; error++;
            }

            if (error == 0)
            {
                using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\data.txt"))
                {
                    string uname = (string)username, pass = (string)password;
                    string conpass = (string)confirmpass, em = (string)email;

                    sw.WriteLine(uname);
                    sw.WriteLine(pass);
                }
                temp.Show();
                this.Hide();
                MessageBox.Show("Register Success");
            }
        }
        
        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            temp.Show();
        }

       
    }
}
//if(!Regex.Ismatch(textEmail,email){
    //label5.Text("email doesnt match");}