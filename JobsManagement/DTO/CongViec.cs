using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DTO
{
    internal class CongViec
    {
        private static int id;
        private string noiDung;
        private DateTime ngayBD = new DateTime();
        private Point gioBD = new Point();
        private DateTime ngayKT = new DateTime();
        private Point gioKT = new Point();
        private string trangThai;
        private string lapLai;
        private string tenDN;

        public int Id { get => id; set => id = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public Point GioBD { get => gioBD; set => gioBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
        public Point GioKT { get => gioKT; set => gioKT = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string LapLai { get => lapLai; set => lapLai = value; }

        public CongViec(string nd, DateTime nbd, Point gbd, DateTime nkt, Point gkt, int kieuLap)
        {
            NoiDung = nd;
            NgayBD = nbd;
            GioBD = gbd;
            NgayKT = nkt;
            GioKT = gkt;
            
            DTO.LapLai stringLap = new DTO.LapLai(kieuLap);
            LapLai = stringLap.Lap;
            
            DTO.TrangThai stringTT = new DTO.TrangThai(0);
            TrangThai = stringTT.tt;

        }
    }
}
