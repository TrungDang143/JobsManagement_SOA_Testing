using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JobsManagement
{
    public partial class fSignUp : Form
    {
        

        public fSignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(BoForm.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }
        #region title bar

        private void icoMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DAO.TitleBar.ReleaseCapture();
                DAO.TitleBar.SendMessage(Handle, DAO.TitleBar.WM_NCLBUTTONDOWN, DAO.TitleBar.HTCAPTION, 0);
            }
        }
        #endregion

        #region High light
        void resetHL()
        {
            HLmatkhau.BackColor = Color.FromArgb(0, 126, 249);
            HLtenHT.BackColor = Color.FromArgb(0, 126, 249);
            HLtenTK.BackColor = Color.FromArgb(0, 126, 249);
            HLtraLoi.BackColor = Color.FromArgb(0, 126, 249);
            HLxacNhanMK.BackColor = Color.FromArgb(0, 126, 249);

        }
        private void txbTK_Click(object sender, EventArgs e)
        {
            resetHL();
            HLtenTK.BackColor = Color.SeaGreen;
        }

        private void txbTen_Click(object sender, EventArgs e)
        {
            resetHL();
            HLtenHT.BackColor = Color.SeaGreen;
        }

        private void txbTraLoi_Click(object sender, EventArgs e)
        {
            resetHL();
            HLtraLoi.BackColor = Color.SeaGreen;
        }

        private void txbXNMK_Click(object sender, EventArgs e)
        {
            resetHL();
            HLxacNhanMK.BackColor = Color.SeaGreen;
        }

        private void txbMK_Click(object sender, EventArgs e)
        {
            resetHL();
            HLmatkhau.BackColor = Color.SeaGreen;
        }

        #endregion

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isMat2 == false)
            {
                pictureBox1.Image = Properties.Resources.icons8_open_eye_32;
                isMat2 = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.icons8_close_eye_32;
                isMat2 = false;
            }
            txbXNMK.UseSystemPasswordChar = !txbMK.UseSystemPasswordChar;
        }


        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            if(txbTK.Text.Length == 19)
            {
                lbGioiHanTK.Visible = true;
            }
            else
            {
                lbGioiHanTK.Visible = false;
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
        }

        private void txbXNMK_TextChanged(object sender, EventArgs e)
        {
            if (txbXNMK.Text.Length == 19)
            {
                lbGioiHanXNMK.Visible = true;
            }
            else
            {
                lbGioiHanXNMK.Visible = false;
            }
        }

        private void txbTen_TextChanged(object sender, EventArgs e)
        {
            if (txbTen.Text.Length == 29)
            {
                lbGioiHanTHT.Visible = true;
            }
            else
            {
                lbGioiHanTHT.Visible = false;
            }
        }

        private void txbTraLoi_TextChanged(object sender, EventArgs e)
        {
            if (txbTraLoi.Text.Length == 29)
            {
                lbGioiHanTL.Visible = true;
            }
            else
            {
                lbGioiHanTL.Visible = false;
            }
        }
    }
}
