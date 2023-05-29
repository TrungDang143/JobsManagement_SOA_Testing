using JobsManagement.DAO;
using JobsManagement.DTO;
using JobsManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Effects;
using Color = System.Drawing.Color;

namespace JobsManagement
{
    public partial class mainUI : Form
    {
        public DateTime dateOfdtpk = DateTime.Now;
        public bool isClose = true;

        public mainUI(string tenDN)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(DAO.BoForm.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            phanLoaiUser(tenDN);
        }

        private void phanLoaiUser(string tenDN)
        {
            lbUserName.Text = TaiKhoanDAO.getUserName(tenDN);
            int vt = (253 - lbUserName.Size.Width)/2;
            lbUserName.Location = new Point(vt,198);

            bool isAD = TaiKhoanDAO.isAdmin(tenDN);
            if (isAD)
            {
                pictureBox1.Image = Properties.Resources.icon_adminFix;
                lbUserName.ForeColor = Color.Gold;
            }
        }

        #region new title bar
        private void icoMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icoClose_Click(object sender, EventArgs e)
        {
            isClose = true;
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
            pnlContent.AutoScroll = false;
            pnlContent.Controls.Clear();
            pnlHighLight1.Visible = false;
            pnlHighLight2.Visible = false;
            pnlHighLight3.Visible = false;
            pnlHighLight4.Visible = false;
            btnHome.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            btnCalendar.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            btnTK.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            btnSetting.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            pnlContent.Controls.Clear();
        }
        public void btnHome_Click(object sender, EventArgs e)
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
            resetSelect();
            pnlHighLight4.Visible = true;

            ucSetting ucSetting = new ucSetting();
            pnlContent.Controls.Add(ucSetting);

            pnlContent.AutoScroll = false;
            pnlContent.HorizontalScroll.Enabled = false;
            pnlContent.HorizontalScroll.Visible = false;
            pnlContent.HorizontalScroll.Maximum = 0;
            pnlContent.AutoScroll = true;

            btnSetting.BackColor = Color.FromArgb(63, 68, 97);
            lbTitle.Text = "Cài đặt";
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

        private void mainUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isClose) { Application.Exit(); }
        }

        public void showBlurForm()
        {
            //Form blurF = new Form();
            //blurF.Size = new Size(1408, 800);
            ////blurF.Location = located;
            //blurF.StartPosition = FormStartPosition.CenterParent;
            //blurF.Opacity = 0.9;
            //blurF.Show();
        }
        public void closeBlurForm()
        {
            //blurF.Close();
            //blurF = null;
        }

    }
}
