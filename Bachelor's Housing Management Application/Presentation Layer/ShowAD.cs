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
    public partial class ShowAD : Form
    {
        int count, right = 0, left = 0, id;
        string validation;
        public ShowAD()
        {
            InitializeComponent();
        }

        public ShowAD(int x)
        {
            InitializeComponent();
            count = AdService.GetPictureCount(x);
            id = x;
            Initialize(x);
        }

        public ShowAD(int x, string y)
        {
            InitializeComponent();
            count = AdService.GetPictureCount(x);
            id = x;
            validation = y;
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
            if (validation == "Bachelor")
            {
                Search s = new Search();
                this.Hide();
                s.Show();
            }
            else
            {
                ADDisplay a = new ADDisplay();
                this.Hide();
                a.Show();
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
                left = count-1;
                pictureBox1.Image = Image.FromFile(AdService.GetPicture("Path", id, left));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                right = left;
            }
        }

        private void ShowAD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void scroll_Click(object sender, EventArgs e)
        {
            if(right<count-1)
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
    }
}
