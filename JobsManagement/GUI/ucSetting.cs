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
        public ucSetting()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        bool isONkd = true;
        private void switchKD_Click(object sender, EventArgs e)
        {
            if (isONkd)
            {
                switchKD.Image = global::JobsManagement.Properties.Resources.switch_off64;
                isONkd = false;
            }
            else
            {
                switchKD.Image = Properties.Resources.switch_on64;
                isONkd = true ;
            }
        }

        bool isONdn = true;
        private void switchDN_Click(object sender, EventArgs e)
        {
            if (isONdn)
            {
                switchDN.Image = global::JobsManagement.Properties.Resources.switch_off64;
                isONdn = false;
            }
            else
            {
                switchDN.Image = Properties.Resources.switch_on64;
                isONdn = true;
            }
        }

        bool isONnn = true;
        private void switchNN_Click(object sender, EventArgs e)
        {
            if (isONnn)
            {
                switchNN.Image = global::JobsManagement.Properties.Resources.switch_off64;
                isONnn = false;
            }
            else
            {
                switchNN.Image = Properties.Resources.switch_on64;
                isONnn = true;
            }
            thongBao(isONnn);
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
    }
}
