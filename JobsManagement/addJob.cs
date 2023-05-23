using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsManagement
{
    public partial class fAddJob : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        public fAddJob()
        {
            InitializeComponent();
            load();//37, 42, 64
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        #region title bar

        private void icoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        void load()
        {
            lbNgayBatDau.Text = dateTimePicker2.Value.ToShortDateString();
            lbNgayKetThuc.Text = dateTimePicker2.Value.ToShortDateString();
            nudH.Value = DateTime.Now.Hour;
            nudM.Value = DateTime.Now.Minute;
            
        }
        bool clickThayDoi1 = false;
        bool clickThayDoi2 = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker2.Format = DateTimePickerFormat.Custom;
            //dateTimePicker2.CustomFormat = "DD/MM/YYYY";
            if(!clickThayDoi2)
                lbNgayBatDau.Text = dateTimePicker2.Value.ToShortDateString();
            else lbNgayKetThuc.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void btnThayDoi1_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Focus();
            SendKeys.Send("%{DOWN}");
            clickThayDoi1 = true;
            clickThayDoi2 = false;
        }

        private void btnThayDoi2_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Focus();
            SendKeys.Send("%{DOWN}");
            clickThayDoi2 = true;
            clickThayDoi1 = false;
        }
    }
}
