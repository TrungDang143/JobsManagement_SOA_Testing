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

namespace JobsManagement
{
    public partial class fForgot : Form
    {
        private TaiKhoan loginAccount;
        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }

        public fForgot()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(BoForm.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
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

        #region mau me
        void resetHL()
        {
            HLtenTK.BackColor = Color.FromArgb(0, 126, 249);
            HLchbm.BackColor = Color.FromArgb(0, 126, 249);        
        }

        private void txbTenTK_Click(object sender, EventArgs e)
        {
            resetHL();
            HLtenTK.BackColor = Color.SeaGreen;
        }

        private void tcbCHBM_Click(object sender, EventArgs e)
        {
            resetHL();
            HLchbm.BackColor = Color.SeaGreen;
        }
        #endregion

        #region xu ly input
        bool isCorrect = false;
        private void btnXN_Click(object sender, EventArgs e)
        {
            bool isEqual = txbCHBM.Text == LoginAccount.TraLoi.ToString() ? true : false;
            if(string.IsNullOrEmpty(txbCHBM.Text) || isEqual == false || isCorrect == false)
            {
                lbCanhBao.Visible = true;
            }
            else
            {
                lbCanhBao.Visible = false;
                lbMK.Text = LoginAccount.Mk.ToString();
                lbMK.Visible = true;
                iconCopy.Visible = true;
                iconCopy.Location = new Point(lbMK.Width + lbMK.Location.X + 5,lbMK.Location.Y);
            }
        }

        private void txbTenTK_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = DataProvider.Instance.truyVanCoKetQua("exec GetTTTK @username", new object[] { txbTenTK.Text });

            lbCanhBao.Visible = false;
            picCheck.Visible = true;
            if (dt.Rows.Count == 0)
            {
                picCheck.Image = Properties.Resources.icons8_multiply_50;
                isCorrect = false;
            }
            else
            {
                TaiKhoan llmk = new TaiKhoan(dt.Rows[0]);
                LoginAccount = llmk;
                picCheck.Image = Properties.Resources.icons8_tick_501;
                lbCHBM.Text = LoginAccount.CauHoi.ToString();
                isCorrect = true;
            }
        }
        #endregion

        private void iconCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbMK.Text);
            lbCopied.Visible = true;
        }

        private void txbCHBM_TextChanged(object sender, EventArgs e)
        {
            lbCanhBao.Visible = false;
        }
    }
}
