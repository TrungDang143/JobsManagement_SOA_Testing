using JobsManagement.DAO;
using JobsManagement.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace JobsManagement
{
    public partial class ucThongKe : UserControl
    {
        private TaiKhoan loginAccount;
        private DateTime tu;
        private DateTime den;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }

        public ucThongKe(TaiKhoan loginAcc)
        {
            InitializeComponent();
            this.LoginAccount = loginAcc;

            dtpk.Value = timeOfDtpk.TimeSelection;
            dtpk.Format = DateTimePickerFormat.Custom;
            dtpk.CustomFormat = "dddd, dd MMMM yyyy";

            tu = dtpk.Value;
            den = dtpk.Value;
        }
        private void ucThongKe_Load(object sender, EventArgs e)
        {
            loadCV(tu, den, "ngày" + dtpk.Value.ToString(" dd/MM/yyyy"));
        }

        private void loadCV(DateTime bd, DateTime kt, string time)
        {
            int cv = DAO.CongViecDAO.tongCV(LoginAccount.TenDN);
            if (cv != 0)
            {
                lbTongCV.Text = $"Có {cv} công việc trong {time}";
                

                dgvchuaHT.DataSource = CongViecDAO.GetCVbyDateRange_Status(bd, kt, loginAccount.TenDN, "Chưa hoàn thành");
                dgvdaHT.DataSource = CongViecDAO.GetCVbyDateRange_Status(bd, kt, loginAccount.TenDN, "Đã hoàn thành");

                int cvcht = dgvchuaHT.RowCount;
                int cvdht = dgvdaHT.RowCount;

                lbCVchuaHoanThanh.Text = $"Có {cvcht} công việc chưa hoàn thành";
                lbCVdaHoanThanh.Text = $"Có {cvdht} công việc đã hoàn thành";
            }
            else
            {
                lbTongCV.Text = $"Không có công việc trong {time}";

            }

            lbTongCV.Location = new Point(panel3.Width / 2 - lbTongCV.Width / 2, panel3.Height / 2 - lbTongCV.Height / 2);
            lbCVchuaHoanThanh.Location = new Point(panel4.Width / 2 - lbCVchuaHoanThanh.Width / 2, panel4.Height / 2 - lbCVchuaHoanThanh.Height / 2);
            lbCVdaHoanThanh.Location = new Point(panel5.Width / 2 - lbCVdaHoanThanh.Width / 2, panel5.Height / 2 - lbCVdaHoanThanh.Height / 2);
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            resetSelection();
            btnNgay.BackColor = Color.FromArgb(46, 51, 73);
            tu = DateTime.Now;
            den = DateTime.Now;
            loadCV(tu, den, "hôm nay" + dtpk.Value.ToString(" dd/MM/yyyy"));
        }

        private void btnTuan_Click(object sender, EventArgs e)
        {
            resetSelection();
            btnTuan.BackColor = Color.FromArgb(46, 51, 73);

            DateTime today = dtpk.Value;
            int k = today.DayOfWeek - DayOfWeek.Monday;
            DateTime dauTuan = today.AddDays(-k);
            DateTime cuoiTuan = today.AddDays(6 - k);

            tu = dauTuan;
            den = cuoiTuan;
            loadCV(tu, den, "tuần");

        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            resetSelection();
            btnThang.BackColor = Color.FromArgb(46, 51, 73);

            DateTime dauThang = new DateTime(dtpk.Value.Year, dtpk.Value.Month, 1);
            DateTime cuoiThang = dauThang.AddMonths(1).AddDays(-1);

            tu = dauThang;
            den = cuoiThang;
            loadCV(tu, den, "tháng"+dtpk.Value.ToString(" MM/yyyy"));

        }
        private void btnNam_Click(object sender, EventArgs e)
        {
            resetSelection();
            btnNam.BackColor = Color.FromArgb(46, 51, 73);

            int year = DateTime.Now.Year;
            DateTime dauNam = new DateTime(year, 1, 1);
            DateTime cuoiNam = new DateTime(year, 12, 31);

            tu = dauNam;
            den = cuoiNam;
            loadCV(tu, den, "năm " + year.ToString());
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            timeOfDtpk.TimeSelection = dtpk.Value;
            tu = dtpk.Value;
            den = dtpk.Value;
            loadCV(tu, den, "ngày" + dtpk.Value.ToString(" dd/MM/yyyy"));
            resetSelection();
        }

        private void resetSelection()
        {
            btnNgay.BackColor = Color.FromArgb(63, 68, 97);
            btnTuan.BackColor = Color.FromArgb(63, 68, 97);
            btnThang.BackColor = Color.FromArgb(63, 68, 97);
            btnNam.BackColor = Color.FromArgb(63, 68, 97);
        }
    }
}
