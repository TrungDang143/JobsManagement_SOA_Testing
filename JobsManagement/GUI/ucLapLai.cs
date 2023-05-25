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

        #region checkbox
        private bool checkHN = true;//tranh bi bo check het cac ngay khi bo check cbxHN
        private void cbxtHN_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxtHN.Checked)
            {
                checkHN = true;
                cbt2.Checked = true;
                cbt3.Checked = true;
                cbt4.Checked = true;
                cbt5.Checked = true;
                cbt6.Checked = true;
                cbt7.Checked = true;
                cbcn.Checked = true;
            }
            else if(!cbxtHN.Checked && checkHN)
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
                checkHN = false;
                cbxtHN.Checked = false;
            }
        }

        public bool check()
        {
            if(cbt2.Checked || cbt3.Checked || cbt4.Checked || cbt5.Checked || cbt6.Checked || cbt7.Checked || cbcn.Checked)
            { 
                return true; 
            }
            return false;
        }

        public void ThuLapLai(int a)
        {
            switch (a)
            {
                case 0: cbt2.Checked = true; break;
                case 1: cbt3.Checked = true; break;
                case 2: cbt4.Checked = true; break;
                case 3: cbt5.Checked = true; break;
                case 4: cbt6.Checked = true; break;
                case 5: cbt7.Checked = true; break;
                case 6: cbcn.Checked = true; break;
                default: break;
            }
        }
        #endregion



    }
}
