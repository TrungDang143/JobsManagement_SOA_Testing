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
            Id = (int)DAO.DataProvider.Instance.truyVanCoMotKetQua(string.Format("select top(1) id from CongViec where tenDangNhap = '{0}' order by id desc", userName)) + 1;
            NoiDung = nd;
            tgBD = nbd;
            tgKT = nkt;
            TrangThai = DAO.TrangThaiDAO.getTT(0);
            for(int i = 0; i < 9; i++)
            {
                LapLai[i] = lap[i];
            }
            TenDN = userName;
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
