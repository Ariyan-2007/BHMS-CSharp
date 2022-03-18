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
    public partial class FOSettings : Form
    {
        public FOSettings()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            nameTxt.Text = UserService.GetUserInfoFO("FullName", Session.GetUserName());
            userNameTxt.Text = UserService.GetUserInfoFO("Username", Session.GetUserName());
            phoneNumberTxt.Text = UserService.GetUserInfoFO("Number", Session.GetUserName());
            balanceTxt.Text = UserService.GetUserInfoFO("Balance", Session.GetUserName()) + "Tk";
            pictureBox1.Image = Image.FromFile(UserService.GetUserInfoFO("Picture", Session.GetUserName()));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void changePasswrod_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword("FO");
            c.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            FOHomePage f = new FOHomePage();
            this.Hide();
            f.Show();
        }

        private void FOSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
