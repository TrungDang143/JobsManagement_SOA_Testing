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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace JobsManagement.GUI
{
    public partial class ucSetting : UserControl
    {
        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            private set { loginAccount = value; }
        }

        public ucSetting(TaiKhoan loginAcc)
        {
            InitializeComponent();
            LoginAccount = loginAcc;
            loadInfor(loginAcc);

        }
        
        bool isONkd;
        bool isONnncv;
        bool isONnn;

        private void  loadInfor(TaiKhoan loginAcc)
        {
            if (loginAcc.IsAD)
            {
                btnAD.Visible = true;
                panel15.Visible = true;
                pictureBox2.Image = Properties.Resources.icon_adminFix;
                lbTDN.ForeColor = Color.Gold;
                lbTHT.ForeColor = Color.Gold;
            }
            lbTDN.Text = loginAcc.TenDN;
            lbTHT.Text = loginAcc.TenHT;
            
            isONnncv = loginAcc.NhacNhoCV;
            isONkd = loginAcc.KhoiDong;
            isONnn = loginAcc.NhacNho;
            
            switchNhacNho( isONnn);
            switchKhoiDong( isONkd);
            switchGhiNho( isONnncv);

            nudH.Value = LoginAccount.HNN;
            nudM.Value = LoginAccount.MNN;
            if (LoginAccount.DoChamChi == -1)
            {
                lbCC.Text = "Độ chăm chỉ: 0%";
            }
            else
            {
                lbCC.Text = string.Format("Độ chăm chỉ: {0}%", LoginAccount.DoChamChi*100);
            }
        }

        #region cai dat he thong
        private void switchKhoiDong(bool isONkd)
        {
            if (!isONkd)
            {
                switchKD.Image = global::JobsManagement.Properties.Resources.switch_off64;
                TaiKhoanDAO.khoiDong(false);
            }
            else
            {
                switchKD.Image = Properties.Resources.switch_on64;
                TaiKhoanDAO.khoiDong(true);
            }
        }
        private void switchGhiNho(bool isONnncv)
        {
            if (!isONnncv)
            {
                switchNNCV.Image = global::JobsManagement.Properties.Resources.switch_off64;
            }
            else
            {
                switchNNCV.Image = Properties.Resources.switch_on64;
            }
        }
        private void switchNhacNho(bool isONnn)
        {
            if (!isONnn)
            {
                switchNN.Image = global::JobsManagement.Properties.Resources.switch_off64;
            }
            else
            {
                switchNN.Image = Properties.Resources.switch_on64;
            }
            thongBao(isONnn);
        }
        private void switchKD_Click(object sender, EventArgs e)
        {
            isONkd = !isONkd;
            LoginAccount.KhoiDong = isONnncv;
            switchKhoiDong(isONkd);
            TaiKhoanDAO.Instance.setKhoiDong(LoginAccount.TenDN, isONkd);
        }

        private void switchDN_Click(object sender, EventArgs e)
        {
            isONnncv = !isONnncv;
            LoginAccount.NhacNhoCV = isONnncv;
            switchGhiNho(isONnncv);
            TaiKhoanDAO.Instance.setGhiNho(LoginAccount.TenDN, isONnncv);
        }

        private void switchNN_Click(object sender, EventArgs e)
        {
            isONnn = !isONnn;
            LoginAccount.NhacNho = isONnn;
            switchNhacNho(isONnn);
            TaiKhoanDAO.Instance.setNhacNho(LoginAccount.TenDN, isONnn);
        }

        private void thongBao(bool isON)
        {
            if(isON)
            {
                lbThongBao.ForeColor = System.Drawing.Color.MediumTurquoise;
                lbH.ForeColor = Color.White;
                lbM.ForeColor = Color.White;
                nudH.Enabled = true;
                nudM.Enabled = true;
            }
            else
            {
                lbThongBao.ForeColor = System.Drawing.Color.DarkGray;
                lbH.ForeColor = Color.DarkGray;
                lbM.ForeColor = Color.DarkGray;
                nudH.Enabled = false;
                nudM.Enabled = false;
            }
        }         
        private void nudH_ValueChanged_1(object sender, EventArgs e)
        {
            LoginAccount.HNN = (int)nudH.Value;
            LoginAccount.MNN = (int)nudM.Value;
            TaiKhoanDAO.Instance.setTimeNhacNho(loginAccount.TenDN, (int)nudH.Value, (int)nudM.Value);
        }

        #endregion

        #region thong tin ng dung
        private void btnHomNay_Click(object sender, EventArgs e)
        {
            pnlChucNang.Controls.Clear();
            pnlChucNang.Visible = true;
            ucThayDoiThongTin ucThayDoiThongTin = new ucThayDoiThongTin(LoginAccount);
            pnlChucNang.Controls.Add(ucThayDoiThongTin);
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            mainUI mainF = panel.Parent as mainUI;

            Task.Delay(500).Wait();
            mainF.isClose = false;
            mainF.Close();

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            pnlChucNang.Controls.Clear();
            pnlChucNang.Visible = true;

            ucXoaTK ucXoaTK= new ucXoaTK();
            pnlChucNang.Controls.Add(ucXoaTK);
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            pnlChucNang.Controls.Clear();
            pnlChucNang.Visible = true;
            ucAD ucAD= new ucAD();
            pnlChucNang.Controls.Add(ucAD);
        }
        #endregion

        private void pnlAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucSetting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CongViecDAO.XoaCongViecDaQua(loginAccount.TenDN);
        }
    }
}
