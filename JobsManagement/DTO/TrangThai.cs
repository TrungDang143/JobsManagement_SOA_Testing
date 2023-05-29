using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DTO
{
    internal class TrangThai
    {
        public string tt;

        public TrangThai(int i) { 
            switch (i)
            {
                case 0: tt = "Sắp diễn ra";
                    break;
                case 1:
                    tt = "Đang diễn ra";
                    break;
                case 2:
                    tt = "Đã hoàn thành";
                    break;
                default:
                    tt = "Chưa hoàn thành";
                    break;
            }
        }
    }
}
