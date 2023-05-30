using JobsManagement.DTO;
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
    public partial class fAddJob : Form
    {
        private TaiKhoan loginAccount;
        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }

        private DateTime startTime = new DateTime();
        private DateTime finishTime = new DateTime();
        public fAddJob(DateTime ngayThangNam, int lapLai, TaiKhoan loginAcc)
        {
            InitializeComponent();
            load(lapLai);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(DAO.BoForm.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            dtpk.Value = ngayThangNam;
            this.LoginAccount = loginAcc;
        }

        #region title bar

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

        void setTimeBD()
        {
            startTime = new DateTime(dtpk.Value.Year, dtpk.Value.Month, dtpk.Value.Day, (int)nudH1.Value, (int)nudM1.Value, 0);
        }
        void setTimeKT()
        {
            finishTime = new DateTime(dtpk.Value.Year, dtpk.Value.Month, dtpk.Value.Day, (int)nudH2.Value, (int)nudM2.Value, 0);
        }
        void checkHopLe()
        {
            if(DateTime.Compare(startTime, finishTime) > 0)
            {
                lbKHopLeNgay.Visible = true;
                lbKHopLeGio.Visible = true;
                btnLuu.Enabled = false;
            }
            else
            {
                lbKHopLeNgay.Visible = false;
                lbKHopLeGio.Visible = false;
                btnLuu.Enabled = true;
            }    
        }
        void load(int lapLai)
        {
            lbNgayBatDau.Text = dtpk.Value.ToShortDateString();
            lbNgayKetThuc.Text = dtpk.Value.ToShortDateString();

            nudH1.Value = DateTime.Now.Hour;
            nudM1.Value = DateTime.Now.Minute;

            ucLL.ThuLapLai(lapLai);
        }
        bool clickThayDoi1 = false;
        bool clickThayDoi2 = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!clickThayDoi2)
            {
                lbNgayBatDau.Text = dtpk.Value.ToShortDateString();

                setTimeBD();
                label8.Text = startTime.ToString();

            }
            else
            {
                lbNgayKetThuc.Text = dtpk.Value.ToShortDateString();
                finishTime = dtpk.Value;

                setTimeKT();
                label11.Text = finishTime.ToString();
            }
            checkHopLe();

        }

        private void btnThayDoi1_Click(object sender, EventArgs e)
        {
            dtpk.Focus();
            SendKeys.Send("%{DOWN}");
            clickThayDoi1 = true;
            clickThayDoi2 = false;
        }

        private void btnThayDoi2_Click(object sender, EventArgs e)
        {
            dtpk.Focus();
            SendKeys.Send("%{DOWN}");
            clickThayDoi2 = true;
            clickThayDoi1 = false;
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
            lbNgayBatDau.Text = dtpk.Value.ToShortDateString();
            lbNgayKetThuc.Text = dtpk.Value.AddDays(1).ToLongDateString();
        }

        private void btnNgayMai_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(1);
            lbNgayBatDau.Text = dtpk.Value.ToShortDateString();
            lbNgayKetThuc.Text = dtpk.Value.AddDays(1).ToLongDateString();
        }

        void xuLyLapLai()
        {
            if (ucLL.check())
            {
                foreach (Control c in panel11.Controls)
                {
                    if (c is Label)
                    {
                        ((Label)c).ForeColor = SystemColors.ActiveCaption;
                    }
                }
                foreach (Control c in panel9.Controls)
                {
                    if (c is Label)
                    {
                        ((Label)c).ForeColor = SystemColors.ActiveCaption;
                    }
                    else
                    {
                        ((NumericUpDown)c).ForeColor = SystemColors.ActiveCaption;
                        ((NumericUpDown)c).Enabled = false;
                    }
                }
                btnThayDoi2.Enabled = false;
                lbLapLai.Visible = true;
            }
            else
            {
                label6.ForeColor = Color.FromArgb(0, 126, 249);
                label7.ForeColor = Color.FromArgb(0, 126, 249);
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                lbNgayKetThuc.ForeColor = Color.White;
                nudH2.ForeColor = SystemColors.WindowText;
                nudH2.Enabled = true;
                nudM2.ForeColor = SystemColors.WindowText;
                nudM2.Enabled = true;
                btnThayDoi2.Enabled = true;
                lbLapLai.Visible = false;
            }
        }
        private void ucLL_MouseMove(object sender, MouseEventArgs e)
        { 
            xuLyLapLai();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //luu cong viec
            if(ucLL.check())
            {
                MessageBox.Show("Công việc của bạn sẽ được lặp lại.", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }  

        }

        private void lbNgayKetThuc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nudH1_ValueChanged_1(object sender, EventArgs e)
        {

            setTimeBD();
            checkHopLe();
            label8.Text = startTime.ToString();
        }

        private void nudH2_ValueChanged(object sender, EventArgs e)
        {
            setTimeKT();
            checkHopLe();
            label11.Text = finishTime.ToString();
        }
    }
}
