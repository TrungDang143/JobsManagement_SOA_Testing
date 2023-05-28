using JobsManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JobsManagement
{
    
    public partial class fLogin : Form
    {
        public static string UserName = "";
        public fLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(DAO.BoForm.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public void reset()
        {
            txbPassword.Text = string.Empty;
            txbUsername.Text = string.Empty;    
            //  
        }


        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignUp f = new fSignUp();
            f.ShowDialog();
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fForgot f = new fForgot();
            f.ShowDialog();
        }
        #region title bar

        private void icoMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icoClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {

                conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True";
                conn.Open();

                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "SP_AuthorizationLogin";
                //cmd.Parameters.AddWithValue("@UserName", txbUsername.Text);
                //cmd.Parameters.AddWithValue("@PassWord", txbPassword.Text);
                //cmd.Connection = conn;

                //UserName = txbUsername.Text;
                //object kq = cmd.ExecuteScalar();
                //int code = Convert.ToInt32(kq);
                int code = 0;
                if (code == 0)
                {
                    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    mainUI m = new mainUI();
                    this.Hide();
                    m.ShowDialog();
                    if (!m.isClose)
                    {
                        reset();
                        this.Show();
                    }
                }
                else if (code == 1)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            /*mainF = new mainUI();

            this.Hide();
            mainF.ShowDialog();
            if(!mainF.isClose) 
            {
                reset();
                this.Show();
            }*/
        }
        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            txbUsername.SelectAll();
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txbPassword.SelectAll();
        }

        private bool isMat1 = false;
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
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }
    }
}
