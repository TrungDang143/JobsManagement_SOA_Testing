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
using System.Windows.Forms.DataVisualization.Charting;

namespace JobsManagement
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
            dtpk.Value = timeOfDtpk.TimeSelection;
        }

        private void lbCVchuaHoanThanh_Click(object sender, EventArgs e)
        {

        }
    }
}
