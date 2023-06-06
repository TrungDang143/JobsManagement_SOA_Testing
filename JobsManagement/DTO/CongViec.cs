using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JobsManagement.DTO
{
    public class CongViec
    {
        private int id;
        private int idLap;
        private string noiDung;
        private DateTime tgBD = new DateTime();
        private DateTime tgKT = new DateTime();
        private string trangThai;
        private bool[] lapLai = new bool[9];//0,hn,2,3,4,5,6,7,cn
        private string tenDN;

        public CongViec(int idLap, string nd, DateTime nbd, DateTime nkt, bool[] lap, string userName)
        {
            NoiDung = nd;
            TgBD = nbd;
            TgKT = nkt;
            TrangThai = DAO.TrangThaiDAO.getTT(0);
            for(int i = 0; i < 9; i++)
            {
                LapLai[i] = lap[i];
            }
            TenDN = userName;
            IdLap = idLap;
        }
        public CongViec(int id, int idLap, string nd, DateTime nbd, DateTime nkt, bool[] lap, string userName)
        {
            Id = id;
            NoiDung = nd;
            TgBD = nbd;
            TgKT = nkt;
            TrangThai = DAO.TrangThaiDAO.getTT(0);
            for (int i = 0; i < 9; i++)
            {
                LapLai[i] = lap[i];
            }
            TenDN = userName;
            IdLap = idLap;
        }
        public CongViec(DataRow dr)
        {
            Id = (int)dr[0];
            IdLap = (int)dr[1];
            NoiDung = (string)dr[2];
            TgBD = (DateTime)dr[3];
            TgKT = (DateTime)dr[4];
            TrangThai = (string)dr[5];

            int dem = 0;
            for ( int i = 6; i < 13; i++)
            {
                if (dr[i].ToString() == "True")
                {
                    LapLai[i - 4] = true;
                    dem++;
                }
                else LapLai[i - 4] = false;
            }

            LapLai[0] = dem > 0 ? false : true;
            LapLai[1] = dem == 7 ? true : false;

            TenDN = (string)dr[13];
        }

        public int IdLap { get => idLap; set => idLap = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime TgBD { get => tgBD; set => tgBD = value; }
        public DateTime TgKT { get => tgKT; set => tgKT = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public bool[] LapLai { get => lapLai; set => lapLai = value; }
        public int Id { get => id; set => id = value; }
    }
}
