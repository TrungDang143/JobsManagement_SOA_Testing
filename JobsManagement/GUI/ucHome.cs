using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsManagement
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            connectDB conn = new connectDB();
            conn.openConn();
            dgv.DataSource = conn.truyVan("select * from qLyNV");
            dgv.Columns["id"].Width = 500;
            dgv.Sort(dgv.Columns["maNV"], ListSortDirection.Descending);
            conn.closeConn();
            btnNgay.BackColor = Color.FromArgb(37, 42, 64);
        }

        #region high light

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
            
            fAddJob f = new fAddJob(dtpk.Value, -1);
            f.ShowDialog();

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

        #region filter
        void resetFilter()
        {
            btnNgay.BackColor = Color.FromArgb(63, 68, 97);
            btnThang.BackColor = Color.FromArgb(63, 68, 97);
            btnTuan.BackColor = Color.FromArgb(63, 68, 97);

        }
        private void btnNgay_Click(object sender, EventArgs e)
        {
            resetFilter();
            btnNgay.BackColor = Color.FromArgb(37, 42, 64);
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
        #endregion

    }
}
