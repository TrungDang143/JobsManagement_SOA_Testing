using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DTO
{
    internal class Acc
    {
        private string tenDN;
        private string mk;
        public Acc(string tenDN, string mk, string tenHT, string CHBM, string tl, bool isAD = false) 
        {
            //this.
        }

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string Mk { get => mk; set => mk = value; }
    }
}
