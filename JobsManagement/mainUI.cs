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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public mainUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        #region menu
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlHighLight1.Visible = true;
            pnlContent.Controls.Clear();
            ucHome ucHome = new ucHome();
            pnlContent.Controls.Add(ucHome);
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Trang chủ";
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlHighLight2.Visible = true;
            pnlContent.Controls.Clear();
            ucCalendar ucCalendar = new ucCalendar();
            pnlContent.Controls.Add((ucCalendar));
            btnCalendar.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Lịch";
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            pnlHighLight3.Visible = true;
            pnlContent.Controls.Clear();
            ucThongKe ucThongKe = new ucThongKe();  
            pnlContent.Controls.Add(ucThongKe);
            btnTK.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Thống kê";
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

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            pnlHighLight1.Visible = false;
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalendar_MouseLeave(object sender, EventArgs e)
        {
            pnlHighLight2.Visible = false;
            btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTK_MouseLeave(object sender, EventArgs e)
        {
            pnlHighLight3.Visible = false;
            btnTK.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion
    }
}
