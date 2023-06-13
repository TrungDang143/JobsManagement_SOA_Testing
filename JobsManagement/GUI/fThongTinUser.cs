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

namespace JobsManagement.GUI
{
    public partial class fThongTinUser : Form
    {
        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }
        public fThongTinUser(TaiKhoan loginAcc)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(BoForm.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            LoginAccount = loginAcc;
        }

        #region title bar

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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private bool isXacNhan= false;
        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if(!isXacNhan)
            {
                lbCanhBao.Visible = true;
                btnXoaTK.Text = string.Empty;
                btnXoaTK.Enabled = false;
                for( int i = 5; i >= 0; i-- )
                {
                    btnXoaTK.Text = string.Format("Xác nhận ({0})", i);
                    Task.Delay(1000).Wait();
                }
                btnXoaTK.Text = "Xác nhận xoá";
                btnXoaTK.Enabled = true;
                isXacNhan = true;
            }
            else
            {
                //sql
                TaiKhoanDAO.Instance.DeleteAcc(loginAccount.TenDN);
                Task.Delay(1000).Wait();
                this.Close();
                isXacNhan = false;
                lbCanhBao.Visible = false;
            }
        }

        private void fThongTinUser_Load(object sender, EventArgs e)
        {
            lbTDN.Text = LoginAccount.TenDN;
            lbTHT.Text = LoginAccount.TenHT;
            lbMK.Text = LoginAccount.Mk;
            lbCHBM.Text = LoginAccount.CauHoi;
            lbTL.Text = LoginAccount.TraLoi;
            if(LoginAccount.DoChamChi == -1)
            {
                lbCC.Text = "Độ chăm chỉ: 0%";
            }
            else
            {
                lbCC.Text = string.Format("Độ chăm chỉ: {0}%", LoginAccount.DoChamChi*100);
            }
        }
    }
}
