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
    public partial class FOHomePage : Form
    {
        public FOHomePage()
        {
            InitializeComponent();
            nametxt.Text = UserService.GetUserInfoFO("FullName", Session.GetUserName());
            balancetxt.Text = "Balance: " + UserService.GetUserInfoFO("Balance", Session.GetUserName()) + "Tk";
        }

        private void FOHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            FOSettings f = new FOSettings();
            this.Hide();
            f.Show();
        }

        private void postAD_Click(object sender, EventArgs e)
        {
            PostAD p = new PostAD();
            this.Hide();
            p.Show();
        }

        private void myAD_Click(object sender, EventArgs e)
        {
            ADDisplay a = new ADDisplay();
            this.Hide();
            a.Show();
        }
    }
}
