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
    public partial class Booked : Form
    {
        int count, right = 0, left = 0, id;
        

        public Booked()
        {
            InitializeComponent();
        }

        public Booked(int x)
        {
            InitializeComponent();
            count = AdService.GetPictureCount(x);
            id = x;
            Initialize(x);
        }

        private void Initialize(int x)
        {
            idTxt.Text = AdService.GetADDetails("FID", x);
            nameTxt.Text = AdService.GetADDetails("FlatName", x);
            ownerTxt.Text = AdService.GetADDetails("Username", x);
            locationTxt.Text = AdService.GetADDetails("Location", x);
            addressTxt.Text = AdService.GetADDetails("Address", x);
            roomsTxt.Text = AdService.GetADDetails("Rooms", x);
            rentTxt.Text = AdService.GetADDetails("Rent", x) + " Tk";
            serviceTxt.Text = AdService.GetADDetails("Services", x);
            numberTxt.Text = UserService.GetUserInfoFO("Number", ownerTxt.Text);
            pictureBox1.Image = Image.FromFile(AdService.GetPicture("Path", x, 0));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void back_Click(object sender, EventArgs e)
        {
            BHomePage b = new BHomePage();
            this.Hide();
            b.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (AdService.GetADDetails("Status", id) == "Rented")
            {
                MessageBox.Show("You have already rented the flat! Cannot Perform The Action");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the booking", "Confirmation Tab", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UserService.ResetFID(Session.GetUserName());
                    AdService.ModifyAdvertisement(id, "Available");
                    MessageBox.Show("Booking Cancelled");
                    BHomePage b = new BHomePage();
                    this.Hide();
                    b.Show();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (AdService.GetADDetails("Status", id) == "Rented")
            {
                MessageBox.Show("You have already rented the flat! Cannot Perform The Action");
            }
            else
            {
                string bpn = UserService.GetUserInfoB("Number", Session.GetUserName());
                string fopn = UserService.GetUserInfoFO("Number", AdService.GetADDetails("Username", id));
                string bb = (UserService.GetUserInfoB("Balance", Session.GetUserName()));
                string fob = (UserService.GetUserInfoFO("Balance", AdService.GetADDetails("Username", id)));
                string rent = (AdService.GetADDetails("Rent", id));
                CashOut c = new CashOut(bpn, fopn, bb, fob, rent, id);
                c.Show();
            }
        }

        private void scroll_Click(object sender, EventArgs e)
        {
            if (right < count - 1)
            {
                right = left;
                right++;
                pictureBox1.Image = Image.FromFile(AdService.GetPicture("Path", id, right));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                left = right;
            }
            else
            {
                right = 0;
                pictureBox1.Image = Image.FromFile(AdService.GetPicture("Path", id, right));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                left = right;
            }
        }

        private void scrollL_Click(object sender, EventArgs e)
        {
            if (left > 0)
            {
                left = right;
                left--;
                pictureBox1.Image = Image.FromFile(AdService.GetPicture("Path", id, left));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                right = left;

            }

            else
            {
                left = count - 1;
                pictureBox1.Image = Image.FromFile(AdService.GetPicture("Path", id, left));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                right = left;
            }
        }

        private void Booked_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
