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
    public partial class BHomePage : Form
    {
        public BHomePage()
        {
            InitializeComponent();
            nametxt.Text = UserService.GetUserInfoB("FullName", Session.GetUserName());
            balancetxt.Text = "Balance: " + UserService.GetUserInfoB("Balance", Session.GetUserName()) + "Tk";
        }

        private void BHomePage_FormClosing(object sender, FormClosingEventArgs e)
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
            BSettings b = new BSettings();
            this.Hide();
            b.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            this.Hide();
            s.Show();
        }

        private void booked_Click(object sender, EventArgs e)
        {
            if(UserService.GetUserInfoB("FID",Session.GetUserName()) == "0")
            {
                MessageBox.Show("You Haven't Booked A Flat Yet..Try Again After Booking");
            }
            else
            {
                Booked b = new Booked(Convert.ToInt32(UserService.GetUserInfoB("FID", Session.GetUserName())));
                this.Hide();
                b.Show();
            }
        }
    }
}
