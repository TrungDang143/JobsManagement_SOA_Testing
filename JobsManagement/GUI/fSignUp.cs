using JobsManagement.DAO;
using JobsManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JobsManagement
{
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(BoForm.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            
            CauHoiBaoMatDAO.loadCHBM(cbb);
        }

        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }
        #region title bar

        private void icoMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        #region High light
        void resetHL()
        {
            HLmatkhau.BackColor = Color.FromArgb(0, 126, 249);
            HLtenHT.BackColor = Color.FromArgb(0, 126, 249);
            HLtenTK.BackColor = Color.FromArgb(0, 126, 249);
            HLtraLoi.BackColor = Color.FromArgb(0, 126, 249);
            HLxacNhanMK.BackColor = Color.FromArgb(0, 126, 249);

        }
        private void txbTK_Click(object sender, EventArgs e)
        {
            resetHL();
            HLtenTK.BackColor = Color.SeaGreen;
        }

        private void txbTen_Click(object sender, EventArgs e)
        {
            resetHL();
            HLtenHT.BackColor = Color.SeaGreen;
        }

        private void txbTraLoi_Click(object sender, EventArgs e)
        {
            resetHL();
            HLtraLoi.BackColor = Color.SeaGreen;
        }

        private void txbXNMK_Click(object sender, EventArgs e)
        {
            resetHL();
            HLxacNhanMK.BackColor = Color.SeaGreen;
        }

        private void txbMK_Click(object sender, EventArgs e)
        {
            resetHL();
            HLmatkhau.BackColor = Color.SeaGreen;
        }

        #endregion

        #region trang tri
        private bool isMat1 = false;
        private bool isMat2 = false;
        private void mat1_Click(object sender, EventArgs e)
        {
            if (isMat1 == false)
            {
                mat1.Image = Properties.Resources.icons8_open_eye_32;
                isMat1 = true;
            }
            else
            {
                mat1.Image = Properties.Resources.icons8_close_eye_32;
                isMat1 = false;
            }
            txbMK.UseSystemPasswordChar = !txbMK.UseSystemPasswordChar;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isMat2 == false)
            {
                pictureBox1.Image = Properties.Resources.icons8_open_eye_32;
                isMat2 = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.icons8_close_eye_32;
                isMat2 = false;
            }
            txbXNMK.UseSystemPasswordChar = !txbXNMK.UseSystemPasswordChar;
        }


        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            if(txbTK.Text.Length == 19)
            {
                lbGioiHanTK.Visible = true;
            }
            else
            {
                lbGioiHanTK.Visible = false;
            }
        }

        private void txbMK_TextChanged(object sender, EventArgs e)
        {
            if (txbMK.Text.Length == 19)
            {
                lbGioiHanMK.Visible = true;
            }
            else
            {
                lbGioiHanMK.Visible = false;
            }
        }

        private void txbXNMK_TextChanged(object sender, EventArgs e)
        {
            if (txbXNMK.Text.Length == 19)
            {
                lbGioiHanXNMK.Visible = true;
            }
            else
            {
                lbGioiHanXNMK.Visible = false;
            }
        }

        private void txbTen_TextChanged(object sender, EventArgs e)
        {
            if (txbTen.Text.Length == 29)
            {
                lbGioiHanTHT.Visible = true;
            }
            else
            {
                lbGioiHanTHT.Visible = false;
            }
        }

        private void txbTraLoi_TextChanged(object sender, EventArgs e)
        {
            if (txbTraLoi.Text.Length == 29)
            {
                lbGioiHanTL.Visible = true;
            }
            else
            {
                lbGioiHanTL.Visible = false;
            }
        }
        #endregion

        /*
        public bool KiemTraThongTin()
        {

            if (txbTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTK.Focus();
                return false;
            }
            else if (txbTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTen.Focus();
                return false;
            }
            else if (txbMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMK.Focus();
                return false;
            }
            else if(cbb.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi bảo mật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb.Focus();
                return false;
            }    
            else if (txbTraLoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập câu trả lời", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTraLoi.Focus();
                return false;
            }
            return true;
        }
        */
        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            /*
            if (!KiemTraThongTin()) return;
            
            if (TaiKhoanDAO.Instance.DKTK(txbTK.Text, txbMK.Text, txbTen.Text, cbb.SelectedItem.ToString(), txbTraLoi.Text))
            {
                MessageBox.Show("dk thanh cong");
                this.Close();
            }
            else
            {
                MessageBox.Show("dk k thanh cong, xem lai thong tin");

            }
            */
            string userName = txbTK.Text;
            string passWord = txbMK.Text;
            string passWord1 = txbXNMK.Text;
            string displayName = txbTen.Text;
            string question = "";
            string answer = txbTraLoi.Text;
            if(cbb.SelectedItem != null)
            {
                question = cbb.SelectedItem.ToString();
            }
            else
            {
                //
            }
            if (signUp(userName, passWord, passWord1, displayName, question, answer))
              { 
                MessageBox.Show("Đăng kí thành công");

                this.Close();

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin");
            }

            bool signUp(string tenDN, string MK, string MK1, string tenHT, string cauHoi, string traLoi)
            {
                return TaiKhoanDAO.Instance.signUp(tenDN, MK, MK1, tenHT, cauHoi, traLoi);
            }
            //if (KiemTraThongTin())
            //{
            //    try
            //    {
            //        SqlConnection conn = new SqlConnection();
            //        conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True";
            //        SqlCommand cmd = new SqlCommand();

            //        cmd.CommandText = "SP_ThemTaiKhoan";
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = txbTK.Text;
            //        cmd.Parameters.Add("@TenHienThi", SqlDbType.NVarChar).Value = txbTen.Text;
            //        cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = txbMK.Text;
            //        cmd.Parameters.Add("@CauHoiBaoMat", SqlDbType.NVarChar).Value = txbTraLoi.Text;

            //        cmd.Connection = conn;
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();
            //        MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }
    }
}
