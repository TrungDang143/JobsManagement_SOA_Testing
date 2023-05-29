using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobsManagement.DAO
{
    internal class CauHoiBaoMatDAO
    {
        public CauHoiBaoMatDAO() { 
            
        }

        public static void loadCHBM(System.Windows.Forms.ComboBox cbb)
        {
            DataTable dt = DataProvider.truyVanCoKetQua("select * from cauhoibaomat");

            foreach (DataRow row in dt.Rows)
            {
                cbb.Items.Add(row.ItemArray[0]);
            }
        }
    }
}
