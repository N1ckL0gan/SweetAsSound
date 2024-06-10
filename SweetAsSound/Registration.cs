using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SweetAsSound
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (firstname_txt.Text == "")
            {
                MessageBox.Show("Please enter First Name");
                firstname_txt.BackColor = Color.Red;
                firstname_txt.Focus();
            }

            else if (lastname_txt.Text == "")
            {
                firstname_txt.BackColor = Color.White;
                MessageBox.Show("Please enter Last Name");
                lastname_txt.BackColor = Color.Red;
                lastname_txt.Focus();
            }

            else if (email_txt.Text == "")
            {
                lastname_txt.BackColor = Color.White;
                MessageBox.Show("Please enter an Email");
                email_txt.BackColor = Color.Red;
                email_txt.Focus();
            }

            else if (!regex.IsMatch(email_txt.Text))
            {
                MessageBox.Show("Please enter a valid Email");
            }

            else if (password_txt.Text == "")
            {
                email_txt.BackColor = Color.White;
                MessageBox.Show("Please enter your password");
                password_txt.BackColor = Color.Red;
                password_txt.Focus();
            }

            else if (label7.Text != Captcha_txt.Text)
            {
                MessageBox.Show("CAPTCHA is Incorrect", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Captcha_txt.Focus();
                Captcha_txt.Clear();
                GenerateCaptcha(); 
            } 

           else if (!privacy_checkbox.Checked)
            {
                MessageBox.Show("Please agree to our Privacy Policy");
            }

          else
            {
                AddUser(firstname_txt.Text, lastname_txt.Text, email_txt.Text, password_txt.Text);
                MessageBox.Show("Registration Succesful!\nPlease login with your new credentials");
                Login login = new Login();
                login.Show();
                this.Close();
            }



        }

        private void AddUser(string firstname, string lastname, string email, string password) 
        {
            using (var context = new AppdDbContex())
            {
                var u = new User();
                u.FirstName = firstname;
                u.LastName = lastname;
                u.Email = email;
                u.Password = password;
                context.SaveChanges();
            }
        }



        private void login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login F2 = new Login();
            F2.ShowDialog();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            Random random = new Random();
            int num = random.Next(6, 10);
            string captcha = "";
            int total = 0;

            do
            {
                int chr = random.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    total++;
                    if (total == num)
                    {
                        break;
                    }
                }
            }
            while (true);

            label7.Text = captcha;
        }



 
        





        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

 
    }
}
