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
    public partial class ADDisplay : Form
    {

        int count;
        string[,] listItem;
        public ADDisplay()
        {
            InitializeComponent();
            count = AdService.GetADCount(Session.GetUserName(),0);
            AddItem();
        }

        private void AddItem()
        {
            listItem = new string[count, 3];
            int fc=0,flc=0,lc=0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        listItem[i, j] = AdService.GetADInfo("FID", Session.GetUserName(), fc);
                        fc++;
                    }
                    else if (j == 1)
                    {
                        listItem[i, j] = AdService.GetADInfo("FlatName", Session.GetUserName(), flc);
                        flc++;
                    }
                    else
                    {
                        listItem[i, j] = AdService.GetADInfo("Location", Session.GetUserName(), lc);
                        lc++;
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

        private void ADDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            FOHomePage f = new FOHomePage();
            this.Hide();
            f.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = 0; 
            id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            
            
            if (AdService.GetADDetails("Status",id) !="Rented"  && AdService.GetADDetails("Status", id) != "Booked")
            {
                AdService.DeleteAdvertisement(id);
                count = AdService.GetADCount();
                this.Controls.Clear();
                this.InitializeComponent();
                AddItem();
            }
            else
            {
                MessageBox.Show("The flat has been rented/booked.. Cannot delete it's information");
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ShowAD s = new ShowAD(Convert.ToInt32(listView1.SelectedItems[0].Text));
                this.Hide();
                s.Show();
            }
            else
            {
                MessageBox.Show("Please Select An Advertisement First!");
            }
        }
    }
}
