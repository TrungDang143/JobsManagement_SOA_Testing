using JobsManagement.DAO;
using JobsManagement.DTO;
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

namespace JobsManagement
{
    public partial class ucHome : UserControl
    {
        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount { get => loginAccount; private set => loginAccount = value; }

        public ucHome(TaiKhoan loginAcc)
        {
            InitializeComponent();
            this.LoginAccount = loginAcc;
            loadCV();
            dtpk.Value = timeOfDtpk.TimeSelection;
        }

        private void loadCV()
        {

            string query = "exec hienThiCV @userName ";
            string userName = LoginAccount.TenDN;
            //load công việc theo loginAcc
            dgv.DataSource = DataProvider.Instance.truyVanCoKetQua(query, new object[] { userName });

            dtpk.Value = timeOfDtpk.TimeSelection;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            //dgv.Columns["id"].Width = 500;
            //dgv.Sort(dgv.Columns["maNV"], ListSortDirection.Descending);
        }

        #region highlight and function

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetHL();
            btnAdd.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnAdd.Left;
            
            Panel mainPanel = this.Parent as Panel;
            mainUI mainForm = mainPanel.Parent as mainUI;

            //mainForm.showBlurForm();

            fAddJob f = new fAddJob(dtpk.Value, -1,loginAccount);
            f.ShowDialog();
            loadCV();
            //mainForm.closeBlurForm();
            resetSelect();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            resetHL();
            btnSua.BackColor = Color.FromArgb(46, 51, 73);
            plHL.Left = btnSua.Left;
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
        #endregion

        #region hieu ung button
        void resetFilter()
        {
            btnDaHT.BackColor = Color.FromArgb(63, 68, 97);
            btnSDR.BackColor = Color.FromArgb(63, 68, 97);
            btnThang.BackColor = Color.FromArgb(63, 68, 97);
            btnTuan.BackColor = Color.FromArgb(63, 68, 97);

        }
        private void btnTuan_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnTuan.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnThang.BackColor = Color.FromArgb(37, 42, 64);
        }
        private void btnDaHT_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnDaHT.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void btnSDR_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnSDR.BackColor = Color.FromArgb(37, 42, 64);
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

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            timeOfDtpk.TimeSelection = dtpk.Value;
        }
        #endregion
    }
}
