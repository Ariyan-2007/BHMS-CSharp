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
    public partial class FOSignUp : Form
    {
        string path = " ";
        OpenFileDialog ofd = new OpenFileDialog();
        public FOSignUp()
        {
            InitializeComponent();

        }

        private void FOSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            FOLogin f = new FOLogin();
            this.Hide();
            f.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (fullNameBox.Text.Equals(string.Empty) || usernameBox.Text.Equals(string.Empty) || passwordBox.Text.Equals(string.Empty) || confirmPasswordBox.Text.Equals(string.Empty) || phoneNumberBox.Text.Equals(string.Empty) || addressBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Incomplete Submission! Please fill up all the fields");
            }
            else
            {
                if (usernameBox.Text.Equals(UserService.GetUserInfoFO("Username", usernameBox.Text)))
                {
                    MessageBox.Show("Error! Username Already Exists");
                }
                else
                {
                    if (passwordBox.Text != confirmPasswordBox.Text)
                    {
                        MessageBox.Show("Password Doesn't Match! Try Again");
                    }
                    else
                    {
                        if ((maleRB.Checked == false) && (femaleRB.Checked == false))
                        {
                            MessageBox.Show("Please select a gender");
                        }
                        else if (checkBox1.Checked == false)
                        {
                            MessageBox.Show("Agreement Unchecked! Check To Complete Submission");
                        }
                        else if (dateTimePicker1.Value.Date >= DateTime.Now.Date)
                        {
                            MessageBox.Show("Please select a valid date of birth");
                        }

                        else if (path == " ")
                        {
                            MessageBox.Show("Please Add a Picture");
                        }

                        else
                        {
                            string gender, dob;

                            File.Copy(ofd.FileName, path, true);
                            if (maleRB.Checked)
                            {
                                gender = "Male";
                            }
                            else
                            {
                                gender = "Female";
                            }
                            dob = dateTimePicker1.Value.Date.ToString();

                            int result = UserService.AddUserFO(usernameBox.Text, fullNameBox.Text, passwordBox.Text, phoneNumberBox.Text, gender, dob, addressBox.Text, path);

                            if (result == 1)
                            {
                                MessageBox.Show("Account Creation Completed");
                                FOLogin f = new FOLogin();
                                this.Hide();
                                f.Show();

                            }
                        }

                    }
                }
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string temp = " ";
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                temp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"BHMS\FOprofile");

                if (!Directory.Exists(temp))
                {
                    Directory.CreateDirectory(temp);
                }

                path = Path.Combine(temp, @"" + usernameBox.Text + ".jpg");


            }
        }
    }
}
