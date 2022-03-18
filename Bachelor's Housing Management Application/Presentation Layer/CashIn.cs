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
    public partial class CashIn : Form
    {
        string amount = UserService.GetUserInfoB("Balance",Session.GetUserName());
        string code;
        public CashIn()
        {
            InitializeComponent();
        }



        private void select_Click(object sender, EventArgs e)
        {
            if(amountBox.Text.Equals(string.Empty) || phoneNumberBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Error! Can't Keep Any Fields Empty");
            }
            else
            {
                if(phoneNumberBox.Text != UserService.GetUserInfoB("Number",Session.GetUserName()))
                {
                    MessageBox.Show("Error! Phone Number Doesn't Match");
                }
                else
                {
                    if ((bKashRB.Checked == false) && (rocketRB.Checked == false))
                    {
                        MessageBox.Show("Error! Payment Method not marked, Please Select");
                    }
                    else
                    {
                        amount = (Convert.ToInt32(amountBox.Text) + Convert.ToInt32(amount)).ToString();
                        Random r = new Random();
                        code = r.Next(1000, 10000).ToString();
                        codeBox.Text = code;
                        MessageBox.Show("Code Generated! Confirm The Transaction!");
                    }
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CashIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (codeBox.Text == code)
            {
                UserService.UpdateUserInfoB("Balance", amount, Session.GetUserName());
                MessageBox.Show("Transaction Completed!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Code.. Can't Perform Transaction");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bKashRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rocketRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void codeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
