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
    public partial class Search : Form
    {
        int count;
        string[,] listItem;

        public Search()
        {
            InitializeComponent();
            
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            BHomePage b = new BHomePage();
            this.Hide();
            b.Show();
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (locationBox.Equals(string.Empty))
            {
                MessageBox.Show("Error! Please Select Location");
            }
            else
            {
                listView1.Items.Clear();
                count = AdService.GetADCount(locationBox.Text);
                AddItem(locationBox.Text);
            }
        }

        private void AddItem(string x)
        {
            listItem = new string[count, 4];
            int fc = 0, rc = 0, nc = 0, sc = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        listItem[i, j] = AdService.ADSearch("FID", x, fc);
                        fc++;
                    }
                    else if (j == 1)
                    {
                        listItem[i, j] = AdService.ADSearch("Rent", x, rc);
                        rc++;
                    }
                    else if (j == 2)
                    {
                        listItem[i, j] = AdService.ADSearch("Rooms", x, nc);
                        nc++;
                    }
                    else
                    {
                        listItem[i, j] = AdService.ADSearch("Status", x, sc);
                        sc++;
                    }

                }

            }

            int max_row = listItem.GetUpperBound(0);
            int max_col = listItem.GetUpperBound(1);
            for (int row = 0; row <= max_row; row++)
            {
                ListViewItem new_item = listView1.Items.Add(listItem[row, 0]);
                for (int col = 1; col <= max_col; col++)
                {
                    new_item.SubItems.Add(listItem[row, col]);
                }
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ShowAD s = new ShowAD(Convert.ToInt32(listView1.SelectedItems[0].Text),"Bachelor");
                this.Hide();
                s.Show();
            }
            else
            {
                MessageBox.Show("Please Select An Advertisement First!");
            }
        }

        private void book_Click(object sender, EventArgs e)
        {
            if(AdService.GetADDetails("Status",Convert.ToInt32(listView1.SelectedItems[0].Text)) == "Available" && UserService.GetUserInfoB("FID",Session.GetUserName()) == "0")
            {
                AdService.ModifyAdvertisement(Convert.ToInt32(listView1.SelectedItems[0].Text),"Booked");
                UserService.SetFID(Convert.ToInt32(listView1.SelectedItems[0].Text), Session.GetUserName());
                listView1.Items.Clear();
                AddItem(locationBox.Text);
                MessageBox.Show("Booking Succesfull! You can now complete the transaction procedure from Booked Page");
            }
            else if(UserService.GetUserInfoB("FID", Session.GetUserName()) != "0")
            {
                MessageBox.Show("You have already Booked a Flat.. Please cancel booking before booking another flat");
            }
            else
            {
                MessageBox.Show("Flat is already Booked or Rented.. Try another one");
            }
        }
    }
}