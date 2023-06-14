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

        private bool isCorrect = false;
        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            if(txbTK.Text.Length == 19)
            {
                lbGioiHanTK.Text = "Không quá 20 kí tự và không chứa kí tự đặc biệt!";
                lbGioiHanTK.ForeColor = Color.White;
                lbGioiHanTK.Visible = true;
            }
            else
            {
                lbGioiHanTK.Visible = false;
            }

            DataTable dt = new DataTable();
            dt.Clear();
            dt = DataProvider.Instance.truyVanCoKetQua("exec GetTTTK @username", new object[] { txbTK.Text });

            if (string.IsNullOrEmpty(txbTK.Text))
            {
                picCheck.Visible = false; 
            }
            else picCheck.Visible = true;

            if (dt.Rows.Count != 0)
            {
                picCheck.Image = Properties.Resources.icons8_multiply_50;
                isCorrect = false;

                lbGioiHanTK.Visible = true;
                lbGioiHanTK.Text = "Tên tài khoản đã tồn tại!";
                lbGioiHanTK.ForeColor = Color.OrangeRed;
            }
            else
            {
                picCheck.Image = Properties.Resources.icons8_tick_501;
                lbGioiHanTK.Visible = false;
                isCorrect = true;
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
   
        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if(isCorrect)
            {
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
                    MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (signUp(userName, passWord, passWord1, displayName, question, answer))
                  { 
                    MessageBox.Show("Đăng kí thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                bool signUp(string tenDN, string MK, string MK1, string tenHT, string cauHoi, string traLoi)
                {
                    return TaiKhoanDAO.Instance.signUp(tenDN, MK, MK1, tenHT, cauHoi, traLoi);
                }
            }  
        }
    }
}
