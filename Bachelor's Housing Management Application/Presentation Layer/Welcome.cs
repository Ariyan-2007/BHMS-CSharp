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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bachelor_Click(object sender, EventArgs e)
        {
            BLogin b = new BLogin();
            this.Hide();
            b.Show();
        }

        private void flatOwner_Click(object sender, EventArgs e)
        {
            FOLogin f = new FOLogin();
            this.Hide();
            f.Show();
        }
    }
}
