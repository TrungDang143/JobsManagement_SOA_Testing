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
        private DataTable duLieu = new DataTable();
        private DateTime tu;
        private DateTime den;
        private int filter = 0;
        private int idSelected = default(int);

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }

        public ucThongKe(TaiKhoan loginAcc)
        {
            InitializeComponent();
            dtpk.Value = timeOfDtpk.TimeSelection;
<<<<<<< HEAD
            this.LoginAccount = loginAcc;
            string userName = loginAcc.TenDN;
            //chuaHTView(loginAcc);
            //daHTView(loginAcc);
            //string countChuaHT = "exec countChuaHT @userName";
            //lbCVchuaHoanThanh.Text = "Có " + DataProvider.Instance.truyVanCoMotKetQua(countChuaHT, new object[] { userName }).ToString() + " công việc chưa hoàn thành";
            //string countDaHT = "exec countDaHT @userName";
            //lbCVdaHoanThanh.Text = "Có " + DataProvider.Instance.truyVanCoMotKetQua(countDaHT, new object[] { userName }).ToString() + " công việc đã hoàn thành";
            //int chuaHT = int.Parse(DataProvider.Instance.truyVanCoMotKetQua(countChuaHT, new object[] { userName }).ToString());
            //int daHT   = int.Parse(DataProvider.Instance.truyVanCoMotKetQua(countDaHT, new object[] { userName }).ToString());
            //int tatCa = chuaHT + daHT;
            //lbTatCa.Text = "Có " + tatCa + " công việc";
=======
            dtpk.Format = DateTimePickerFormat.Custom;
            dtpk.CustomFormat = "dddd, dd MMMM yyyy";
            this.LoginAccount = loginAcc;            
        }
        private void ucThongKe_Load(object sender, EventArgs e)
        {
            string userName = LoginAccount.TenDN;
            chuaHTView(LoginAccount);
            daHTView(LoginAccount);
            string countChuaHT = "exec countChuaHT @userName";
            lbCVchuaHoanThanh.Text = "Có " + DataProvider.Instance.truyVanCoMotKetQua(countChuaHT, new object[] { userName }).ToString() + " công việc chưa hoàn thành";
            string countDaHT = "exec countDaHT @userName";
            lbCVdaHoanThanh.Text = "Có " + DataProvider.Instance.truyVanCoMotKetQua(countDaHT, new object[] { userName }).ToString() + " công việc đã hoàn thành";
            int chuaHT = int.Parse(DataProvider.Instance.truyVanCoMotKetQua(countChuaHT, new object[] { userName }).ToString());
            int daHT   = int.Parse(DataProvider.Instance.truyVanCoMotKetQua(countDaHT, new object[] { userName }).ToString());
            int tatCa = chuaHT + daHT;
            lbTatCa.Text = "Có " + tatCa + " công việc trong hôm nay";
>>>>>>> e0843331171488d70e2e02c0b776053ff6048fbb
        }
        private void chuaHTView(TaiKhoan loginAcc)
        {
                string userName = loginAcc.TenDN;
                string sql = "exec chuaHT @userName";
                dgvchuaHT.DataSource = DataProvider.Instance.truyVanCoKetQua(sql,new object[] {userName});
        }

        private void daHTView(TaiKhoan loginAcc)
        {
                string userName = loginAcc.TenDN;
                string sql = "exec daHT @userName";
                dgvHT.DataSource = DataProvider.Instance.truyVanCoKetQua(sql, new object[] { userName});
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            DateTime bayGio = DateTime.Today.Date;
            DateTime ketThuc = DateTime.Today.Date;
            string query = "exec GetNoiDungChuaHTByDateRange @startDate , @endDate , @userName ";
            dgvchuaHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query, new object[] { bayGio, ketThuc, LoginAccount.TenDN });
            string query1 = "exec GetNoiDungDaHTByDateRange @startDate , @endDate , @userName ";
            dgvHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query1, new object[] { bayGio, ketThuc, LoginAccount.TenDN });
            int countChuaHT = dgvchuaHT.RowCount - 1;
            int countHT = dgvHT.RowCount - 1;
            int countTatCa = countChuaHT + countHT;
            if (countChuaHT == 0)
            {
                lbCVchuaHoanThanh.Text = "Không có công việc nào chưa hoàn thành";
            }
            else
            {
                lbCVchuaHoanThanh.Text = "Có " + countChuaHT.ToString() + " công việc chưa hoàn thành";
            }
            if (countHT == 0)
            {
                lbCVdaHoanThanh.Text = "Không có công việc nào cần hoàn thành";
            }
            else
            {
                lbCVdaHoanThanh.Text = "Có " + countHT.ToString() + " công việc đã hoàn thành";
            }
            lbTatCa.Text = "Có " + countTatCa.ToString() + " công việc trong ngày hôm nay";
        }

        private void btnTuan_Click(object sender, EventArgs e)
        {
            DateTime today = dtpk.Value;
            int k = today.DayOfWeek - DayOfWeek.Monday;
            DateTime dauTuan = today.AddDays(-k);
            DateTime cuoiTuan = today.AddDays(6 - k);
            string query = "exec GetNoiDungChuaHTByDateRange @startDate , @endDate , @userName ";
            dgvchuaHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query, new object[] { dauTuan,cuoiTuan, LoginAccount.TenDN });
            string query1 = "exec GetNoiDungDaHTByDateRange @startDate , @endDate , @userName ";
            dgvHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query1, new object[] { dauTuan, cuoiTuan, LoginAccount.TenDN });
            int countChuaHT = dgvchuaHT.RowCount - 1;
            int countHT = dgvHT.RowCount - 1;
            int countTatCa = countChuaHT + countHT;
<<<<<<< HEAD
            if (countChuaHT == 0)
            {
                lbCVchuaHoanThanh.Text = "Không có công việc nào chưa hoàn thành";
            }
            else
            {
                lbCVchuaHoanThanh.Text = "Có " + countChuaHT.ToString() + " công việc chưa hoàn thành";
            }
            if (countHT == 0)
            {
                lbCVdaHoanThanh.Text = "Không có công việc nào cần hoàn thành";
            }
            else
            {
                lbCVdaHoanThanh.Text = "Có " + countHT.ToString() + " công việc đã hoàn thành";
            }
            lbTatCa.Text = "Có " + countTatCa.ToString() + " công việc trong tuần";
=======
            dgvchuaHT.DataSource = DataProvider.Instance.truyVanCoKetQua("exec GetNoiDungByDateRange @startDate , @endDate , @userName ", new object[] { dauTuan, cuoiTuan, loginAccount.TenDN });
            
            lbCVchuaHoanThanh.Text = "Có " + countChuaHT.ToString() + " công việc chưa hoàn thành";
            lbCVdaHoanThanh.Text = "Có " + countHT.ToString() + " công việc đã hoàn thành";
            lbTatCa.Text = "Có " + countTatCa.ToString() + " công việc trong tuần này";
>>>>>>> e0843331171488d70e2e02c0b776053ff6048fbb

        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            DateTime dauThang = new DateTime(dtpk.Value.Year, dtpk.Value.Month, 1);
            DateTime cuoiThang = dauThang.AddMonths(1).AddDays(-1);
<<<<<<< HEAD
            string query = "exec GetNoiDungChuaHTByDateRange @startDate , @endDate , @userName ";
            dgvchuaHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query, new object[] { dauThang,cuoiThang, LoginAccount.TenDN });
            string query1 = "exec GetNoiDungDaHTByDateRange @startDate , @endDate , @userName ";
            dgvHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query1, new object[] { dauThang,cuoiThang, LoginAccount.TenDN });
            int countChuaHT = dgvchuaHT.RowCount - 1;
            int countHT = dgvHT.RowCount - 1;
            int countTatCa = countChuaHT + countHT;
            if (countChuaHT == 0)
            {
                lbCVchuaHoanThanh.Text = "Không có công việc nào chưa hoàn thành";
            }
            else
            {
                lbCVchuaHoanThanh.Text = "Có " + countChuaHT.ToString() + " công việc chưa hoàn thành";
            }
            if (countHT == 0)
            {
                lbCVdaHoanThanh.Text = "Không có công việc nào cần hoàn thành";
            }
            else
            {
                lbCVdaHoanThanh.Text = "Có " + countHT.ToString() + " công việc đã hoàn thành";
            }
            lbTatCa.Text = "Có " + countTatCa.ToString() + " công việc trong tháng";
=======
            dgvchuaHT.DataSource = DataProvider.Instance.truyVanCoKetQua("exec GetNoiDungByDateRange @startDate , @endDate , @userName ", new object[] { dauThang, cuoiThang, loginAccount.TenDN });
            int countChuaHT = dgvchuaHT.RowCount - 1;
            int countHT = dgvHT.RowCount - 1;
            int countTatCa = countChuaHT + countHT;
            
            
            lbCVchuaHoanThanh.Text = "Có " + countChuaHT.ToString() + " công việc chưa hoàn thành";
            lbCVdaHoanThanh.Text = "Có " + countHT.ToString() + " công việc đã hoàn thành";
            lbTatCa.Text = "Có " + countTatCa.ToString() + " công việc trong tháng này";
>>>>>>> e0843331171488d70e2e02c0b776053ff6048fbb

        }


        private void btnNam_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            DateTime dauNam = new DateTime(year, 1, 1);
            DateTime cuoiNam = new DateTime(year, 12, 31);
            string query = "exec GetNoiDungChuaHTByDateRange @startDate , @endDate , @userName ";
            dgvchuaHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query, new object[] { dauNam,cuoiNam, LoginAccount.TenDN });
            string query1 = "exec GetNoiDungDaHTByDateRange @startDate , @endDate , @userName ";
            dgvHT.DataSource = DataProvider.Instance.truyVanCoKetQua(query1, new object[] { dauNam, cuoiNam, LoginAccount.TenDN });
            int countChuaHT = dgvchuaHT.RowCount - 1;
            int countHT = dgvHT.RowCount - 1;
            int countTatCa = countChuaHT + countHT;
            if (countChuaHT == 0)
            {
                lbCVchuaHoanThanh.Text = "Không có công việc nào chưa hoàn thành";
            }
            else
            {
                lbCVchuaHoanThanh.Text = "Có " + countChuaHT.ToString() + " công việc chưa hoàn thành";
            }
            if (countHT == 0)
            {
                lbCVdaHoanThanh.Text = "Không có công việc nào cần hoàn thành";
            }
            else
            {
                lbCVdaHoanThanh.Text = "Có " + countHT.ToString() + " công việc đã hoàn thành";
            }
            lbTatCa.Text = "Có " + countTatCa.ToString() + " công việc trong năm nay";
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            timeOfDtpk.TimeSelection = dtpk.Value;
            tu = dtpk.Value;
            den = dtpk.Value;
        }
    }
}
