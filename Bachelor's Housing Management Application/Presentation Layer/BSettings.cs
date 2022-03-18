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
    public partial class BSettings : Form
    {
        public BSettings()
        {
            InitializeComponent();
            Initialize();

        }
        private void Initialize()
        {
            nameTxt.Text = UserService.GetUserInfoB("FullName", Session.GetUserName());
            userNameTxt.Text = UserService.GetUserInfoB("Username", Session.GetUserName());
            phoneNumberTxt.Text = UserService.GetUserInfoB("Number", Session.GetUserName());
            balanceTxt.Text = UserService.GetUserInfoB("Balance", Session.GetUserName()) + "Tk";
            pictureBox1.Image = Image.FromFile(UserService.GetUserInfoB("Picture", Session.GetUserName()));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void back_Click(object sender, EventArgs e)
        {
            BHomePage b = new BHomePage();
            this.Hide();
            b.Show();
        }

        private void BSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void changePasswrod_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword("B");
            c.Show();
        }

        private void cashIn_Click(object sender, EventArgs e)
        {
            CashIn c = new CashIn();
            c.Show();
            c.FormClosing += new FormClosingEventHandler(ChildFormClosing);
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Initialize();
        }
    }
}
