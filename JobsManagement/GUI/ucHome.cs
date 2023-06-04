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
        private int rowSelected;

        public ucHome(TaiKhoan loginAcc)
        {
            InitializeComponent();
            this.LoginAccount = loginAcc;
            dtpk.Value = timeOfDtpk.TimeSelection;
            loadCV(dtpk.Value, dtpk.Value);
        }
        
        private void loadCV( DateTime bd, DateTime kt)
        {
            string query = "exec GetCongViecByDateRange @tgbd , @tgkt , @username";
            duLieu = DataProvider.Instance.truyVanCoKetQua(query, new object[] { bd, kt, LoginAccount.TenDN });
            dgv.DataSource = duLieu;
            
            if(dgv.Rows.Count > 0 )
            {
                dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Width = 492;
                dgv.Columns[2].Width = 175;
                dgv.Columns[3].Width = 175;
                dgv.Columns[4].Width = 233;
                dgv.Sort(dgv.Columns[2], ListSortDirection.Descending);

                lbNull.Visible = false;
            }
            else
            {
                lbNull.Visible = true;
            }

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
            btnThang.BackColor = Color.FromArgb(63, 68, 97);
            btnTuan.BackColor = Color.FromArgb(63, 68, 97);

        }
        private void btnTuan_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnTuan.BackColor = Color.FromArgb(37, 42, 64);

            DateTime today = DateTime.Today;
            
            int k = today.DayOfWeek - DayOfWeek.Monday;            
            DateTime dauTuan = today.AddDays(-k);
            DateTime cuoiTuan = today.AddDays(6 - k);

            loadCV(dauTuan, cuoiTuan);
            
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnThang.BackColor = Color.FromArgb(37, 42, 64);

            DateTime dauThang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime cuoiThang = dauThang.AddMonths(1).AddDays(-1);
            
            loadCV(dauThang, cuoiThang);
        }
        private void btnDaHT_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnDDR.BackColor = Color.FromArgb(37, 42, 64);

            DataTable HT = duLieu.Copy();
            foreach(DataRow dr in HT.Rows)
            {
                if (dr[HT.Columns.Count - 1].ToString() != "Đang diễn ra")
                {
                    dr.Delete();
                }
            }
            HT.AcceptChanges();
            dgv.DataSource = HT;
        }

        private void btnSDR_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnSDR.BackColor = Color.FromArgb(37, 42, 64);

            DataTable SDR = duLieu.Copy();
            foreach (DataRow dr in SDR.Rows)
            {
                if (dr[SDR.Columns.Count - 1].ToString() != "Sắp diễn ra")
                {
                    dr.Delete();
                }
            }
            SDR.AcceptChanges();
            dgv.DataSource= SDR;
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            loadCV(dtpk.Value, dtpk.Value);
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
            loadCV(dtpk.Value, dtpk.Value);
            resetFilter();
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
            loadCV(dtpk.Value, dtpk.Value);

            resetFilter();
            resetSelect();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            resetHL();
            btnSua.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnSua.Left;

            Panel mainPanel = this.Parent as Panel;
            mainUI mainForm = mainPanel.Parent as mainUI;

            mainForm.showBlur();

            DataGridViewRow dgvRow = dgv.Rows[rowSelected];
            int id = (int)dgvRow.Cells[0].Value;

            CongViec cv = DAO.CongViecDAO.GetCongViecByID_Username(id, LoginAccount.TenDN);

            changeJob f = new changeJob(cv);
            f.ShowDialog();

            mainForm.closeBlur();
            loadCV(dtpk.Value, dtpk.Value);

            resetSelect();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            resetHL();
            btnXoa.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnXoa.Left;
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            
            //MessageBox.Show(dataRow.Cells["noiDungCV"].Value.ToString());
        }
        #endregion

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv.Columns[e.ColumnIndex].Name == dgv.Columns[2].Name || dgv.Columns[e.ColumnIndex].Name == dgv.Columns[3].Name)
            {
                if (e.Value != null)
                {
                    DateTime datetime = (DateTime)e.Value;
                    e.Value = datetime.ToString("HH:mm - dd/MM");
                    e.FormattingApplied = true;
                }
            }
        }

    }
}
