using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void fLogin_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else { txbPassword.UseSystemPasswordChar = true; }
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignUp f = new fSignUp();
            f.ShowDialog();
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fForgot f = new fForgot();
            f.ShowDialog();
        }
    }
}
