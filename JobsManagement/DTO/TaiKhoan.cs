using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DTO
{
    internal class TaiKhoan
    {
        private string tenDN;
        private string mk;
        private string tenHT;
        private string cauHoi;
        private string traLoi;
        private bool khoiDong = true;
        private bool nhacNho = true;
        private bool ghiNho = true;
        private Point tgNN = new Point(0, 30);
        bool isAD = false;
        public TaiKhoan(string tenDN, string mk, string tenHT, string CHBM, string tl) 
        {
            this.TenDN = tenDN;
            this.Mk = mk;
            this.TenHT = tenHT;
            this.CauHoi = CHBM;
            this.TraLoi = tl;
        }

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string Mk { get => mk; set => mk = value; }
        public string TraLoi { get => traLoi; set => traLoi = value; }
        public string TenHT { get => tenHT; set => tenHT = value; }
        public bool KhoiDong { get => khoiDong; set => khoiDong = value; }
        public bool NhacNho { get => nhacNho; set => nhacNho = value; }
        public bool GhiNho { get => ghiNho; set => ghiNho = value; }
        public Point TgNN { get => tgNN; set => tgNN = value; }
        public bool IsAD { get => isAD; private set => isAD = value; }
        public string CauHoi { get => cauHoi; set => cauHoi = value; }
    }
}
