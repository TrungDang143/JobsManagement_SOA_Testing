using JobsManagement.DAO;
using JobsManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace JobsManagement.GUI
{
    public partial class ucAD : UserControl
    {
        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }


        public ucAD()
        {
            InitializeComponent();
            adminView();
            string query = "select count(*) from TaiKhoan where isAD = 0";
            label1.Text = "Có " + DataProvider.Instance.truyVanCoMotKetQua(query).ToString() + " tài khoản người dùng";
        }

        private void btnAD_Click(object sender, EventArgs e)
        {

            fThongTinUser fThongTinUser = new fThongTinUser(loginAccount);

            fThongTinUser.ShowDialog();
            adminView();
            string query = "select count(*) from TaiKhoan where isAD = 0";
            label1.Text = "Có " + DataProvider.Instance.truyVanCoMotKetQua(query).ToString() + " tài khoản người dùng";
        }

        private void adminView()
        {
            string sql = "select tenDangNhap,tenHienThi from TaiKhoan where isAD = 0"; 
            dgvAdmin.DataSource = DataProvider.Instance.truyVanCoKetQua(sql); 
        }

  

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow dataRow = dgvAdmin.Rows[row];
            MessageBox.Show(dataRow.Cells[0].Value.ToString());
            loginAccount = TaiKhoanDAO.Instance.CurrentAcc(dataRow.Cells[0].Value.ToString());
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
