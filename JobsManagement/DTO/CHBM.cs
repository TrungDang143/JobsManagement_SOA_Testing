using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace JobsManagement.DTO
{
    internal class CHBM
    {
        private string cauhoi = "";

        public string Cauhoi { get => cauhoi; set => cauhoi = value; }


        public CHBM(string ch)
        {
             cauhoi = ch;
        }

    }
}
