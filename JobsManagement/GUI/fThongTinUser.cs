using JobsManagement.DAO;
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
        public fThongTinUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(BoForm.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
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
                for( int i = 9; i >= 0; i-- )
                {
                    btnXoaTK.Text = string.Format("Xác nhận ({0})", i);
                    Task.Delay(1000).Wait();
                }
                btnXoaTK.Text = "Xác nhận";
                btnXoaTK.Enabled = true;
                isXacNhan = true;
            }
            else
            {
                //sql
                Task.Delay(1000).Wait();
                this.Close();
                isXacNhan = false;
                lbCanhBao.Visible = false;
            }
        }
    }
}
