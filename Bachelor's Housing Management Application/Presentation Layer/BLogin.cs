using Bachelor_s_Housing_Management_Application.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachelor_s_Housing_Management_Application.Presentation_Layer
{
    public partial class BLogin : Form
    {
        public BLogin()
        {
            InitializeComponent();
        }

        private void BLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            BSignUp b = new BSignUp();
            this.Hide();
            b.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (userNameBox.Text.Equals(UserService.GetUserInfoB("Username", userNameBox.Text)))
            {
                if (passwordBox.Text.Equals(UserService.GetUserInfoB("Password", userNameBox.Text)))
                {
                    MessageBox.Show("Login Complete!");
                    Session.SetUserName(userNameBox.Text);
                    BHomePage b = new BHomePage();
                    this.Hide();
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Error! Password Doesn't Match");
                }
            }
            else
            {
                MessageBox.Show("Error! Username Doesn't Exist");
            }
            

        }
    }
}
