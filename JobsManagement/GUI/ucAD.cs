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
        public ucAD()
        {
            InitializeComponent();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucAD_Load(object sender, EventArgs e)
        {
            adminView();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            fThongTinUser fThongTinUser = new fThongTinUser();
            fThongTinUser.ShowDialog();
        }

        SqlConnection cnn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True");
        private void adminView()
        {
            cnn.Open();
            string sql = "select tenDangNhap,tenHienThi from TaiKhoan where isAD = 0";  
            SqlCommand com = new SqlCommand(sql, cnn); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);  
            cnn.Close();  
            dgvAdmin.DataSource = dt; 
        }

    }
}
