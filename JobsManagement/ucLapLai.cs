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
    public partial class ucLapLai : UserControl
    {
        public ucLapLai()
        {
            InitializeComponent();
        }

        private void cbxtHN_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxtHN.Checked && d = 1)
            {
                cbt2.Checked = true;
                cbt3.Checked = true;
                cbt4.Checked = true;
                cbt5.Checked = true;
                cbt6.Checked = true;
                cbt7.Checked = true;
                cbcn.Checked = true;
            }
            else if(!cbxtHN.Checked)
            {
                cbt2.Checked = false;
                cbt3.Checked = false;
                cbt4.Checked = false;
                cbt5.Checked = false;
                cbt6.Checked = false;
                cbt7.Checked = false;
                cbcn.Checked = false;
            }

        }

        private void cbcn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbt2.Checked && cbt3.Checked && cbt4.Checked && cbt5.Checked && cbt6.Checked && cbt7.Checked && cbcn.Checked)
            {
                cbxtHN.Checked = true;
            }
            else
            {
                cbxtHN.Checked = false;
            }
        }
    }
}
