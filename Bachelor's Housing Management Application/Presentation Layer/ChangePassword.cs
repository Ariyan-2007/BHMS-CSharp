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
    public partial class ChangePassword : Form
    {
        string user;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(string x)
        {
            InitializeComponent();
            user = x;
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (user == "B")
            {
                if (cPass.Text.Equals(UserService.GetUserInfoB("Password", Session.GetUserName())))
                {
                    if (nPass.Text.Equals(coPass.Text))
                    {
                        UserService.UpdateUserInfoB("Password", nPass.Text, Session.GetUserName());
                        MessageBox.Show("Password Changed Successfully!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! New Password Doesn't Match");
                    }
                }
                else
                {
                    MessageBox.Show("Error! Current Password Is Invalid");
                }
            }
            else
            {
                if (cPass.Text.Equals(UserService.GetUserInfoFO("Password", Session.GetUserName())))
                {
                    if (nPass.Text.Equals(coPass.Text))
                    {
                        UserService.UpdateUserInfoFO("Password", nPass.Text, Session.GetUserName());
                        MessageBox.Show("Password Changed Successfully!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! New Password Doesn't Match");
                    }
                }
                else
                {
                    MessageBox.Show("Error! Current Password Is Invalid");
                }
            }
        }
    }
}
