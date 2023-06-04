using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JobsManagement.DTO
{
    public class CongViec
    {
        private int id;
        private string noiDung;
        private DateTime tgBD = new DateTime();
        private DateTime tgKT = new DateTime();
        private string trangThai;
        private bool[] lapLai = new bool[9];//0,hn,2,3,4,5,6,7,cn
        private string tenDN;

        public CongViec(string nd, DateTime nbd, DateTime nkt, bool[] lap, string userName)
        {
            //chuyển id thành hàm lấy id tiếp theo, để trong congviecDAO
            Id = CongViecDAO.nextID(userName);
            NoiDung = nd;
            TgBD = nbd;
            TgKT = nkt;
            TrangThai = DAO.TrangThaiDAO.getTT(0);
            for(int i = 0; i < 9; i++)
            {
                LapLai[i] = lap[i];
            }
            TenDN = userName;
        }
        public CongViec(DataRow dr)
        {
            Id = (int)dr[0];
            NoiDung = (string)dr[1];
            TgBD = (DateTime)dr[2];
            TgKT = (DateTime)dr[3];
            TrangThai = (string)dr[4];

            int dem = 0;
            for ( int i = 5; i < 12; i++)
            {
                if (dr[i].ToString() == "True")
                {
                    LapLai[i - 3] = true;
                    dem++;
                }
                else LapLai[i - 3] = false;
            }

            LapLai[0] = dem > 0 ? false : true;
            LapLai[1] = dem == 7 ? true : false;

            TenDN = (string)dr[12];
        }

        public int Id { get => id; set => id = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime TgBD { get => tgBD; set => tgBD = value; }
        public DateTime TgKT { get => tgKT; set => tgKT = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public bool[] LapLai { get => lapLai; set => lapLai = value; }
    }
}
