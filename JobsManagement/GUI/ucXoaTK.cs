using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsManagement.GUI
{
    public partial class ucXoaTK : UserControl
    {
        public ucXoaTK()
        {
            InitializeComponent();
        }

        
        private void btnXN_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            Panel panel1 = panel.Parent as Panel;
            Panel panel2 = panel1.Parent as Panel;
            UserControl uc = panel2.Parent as UserControl;
            Panel panel3 = uc.Parent as Panel;
            mainUI mainF = panel3.Parent as mainUI;

            mainF.isClose = false;
            
            lbSYS.Visible = true;
            TaiKhoanDAO.Instance.xoaTK(txbXNMK.Text);
            Task.Delay(2000).Wait();
            mainF.Close();

        }
        private bool isEqual = false;

        private void checkXN()
        {
            if (isEqual)
            {
                btnXN.Enabled = true;
                panel13.BackColor = Color.Red;
            }
            else
            {
                btnXN.Enabled = false;
                panel13.BackColor = Color.DarkGray;
            }
        }
        private void txbMK_TextChanged(object sender, EventArgs e)
        {
            if (txbMK.Text.Length == 19)
            {
                lbGioiHanMK.Visible = true;
            }
            else
            {
                lbGioiHanMK.Visible = false;
            }

            if (txbXNMK.Text.ToString() == txbMK.Text.ToString())
            {
                picCheck.Image = Properties.Resources.icons8_tick_501;
                isEqual = true;
            }
            else
            {
                picCheck.Image = Properties.Resources.icons8_multiply_50;
                isEqual = false;
            }
            checkXN();
        }


        private void txbXNMK_TextChanged(object sender, EventArgs e)
        {
            if (txbXNMK.Text.ToString() == txbMK.Text.ToString())
            {
                picCheck.Image = Properties.Resources.icons8_tick_501;
                isEqual = true;
            }
            else
            {
                picCheck.Image = Properties.Resources.icons8_multiply_50;
                isEqual = false;
            }

            if (string.IsNullOrEmpty(txbXNMK.Text.ToString()))
                picCheck.Visible = false;
            else picCheck.Visible = true;

            checkXN();
        }

        private bool isMat1 = false;
        private bool isMat2 = false;
        private void mat1_Click(object sender, EventArgs e)
        {
            if (isMat1 == false)
            {
                mat1.Image = Properties.Resources.icons8_open_eye_32;
                isMat1 = true;
            }
            else
            {
                mat1.Image = Properties.Resources.icons8_close_eye_32;
                isMat1 = false;
            }
            txbMK.UseSystemPasswordChar = !txbMK.UseSystemPasswordChar;
        }

        private void mat2_Click(object sender, EventArgs e)
        {
            if (isMat2 == false)
            {
                mat2.Image = Properties.Resources.icons8_open_eye_32;
                isMat2 = true;
            }
            else
            {
                mat2.Image = Properties.Resources.icons8_close_eye_32;
                isMat2 = false;
            }
            txbXNMK.UseSystemPasswordChar = !txbXNMK.UseSystemPasswordChar;
        }

        private void lbGioiHanMK_Click(object sender, EventArgs e)
        {

        }
    }
}
