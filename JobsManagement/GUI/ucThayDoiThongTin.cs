using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsManagement.GUI
{
    public partial class ucThayDoiThongTin : UserControl
    {
        public ucThayDoiThongTin()
        {
            InitializeComponent();
        }

        private bool checkTHT()
        {
            if (btnDoiTHT.Text.ToString() == "Huỷ"
                && lbGioiHanTHT.Visible == false
                && !string.IsNullOrEmpty(txbTHT.Text.ToString()))
            {
                return true;
            }
            else if (btnDoiTHT.Text.ToString() == "Thay đổi")
                return true;

            return false;
        }

        private bool isEqual = false;
        private bool checkDMK()
        {
            if (btnDoiMK.Text.ToString() == "Huỷ"
                && lbGioiHanMKC.Visible == false
                && !string.IsNullOrEmpty(txbMKC.Text.ToString())
                && lbGioiHanMKM.Visible == false
                && !string.IsNullOrEmpty(txbMKM.Text.ToString())
                && !string.IsNullOrEmpty(txbXNMK.Text.ToString())
                && isEqual
                && picCheck.Visible == true)
            {
                return true;
            }
            else if (btnDoiMK.Text.ToString() == "Thay đổi")
                return true;

            return false;
        }
        private void checkLuu()
        {
            if(checkDMK() && checkTHT())
            {
                if(btnDoiMK.Text.ToString() != "Thay đổi" || btnDoiTHT.Text.ToString() != "Thay đổi")
                {
                    btnLuu.Enabled = true;
                    HLluu.BackColor = Color.Aqua;
                }    
            }
            else
            {
                btnLuu.Enabled = false;
                HLluu.BackColor = Color.DarkGray;
            }
        }

        
        private void txbTHT_TextChanged(object sender, EventArgs e)
        {
            if(txbTHT.Text.Length == 29)
            {
                lbGioiHanTHT.Visible = true;
            }
            else{
                lbGioiHanTHT.Visible = false;
            }
            checkLuu();
        }
        private void txbMKC_TextChanged(object sender, EventArgs e)
        {
            if (txbMKC.Text.Length == 19)
            {
                lbGioiHanMKC.Visible = true;
            }
            else
            {
                lbGioiHanMKC.Visible = false;
            }
            checkLuu();
        }

        private void txbMKM_TextChanged(object sender, EventArgs e)
        {
            if(txbMKM.Text.Length == 19)
            {
                lbGioiHanMKM.Visible = true;
            }
            else{
                lbGioiHanMKM.Visible = false;        
            }

            if (txbXNMK.Text.ToString() == txbMKM.Text.ToString())
            {
                picCheck.Image = Properties.Resources.icons8_tick_501;
                isEqual = true;
            }
            else
            {
                picCheck.Image = Properties.Resources.icons8_multiply_50;
                isEqual = false;
            }

            checkLuu();
        }

        private void txbXNMK_TextChanged(object sender, EventArgs e)
        {
            if (txbXNMK.Text.ToString() == txbMKM.Text.ToString())
            {
                picCheck.Image = Properties.Resources.icons8_tick_501;
                isEqual = true;
            }
            else
            {
                picCheck.Image = Properties.Resources.icons8_multiply_50;
                isEqual = false;
            }

            if(string.IsNullOrEmpty(txbXNMK.Text.ToString()))
                picCheck.Visible = false;
            else picCheck.Visible = true;

            checkLuu();
        }

        private void btnDoiTHT_Click(object sender, EventArgs e)
        {
            if(btnDoiTHT.Text.ToString() == "Thay đổi")
            {
                lbTHT.ForeColor = Color.DeepSkyBlue;
                txbTHT.Enabled = true;
                HL1.BackColor = Color.FromArgb(0, 126, 249);

                btnDoiTHT.Text = "Huỷ";
            }
            else
            {
                lbTHT.ForeColor = Color.DarkGray;
                txbTHT.Enabled = false;
                HL1.BackColor = Color.DarkGray;
                txbTHT.Text = null;
                btnDoiTHT.Text = "Thay đổi";
            }
            checkLuu();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(btnDoiMK.Text.ToString() == "Thay đổi")
            {
                lbMKC.ForeColor = Color.DeepSkyBlue;
                lbMKM.ForeColor = Color.DeepSkyBlue;
                lbXNMK.ForeColor = Color.DeepSkyBlue;

                txbMKC.Enabled = true;
                txbMKM.Enabled = true;
                txbXNMK.Enabled = true;

                HL2.BackColor = Color.FromArgb(0, 126, 249);
                HL3.BackColor = Color.FromArgb(0, 126, 249);
                HL4.BackColor = Color.FromArgb(0, 126, 249);

                mat1.Visible = true;
                mat2.Visible = true;
                mat3.Visible = true;

                btnDoiMK.Text = "Huỷ";
            }
            else
            {
                lbMKC.ForeColor = Color.DarkGray;
                lbMKM.ForeColor = Color.DarkGray;
                lbXNMK.ForeColor = Color.DarkGray;

                txbMKC.Enabled = false;
                txbMKM.Enabled = false;
                txbXNMK.Enabled = false;

                txbMKC.Text = null;
                txbMKM.Text = null;
                txbXNMK.Text = null;

                HL2.BackColor = Color.DarkGray;
                HL3.BackColor = Color.DarkGray;
                HL4.BackColor = Color.DarkGray;

                mat1.Visible = false;
                mat2.Visible = false;
                mat3.Visible = false;

                btnDoiMK.Text = "Thay đổi";
            }
            checkLuu();
        }


        private void ucThayDoiThongTin_Load(object sender, EventArgs e)
        {

        }

        private bool isMat1 = false;
        private bool isMat2 = false;
        private bool isMat3 = false;
        private void mat1_Click(object sender, EventArgs e)
        {
            if(isMat1 == false)
            {
                mat1.Image = Properties.Resources.icons8_open_eye_32;
                isMat1 = true;
            }
            else
            {
                mat1.Image = Properties.Resources.icons8_close_eye_32;
                isMat1 = false;
            }
            txbMKC.UseSystemPasswordChar = !txbMKC.UseSystemPasswordChar;
        }

        private void mat2_Click(object sender, EventArgs e)
        {
            if (isMat2 == false)
            {
                mat2.Image = Properties.Resources.icons8_open_eye_32;
                isMat2 = true;
            }
            else
            {
                mat2.Image = Properties.Resources.icons8_close_eye_32;
                isMat2 = false;
            }
            txbMKM.UseSystemPasswordChar = !txbMKM.UseSystemPasswordChar;
        }

        private void mat3_Click(object sender, EventArgs e)
        {
            if (isMat3 == false)
            {
                mat3.Image = Properties.Resources.icons8_open_eye_32;
                isMat3 = true;
            }
            else
            {
                mat3.Image = Properties.Resources.icons8_close_eye_32;
                isMat3 = false;
            }
            txbXNMK.UseSystemPasswordChar = !txbXNMK.UseSystemPasswordChar;
        }
    }
}
