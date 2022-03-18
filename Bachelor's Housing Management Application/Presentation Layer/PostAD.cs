using Bachelor_s_Housing_Management_Application.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachelor_s_Housing_Management_Application.Presentation_Layer
{
    public partial class PostAD : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        int currentID;
        Random random = new Random();
        string rand;
        
        public PostAD()
        {
            InitializeComponent();
            
            currentID = AdService.GetFID();
             
            AdService.ReSeed("Ad_Info",currentID);
            
            rand = random.Next(0, 100).ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            FOHomePage f = new FOHomePage();
            this.Hide();
            f.Show();
        }

        private void PostAD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string temp = " ";
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                temp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"BHMS\Pictures\"+Session.GetUserName()+"\\"+rand);

                if (!Directory.Exists(temp))
                {
                    Directory.CreateDirectory(temp);
                }

                pathBox.Text = Path.Combine(temp, @""+ currentID + Session.count + ".jpg");

                
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (pathBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please browse and select a Picture first!");
            }
            else
            {
                if (Session.count < 6)
                {
                    File.Copy(ofd.FileName, pathBox.Text, true);
                    int i = AdService.AddPicture(pathBox.Text);

                    if (i == 1)
                    {
                        MessageBox.Show("Picture Succesfully Added");
                        Session.count++;
                    }

                }
                else
                {
                    MessageBox.Show("Can't Add Anymore Pictures");
                }
            }
        }

        private void post_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals(String.Empty) || locationBox.Text.Equals(String.Empty) || addressBox.Text.Equals(String.Empty) || roomsBox.Text.Equals(String.Empty) || rentBox.Text.Equals(String.Empty))
            {
                MessageBox.Show("Error! Text Fields Cannot Be Empty");
            }
            else
            {
                if(Session.count==1)
                {
                    MessageBox.Show("Please Add Atleast 1 Picture");
                }
                else
                {
                    string services = "| ";

                    if(gasCheck.Checked == true)
                    {
                        services += gasCheck.Text + " | ";
                    }
                    if(generatorCheck.Checked == true)
                    {
                        services += generatorCheck.Text + " | ";
                    }
                    if (liftCheck.Checked == true)
                    {
                        services += liftCheck.Text + " | ";
                    }
                    if (wifiCheck.Checked == true)
                    {
                        services += wifiCheck.Text + " | ";
                    }
                    if(gasCheck.Checked == false && generatorCheck.Checked == false && liftCheck.Checked == false && wifiCheck.Checked == false)
                    {
                        services = "None";
                    }

                    int result = AdService.AddAdvertisement(Session.GetUserName(), nameBox.Text, locationBox.Text, addressBox.Text, roomsBox.Text, rentBox.Text, services, "Available");

                    if (result == 1)
                    {
                        AdService.SetFID(currentID);
                        MessageBox.Show("Advertisement Succesfully Created!");
                        FOHomePage f = new FOHomePage();
                        Session.count = 1;
                        this.Hide();
                        f.Show();
                    }

                }
            }
        }
    }
}
