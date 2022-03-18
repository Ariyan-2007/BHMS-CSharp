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
    public partial class CashOut : Form
    {
        string bpn, fopn, bb, fob, rent;
        string nbb, nfob, code;
        int id;

        private void confirm_Click(object sender, EventArgs e)
        {
            if (codeBox.Text == code)
            {
                UserService.UpdateUserInfoB("Balance", nbb, Session.GetUserName());
                UserService.UpdateUserInfoFO("Balance", nfob, AdService.GetADDetails("Username",id));
                AdService.ModifyAdvertisement(id, "Rented");
                MessageBox.Show("Transaction Completed!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Code.. Can't Perform Transaction");
            }
        }

        public CashOut()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (uPNBox.Text.Equals(string.Empty) || foPNBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Error! Can't Keep Any Fields Empty");
            }
            else
            {
                if (uPNBox.Text != bpn)
                {
                    MessageBox.Show("Error! User Phone Number Doesn't Match");
                }
                else
                {
                    if (foPNBox.Text != fopn)
                    {
                        MessageBox.Show("Error! Flat Owner Phone Number Doesn't Match");
                    }
                    else
                    {
                        if ((bKashRB.Checked == false) && (rocketRB.Checked == false))
                        {
                            MessageBox.Show("Error! Payment Method not marked, Please Select");
                        }
                        else
                        {
                            if(Convert.ToInt32(bb) >= Convert.ToInt32(rent))
                            {
                                nfob = (Convert.ToInt32(rent) + Convert.ToInt32(fob)).ToString();
                                nbb = (Convert.ToInt32(bb) - Convert.ToInt32(rent)).ToString();
                                Random r = new Random();
                                code = r.Next(1000, 10000).ToString();
                                codeBox.Text = code;
                                MessageBox.Show("Code Generated! Confirm The Transaction!");
                            }
                            else
                            {
                                MessageBox.Show("Error! Insufficient Balance");
                            }

                            
                        }
                    }
                }
            }
        }

        public CashOut(string bpn, string fopn, string bb, string fob, string rent, int id)
        {
            InitializeComponent();
            this.bpn = bpn;
            this.fopn = fopn;
            this.bb = bb;
            this.fob = fob;
            this.rent = rent;
            this.id = id;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CashOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
