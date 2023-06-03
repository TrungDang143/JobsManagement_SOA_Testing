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
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using Color = System.Drawing.Color;

namespace JobsManagement
{
    public partial class mainUI : Form
    {
        public DateTime dateOfdtpk = DateTime.Now;
        public bool isClose = true;

        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }

        public mainUI(TaiKhoan loginAcc)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(DAO.BoForm.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            this.LoginAccount = loginAcc;

            backgroundWorker1.RunWorkerAsync();

            loadDuLieuVao(loginAcc);

            setTimeThongBao(LoginAccount.HNN, LoginAccount.MNN);

            tmThongBaoAll.Start();
        }

        public void setTimeThongBao(int h, int m)
        {
            tmThongBaoAll.Interval = (h * 3600 + m * 60) * 1000;
        }
        private void loadDuLieuVao(TaiKhoan loginAcc)
        {
            dongHo.Text = DateTime.Now.ToString("HH:MM:ss");
            //addFont.newFont();
            //dongHo.Font = new Font("DIGIFACE", 20, FontStyle.Bold);

            lbUserName.Text = loginAcc.TenHT;
            int vt = (253 - lbUserName.Size.Width)/2;
            lbUserName.Location = new Point(vt,198);

            bool isAD = loginAcc.IsAD;
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

            ucHome ucHome = new ucHome(loginAccount);

            pnlContent.Controls.Add(ucHome);
            btnHome.BackColor = Color.FromArgb(63, 68, 97);
            lbTitle.Text = "Trang chủ";
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            resetSelect();
            pnlHighLight2.Visible = true;
            
            ucCalendar ucCalendar = new ucCalendar(LoginAccount);
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

            ucSetting ucSetting = new ucSetting(loginAccount);
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
            if(isClose) {
                Application.Exit(); 
            }
        }

        #region thong bao + dong ho
        private void dongHo_Click(object sender, EventArgs e)
        {

        }

        private void tmThongBaoAll_Tick(object sender, EventArgs e)
        {
            
            if (LoginAccount.NhacNho == false)
                return;
            //notifyIcon1.Visible = true;
            int cv = DAO.CongViecDAO.tongCV(LoginAccount.TenDN);
            int cvddr = DAO.CongViecDAO.CVdangDienRa(LoginAccount.TenDN);
            string tb = string.Empty;
            if(cv > 0)
            {
                if(cvddr > 0 && cvddr < cv)
                {
                    tb = string.Format("Có {0} công việc đang diễn ra\nvà {1} công việc sắp diễn ra", cvddr, cv-cvddr);
                }
                else if(cvddr > 0 && cvddr == cv)
                {
                    tb = string.Format("Có {0} công việc đang diễn ra", cvddr);
                }
                else
                {
                    tb = string.Format("Có {0} công việc sắp diễn ra", cv);
                }
            }
            else
            {
                tb = "Bạn không có công việc ";
            }
            ThongBao.ShowBalloonTip(2000, string.Format("Thông báo công việc ngày {0}",DateTime.Now.ToString("dd/MM/yyyy")), tb, ToolTipIcon.Info);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (!worker.CancellationPending)
            {
                // Get the current time
                string currentTime = DateTime.Now.ToString("HH:mm:ss");

                // Report the progress back to the UI thread
                worker.ReportProgress(0, currentTime);

                // Wait for one second before repeating
                Thread.Sleep(1000);
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string currentTime = e.UserState as string;
            dongHo.Text = currentTime;

            if(DateTime.Now.Second == 0)
            {
                
            
            }    
        }

        private void mainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        #endregion

        #region blur old form
        static blurForm f;
        public void showBlur()
        {
            f = new blurForm();
            f.Owner = this;
            f.Location = this.Location;
            f.Size = this.ClientSize;
            f.Show();
        }
        public void closeBlur()
        {
            f.Close();
        }
        #endregion
    }
}
