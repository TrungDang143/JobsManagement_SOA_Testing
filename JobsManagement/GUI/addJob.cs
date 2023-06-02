using JobsManagement.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            
            dtpk.Value = ngayThangNam;
            load(lapLai);
            
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(DAO.BoForm.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
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

        #region lap lai
        private bool checkHN = true;//tránh bi bo check het cac ngay khi bo check cbxHN
        private void cbxtHN_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxtHN.Checked)
            {
                checkHN = true;
                cbt2.Checked = true;
                cbt3.Checked = true;
                cbt4.Checked = true;
                cbt5.Checked = true;
                cbt6.Checked = true;
                cbt7.Checked = true;
                cbcn.Checked = true;
            }
            else if (!cbxtHN.Checked && checkHN)
            {
                cbt2.Checked = false;
                cbt3.Checked = false;
                cbt4.Checked = false;
                cbt5.Checked = false;
                cbt6.Checked = false;
                cbt7.Checked = false;
                cbcn.Checked = false;
            }
            xuLyLapLai();
        }

        private void cbcn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbt2.Checked && cbt3.Checked && cbt4.Checked && cbt5.Checked && cbt6.Checked && cbt7.Checked && cbcn.Checked)
            {
                cbxtHN.Checked = true;
            }
            else
            {
                checkHN = false;
                cbxtHN.Checked = false;
            }
            xuLyLapLai();
        }

        public bool checkLapLai()
        {
            if (cbt2.Checked || cbt3.Checked || cbt4.Checked || cbt5.Checked || cbt6.Checked || cbt7.Checked || cbcn.Checked)
            {
                return true;
            }
            return false;
        }
        public void ThuLapLai(int a)
        {
            switch (a)
            {
                case 0: cbt2.Checked = true; break;
                case 1: cbt3.Checked = true; break;
                case 2: cbt4.Checked = true; break;
                case 3: cbt5.Checked = true; break;
                case 4: cbt6.Checked = true; break;
                case 5: cbt7.Checked = true; break;
                case 6: cbcn.Checked = true; break;
                default: break;
            }
        }
        public string[] getDayOfWeek()
        {
            string[] days = new string[7];


            return days;
        }
        public bool[] getLapLai()
        {
            bool[] ll = new bool[9];

            if (cbxtHN.Checked)
                ll[1] = true;
            else
            {
                if (cbt2.Checked) ll[2] = true;
                if (cbt3.Checked) ll[3] = true;
                if (cbt4.Checked) ll[4] = true;
                if (cbt5.Checked) ll[5] = true;
                if (cbt6.Checked) ll[6] = true;
                if (cbt7.Checked) ll[7] = true;
                if (cbcn.Checked) ll[8] = true;
            }

            ll[0] = true;
            for (int i = 1; i < 9; i++)
                if (ll[i] == true)
                {
                    ll[0] = false;
                    break;
                }
            return ll;
        }
        public void uncheckedAll()
        {
            cbt2.Checked = false;
            cbcn.Checked = false;
            cbxtHN.Checked = false;
            cbt3.Checked = false;
            cbt4.Checked = false;
            cbt5.Checked = false;
            cbt6.Checked = false;
            cbt7.Checked = false;
        }
        public void xuLyLapLai()
        {
            if (checkLapLai())
            {
                if (cbxtHN.Checked)
                {
                    dtpk.Enabled = true;
                }
                else dtpk.Enabled = false;

                
                btnThayDoi2.Enabled = false;
                lbLapLai.Visible = true;
                pnlHL.Location = new Point(btnThayDoi1.Location.X, btnThayDoi1.Location.Y + btnThayDoi1.Height);
                
                bool[] lapThu = getLapLai();

                if (!lapThu[1] == true)
                {
                    int columnHomNay = getColumnByDate(DateTime.Now);
                    int columnLap = columnHomNay;
                    for (int i = 1; i < 9; i++)
                    {
                        if (lapThu[i] == true)
                        {
                            columnLap = i - 2;
                            break;
                        }
                    }

                    if (columnHomNay < columnLap)
                    {
                        dtpk.Value = DateTime.Now.AddDays(-columnHomNay + columnLap);
                    }
                    else
                    {
                        dtpk.Value = DateTime.Now.AddDays(7 - (columnHomNay - columnLap));
                    }
                }
                else
                {
                    dtpk.Value = DateTime.Now;
                    setTimeBD();
                }
            }
            else
            {
                btnThayDoi2.Enabled = true;
                lbLapLai.Visible = false;
                label11.Text = finishTime.ToString();

                dtpk.Enabled = true;
            }
            setTimeKT();
            nudH2.Value = 23;
            nudM2.Value = 59;
            checkHopLe();
        }
        #endregion
        
        void setTimeBD()
        {
            lbNgayBatDau.Text = dtpk.Value.ToString("dd/MM/yyyy");
            startTime = new DateTime(dtpk.Value.Year, dtpk.Value.Month, dtpk.Value.Day, (int)nudH1.Value, (int)nudM1.Value, 0);
        }
        void setTimeKT()
        {
            finishTime = new DateTime(dtpk.Value.Year, dtpk.Value.Month, dtpk.Value.Day, (int)nudH2.Value, (int)nudM2.Value, 0);
            lbNgayKetThuc.Text = finishTime.ToString("dd/MM/yyyy");
        }

        void checkHopLe()
        {
            if((DateTime.Compare(startTime, finishTime) > 0) || (DateTime.Compare(startTime.Date, DateTime.Now.Date) < 0))
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
            ThuLapLai(lapLai);
            xuLyLapLai();

            nudH1.Value = DateTime.Now.Hour;
            nudM1.Value = DateTime.Now.Minute;
            
            checkHopLe();
        }
        public int getColumnByDate(DateTime time)
        {
            int vt;
            if (time.DayOfWeek.ToString() == "Monday")
                vt = 0;
            else if (time.DayOfWeek.ToString() == "Tuesday")
                vt = 1;
            else if (time.DayOfWeek.ToString() == "Wednesday")
                vt = 2;
            else if (time.DayOfWeek.ToString() == "Thursday")
                vt = 3;
            else if (time.DayOfWeek.ToString() == "Friday")
                vt = 4;
            else if (time.DayOfWeek.ToString() == "Saturday")
                vt = 5;
            else vt = 6;

            return vt;
        }
        
        bool clickThayDoi1 = false;
        bool clickThayDoi2 = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!clickThayDoi2)
            {
                if(checkLapLai())
                {
                    setTimeKT();
                }    
                setTimeBD();
                label8.Text = startTime.ToString();
            }
            else
            {
                setTimeKT();
                label11.Text = finishTime.ToString();
            }
            timeOfDtpk.TimeSelection = dtpk.Value;
            checkHopLe();
        }

        private void btnThayDoi1_Click(object sender, EventArgs e)
        {
            dtpk.Focus();
            SendKeys.Send("%{DOWN}");
            clickThayDoi1 = true;
            clickThayDoi2 = false;
            pnlHL.Location = new Point(btnThayDoi1.Location.X, btnThayDoi1.Location.Y + btnThayDoi1.Height);
        }

        private void btnThayDoi2_Click(object sender, EventArgs e)
        {
            if(!checkLapLai())
            {
                dtpk.Focus();
                SendKeys.Send("%{DOWN}");
                clickThayDoi2 = true;
                clickThayDoi1 = false;
                pnlHL.Location = new Point(btnThayDoi2.Location.X, btnThayDoi2.Location.Y + btnThayDoi2.Height);
            }
            else
            {
                clickThayDoi1 = true;
            }
            
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
            setTimeBD();
            setTimeKT();
            if(cbxtHN.Checked == false)
            {
                dtpk.Enabled = true;
                uncheckedAll();
                xuLyLapLai();
            }
        }

        private void btnNgayMai_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(1);
            setTimeBD();
            setTimeKT();
            if (cbxtHN.Checked == false)
            {
                dtpk.Enabled = true;
                uncheckedAll();
                xuLyLapLai();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCV.Text))
            {
                MessageBox.Show("vui long nhap cong viec");
                return;
            }

            //luu cong viec
            
            try
            {
                if (checkLapLai())
                {

                    bool[] lap = getLapLai();
                    int ngayLap;
                    if (lap[1] == true)
                    {
                        ngayLap = 1;
                    }
                    else
                    {
                        ngayLap = 7;
                    }

                    int vtCu = 0;
                    bool firstTime = true;
                    for (int i = 1; i < 9; i++)
                    {
                        if (lap[i] == true)
                        {
                            if (firstTime == true) vtCu = i;
                            startTime = startTime.AddDays(i - vtCu);
                            finishTime = finishTime.AddDays(i - vtCu);
                            int j = 0;
                            for (DateTime date = startTime; date <= startTime.AddMonths(1); date = date.AddDays(ngayLap))
                            {
                                CongViec newCV = new CongViec(txbCV.Text, startTime.AddDays(j), finishTime.AddDays(j), getLapLai(), LoginAccount.TenDN);
                                if(!CongViecDAO.addJob(newCV))
                                {
                                    throw new Exception("Lỗi thêm công việc");
                                }
                                j += ngayLap;
                            }
                            vtCu = i;
                            firstTime = false;
                        }  
                        else
                        {

                        }
                    }
                    MessageBox.Show("Công việc của bạn sẽ được lặp lại.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    CongViec newCV = new CongViec(txbCV.Text, startTime, finishTime, getLapLai(), LoginAccount.TenDN);
                    if (!CongViecDAO.addJob(newCV))
                    {
                        throw new Exception("Lỗi thêm công việc");
                    }
                }

                MessageBox.Show("thanh cong");
                this.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            } 
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

        private void txbCV_TextChanged(object sender, EventArgs e)
        {
            if(txbCV.Text.Length > 48)
            {
                lbGioiHanCV.Visible = true;
                btnLuu.Enabled = false;
            }
            else
            {
                lbGioiHanCV.Visible=false;
                btnLuu.Enabled=true;
            }
            
        }
    }
}
