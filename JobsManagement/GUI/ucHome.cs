using JobsManagement.DAO;
using JobsManagement.DTO;
using JobsManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Effects;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace JobsManagement
{
    public partial class ucHome : UserControl
    {
        private TaiKhoan loginAccount;
        public TaiKhoan LoginAccount { get => loginAccount; private set => loginAccount = value; }

        private DataTable duLieu = new DataTable();
        private int idSelected = default(int);
        private DateTime tu;
        private DateTime den;
        private int filter = 0;

        public ucHome(TaiKhoan loginAcc)
        {
            InitializeComponent();
            this.LoginAccount = loginAcc;
            dtpk.Value = timeOfDtpk.TimeSelection;
            btnAll.BackColor = Color.FromArgb(37, 42, 64);
            loadCV(tu, den, filter);   
        }
        
        private void loadCV(DateTime bd, DateTime kt, int fil)
        {
            CongViecDAO.setTrangThai(LoginAccount.TenDN);
            string query = "exec GetCongViecByDateRange @tgbd , @tgkt , @username";
            duLieu = DataProvider.Instance.truyVanCoKetQua(query, new object[] { bd, kt, LoginAccount.TenDN });
            dgv.DataSource = duLieu;

            //dtpk.Format = DateTimePickerFormat.Custom;
            //dtpk.CustomFormat = "dddd - dd , MM , yyyy";

            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dgv.Columns[0].Visible = false;
            dgv.Columns[1].Width = 452;
            dgv.Columns[2].Width = 200;
            dgv.Columns[3].Width = 200;
            dgv.Columns[4].Width = 233;
            dgv.Sort(dgv.Columns[2], ListSortDirection.Ascending);

            switch (fil)
            {
                case 2:
                    {
                        SDR();
                        break;
                    }
                case 1:
                    {
                        DDR(); 
                        break;
                    }
                default: break;
            }
            if(dgv.Rows.Count == 0)
            {
                lbNull.Visible = true;
                lbNull.Text = $"Không có công việc!\n{dtpk.Value.ToString("dd - MM - yyyy")}";
                lbNull.Location = new Point(dgv.Width / 2 - lbNull.Width / 2, dgv.Height / 2 - lbNull.Height / 2);

            }
            else { lbNull.Visible = false; }
        }

        #region highlight

        void resetHL()//37, 42, 64
        {
            btnAdd.BackColor = Color.FromArgb(37, 42, 64);
            btnSua.BackColor = Color.FromArgb(37, 42, 64);
            btnXoa.BackColor = Color.FromArgb(37, 42, 64);
            btnHT.BackColor = Color.FromArgb(37, 42, 64);
            btnRollBack.BackColor = Color.FromArgb(37, 42, 64);
            plHL.Visible = true;
        }

        void resetSelect()
        {
            resetHL();
            plHL.Visible= false;
        }

        #endregion

        #region button filter
        void resetFilter()
        {
            btnDDR.BackColor = Color.FromArgb(63, 68, 97);
            btnSDR.BackColor = Color.FromArgb(63, 68, 97);
            btnAll.BackColor = Color.FromArgb(63, 68, 97);
        }
        void resetTimeRange()
        {
            btnThang.BackColor = Color.FromArgb(63, 68, 97);
            btnTuan.BackColor = Color.FromArgb(63, 68, 97);
        }
        void DDR()
        {
            filter = 1;
            DataTable HT = duLieu.Copy();
            foreach (DataRow dr in HT.Rows)
            {
                if (dr[HT.Columns.Count - 1].ToString() != "Đang diễn ra")
                {
                    dr.Delete();
                }
            }
            HT.AcceptChanges();
            dgv.DataSource = HT;
        }
        void SDR()
        {
            filter = 2;
            DataTable SDR = duLieu.Copy();
            foreach (DataRow dr in SDR.Rows)
            {
                if (dr[SDR.Columns.Count - 1].ToString() != "Sắp diễn ra")
                {
                    dr.Delete();
                }
            }
            SDR.AcceptChanges();
            dgv.DataSource = SDR;
        }
        private void btnTuan_Click(object sender, EventArgs e)
        {
            resetTimeRange();
            btnTuan.BackColor = Color.FromArgb(37, 42, 64);

            DateTime today = dtpk.Value;     
            int k = today.DayOfWeek - DayOfWeek.Monday;            
            DateTime dauTuan = today.AddDays(-k);
            DateTime cuoiTuan = today.AddDays(6 - k);

            tu = dauTuan;
            den = cuoiTuan;
            loadCV(tu, den, filter);        
        }
        private void btnThang_Click(object sender, EventArgs e)
        {
            resetTimeRange();
            btnThang.BackColor = Color.FromArgb(37, 42, 64);

            DateTime dauThang = new DateTime(dtpk.Value.Year, dtpk.Value.Month, 1);
            DateTime cuoiThang = dauThang.AddMonths(1).AddDays(-1);
            tu = dauThang;
            den = cuoiThang;
            loadCV(tu, den, filter);
        }
        private void btnDaHT_Click(object sender, EventArgs e)
        {
            DDR();
            resetFilter();
            btnDDR.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void btnSDR_Click(object sender, EventArgs e)
        {
            SDR();
            resetFilter();
            btnSDR.BackColor = Color.FromArgb(37, 42, 64);
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            filter = 0;
            loadCV(tu, den, filter);
            resetFilter();
            btnAll.BackColor = Color.FromArgb(37, 42, 64);
        }
        
        #endregion

        #region datetimepicker
        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }

        private void btnNgayMai_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(1);
        }
        private void dtpk_ValueChanged_1(object sender, EventArgs e)
        {
            timeOfDtpk.TimeSelection = dtpk.Value;
            tu = dtpk.Value;
            den = dtpk.Value;
            loadCV(tu, den, filter);
            resetTimeRange();
        }

        #endregion

        #region taskbar
        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetHL();
            btnAdd.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnAdd.Left;
            
            Panel mainPanel = this.Parent as Panel;
            mainUI mainForm = mainPanel.Parent as mainUI;

            mainForm.showBlur();
            
            fAddJob f = new fAddJob(dtpk.Value, -1,loginAccount);
            f.ShowDialog();
            
            mainForm.closeBlur();
            loadCV(tu, den, filter);

            resetSelect();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            resetHL();
            btnSua.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnSua.Left;
            try
            {
                Panel mainPanel = this.Parent as Panel;
                mainUI mainForm = mainPanel.Parent as mainUI;

                if(idSelected == 0 )
                {
                    throw new Exception("Chọn công việc cần sửa");
                } 
                    
                CongViec cv = DAO.CongViecDAO.GetCongViecByID_Username(idSelected, LoginAccount.TenDN);
                mainForm.showBlur();

                changeJob f = new changeJob(cv);
                f.ShowDialog();

                mainForm.closeBlur();
                loadCV(tu, den, filter);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            resetSelect();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            resetHL();
            btnXoa.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnXoa.Left;

            string tb = "Bạn muốn xoá công việc này?";
            try
            {
                if (idSelected == 0)
                {
                    throw new Exception("Chọn công việc cần xoá");
                }

                int lap = CongViecDAO.getIdLap(idSelected, LoginAccount.TenDN);

                if (lap != 0)
                {
                    tb = "Công việc của bạn có lặp lại, bạn sẽ xoá tất cả công việc tương tự. \nXác nhận?";
                }
                var result = MessageBox.Show(tb, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CongViecDAO.XoaCongViec(idSelected, lap, LoginAccount.TenDN);
                    loadCV(tu, den, filter);
                }
                resetSelect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRollBack_Click(object sender, EventArgs e)
        {
            resetHL();
            btnRollBack.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnRollBack.Left;
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            resetHL();
            btnHT.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnHT.Left;

        }
        #endregion

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv.Columns[e.ColumnIndex].Name == dgv.Columns[2].Name || dgv.Columns[e.ColumnIndex].Name == dgv.Columns[3].Name)
            {
                if (e.Value != null)
                {
                    DateTime datetime = (DateTime)e.Value;
                    e.Value = datetime.ToString("HH:mm - ddd - dd/MM");
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 0)
            {
                DataGridViewRow dgvRow = dgv.Rows[e.RowIndex];
                idSelected = (int)dgvRow.Cells[0].Value;
            }
        }

    }
}
