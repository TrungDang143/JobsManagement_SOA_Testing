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
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCalendar newform = new fCalendar();
            newform.Location = this.Location;
            newform.StartPosition = FormStartPosition.Manual;
            newform.ShowDialog();
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            fThongKe newform = new fThongKe();
            newform.Location = this.Location;
            newform.StartPosition = FormStartPosition.Manual;
            newform.ShowDialog();
            this.Close();
        }
    }
}
