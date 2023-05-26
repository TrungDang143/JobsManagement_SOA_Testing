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
    public partial class ucAD : UserControl
    {
        public ucAD()
        {
            InitializeComponent();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucAD_Load(object sender, EventArgs e)
        {

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            fThongTinUser fThongTinUser = new fThongTinUser();
            fThongTinUser.ShowDialog();
        }
    }
}
