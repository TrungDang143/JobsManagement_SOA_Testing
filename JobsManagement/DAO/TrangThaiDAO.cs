using JobsManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DAO
{
    internal class TrangThaiDAO
    {
        public static string getTT(int i)
        {
            TrangThai trangThai = new TrangThai(i);
            return trangThai.tt;
        }
    }
}
