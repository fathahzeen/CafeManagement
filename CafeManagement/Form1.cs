using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestlink_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (UsernameText.Text == "zeen" && passwordText.Text == "pass")
            {
                Dashboard ds = new Dashboard("Admin");
               ds.Show();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
