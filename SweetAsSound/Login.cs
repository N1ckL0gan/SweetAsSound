using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SweetAsSound
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void Login_btn_Click_1(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (LoginEmail.Text == "")
            {
                MessageBox.Show("Please enter a Valid Email");
                LoginEmail.BackColor = Color.Red;
                LoginEmail.Focus();
            }
            else if (!regex.IsMatch(LoginEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email");
            }
            else if (LoginPassword.Text == "")
            {
                LoginEmail.BackColor = Color.White;
                MessageBox.Show("Please enter a Valid Password");
                LoginPassword.BackColor = Color.Red;
                LoginPassword.Focus();
            }
            else
            {
                string email = LoginEmail.Text; string password = LoginPassword.Text;
                bool output = ValidateUser(email, password);
               
            }
        }

        private bool ValidateUser(string email, string password)
        {
            using (var context = new AppdDbContex())
            {
                var user = context.Users.SingleOrDefault(p => p.Email == email && p.Password == password);

                if (user == null)
                {
                    MessageBox.Show("User Not Found");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sign in Successful, Opening Home page");
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    return true;
                }
            }
        }

        private void ForgotPassword_link_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
            this.Close();
        }

    }
}
