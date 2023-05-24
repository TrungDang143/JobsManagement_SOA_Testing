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

namespace JobsManagement
{
    public partial class mainUI : Form
    { 
        public mainUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(DAO.BoForm.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }

        #region new title bar
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

        #region menu
        
        void resetSelect()
        {
            pnlContent.Controls.Clear();
            pnlHighLight1.Visible = false;
            pnlHighLight2.Visible = false;
            pnlHighLight3.Visible = false;
            pnlHighLight4.Visible = false;
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
            btnTK.BackColor = Color.FromArgb(24, 30, 54);
            btnSetting.BackColor = Color.FromArgb(24, 30, 54);

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            resetSelect();
            pnlHighLight1.Visible = true;
            
            ucHome ucHome = new ucHome();
            pnlContent.Controls.Add(ucHome);
            btnHome.BackColor = Color.FromArgb(63, 68, 97);
            lbTitle.Text = "Trang chủ";
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            resetSelect();
            pnlHighLight2.Visible = true;
            
            ucCalendar ucCalendar = new ucCalendar();
            pnlContent.Controls.Add(ucCalendar);
            btnCalendar.BackColor = Color.FromArgb(63, 68, 97);
            lbTitle.Text = "Lịch";
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            resetSelect();
            pnlHighLight3.Visible = true;
            
            ucThongKe ucThongKe = new ucThongKe();  
            pnlContent.Controls.Add(ucThongKe);
            btnTK.BackColor = Color.FromArgb(63, 68, 97);
            lbTitle.Text = "Thống kê";
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            pnlHighLight1.Visible = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pnlHighLight2.Visible = true;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pnlHighLight3.Visible = true;
        }
        private void btnSetting_MouseHover(object sender, EventArgs e)
        {
            pnlHighLight4.Visible = true;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            if(string.Compare( lbTitle.Text, "Trang chủ", true) != 0)
            {
                pnlHighLight1.Visible = false;
                btnHome.BackColor = Color.FromArgb(24, 30, 54);
            }    
        }

        private void btnCalendar_MouseLeave(object sender, EventArgs e)
        {
            if (string.Compare(lbTitle.Text, "Lịch", true) != 0)
            {
                pnlHighLight2.Visible = false;
                btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
            }
        }

        private void btnTK_MouseLeave(object sender, EventArgs e)
        {

            if (string.Compare(lbTitle.Text, "Thống kê", true) != 0)
            {
                pnlHighLight3.Visible = false;
                btnTK.BackColor = Color.FromArgb(24, 30, 54);
            }
        }


        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            if (string.Compare(lbTitle.Text, "Cài đặt", true) != 0)
            {
                pnlHighLight4.Visible = false;
                btnSetting.BackColor = Color.FromArgb(24, 30, 54);
            }
        }
        #endregion


        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
