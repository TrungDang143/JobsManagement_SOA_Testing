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

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txbMK.UseSystemPasswordChar = !txbMK.UseSystemPasswordChar;

        }
        private void showPassword_CheckedChanged2(object sender, EventArgs e)
        {
            txbXNMK.UseSystemPasswordChar = !txbXNMK.UseSystemPasswordChar;

        }

        private void fSignUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
