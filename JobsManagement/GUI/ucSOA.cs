using JobsManagement.DTO;
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
    public partial class ucSOA : UserControl
    {
        private TaiKhoan loginAccount;
        public TaiKhoan LoginAccount { get => loginAccount; private set => loginAccount = value; }
        public ucSOA(TaiKhoan tk)
        {
            LoginAccount = tk;
            InitializeComponent();
        }
    }
}
