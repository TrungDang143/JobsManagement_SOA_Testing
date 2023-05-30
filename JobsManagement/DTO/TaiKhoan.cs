using JobsManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JobsManagement.DTO
{
    public class TaiKhoan
    {
        private string tenDN;
        private string mk;
        private string tenHT;
        private string cauHoi;
        private string traLoi;
        private bool khoiDong = true;
        private bool nhacNho = true;
        private bool nhacNhoCV = true;
        private System.Drawing.Point tgNN = new System.Drawing.Point(0, 30);
        bool isAD = false;
        public TaiKhoan(DataRow row) 
        {
            this.TenDN = row["tenDangNhap"].ToString();
            this.Mk = row["matKhau"].ToString();
            this.TenHT = row["tenHienThi"].ToString();
            this.CauHoi = row["cauhoi"].ToString();
            this.TraLoi = row["traLoi"].ToString();

            if(row["khoiDong"].ToString() == "True")
            {
                this.KhoiDong = true;
            } else this.KhoiDong = false;

            if (row["nhacNho"].ToString() == "True")
            {
                this.NhacNho = true;
            }
            else this.NhacNho = false;

            if (row["nhacNhoCV"].ToString() == "True")
            {
                this.NhacNhoCV = true;
            }
            else this.NhacNhoCV = false;
            
            int h, m;
            h = (int)row["hNhacNho"];
            m = (int)row["mNhacNho"];
            this.TgNN = new System.Drawing.Point(h,m);

            string ad = row["isAD"].ToString();
            this.IsAD = ad == "True"?true:false;
            
        }

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string Mk { get => mk; set => mk = value; }
        public string TraLoi { get => traLoi; set => traLoi = value; }
        public string TenHT { get => tenHT; set => tenHT = value; }
        public bool KhoiDong { get => khoiDong; set => khoiDong = value; }
        public bool NhacNho { get => nhacNho; set => nhacNho = value; }
        public bool NhacNhoCV { get => nhacNhoCV; set => nhacNhoCV = value; }
        public System.Drawing.Point TgNN { get => tgNN; set => tgNN = value; }
        public bool IsAD { get => isAD; private set => isAD = value; }
        public string CauHoi { get => cauHoi; set => cauHoi = value; }
    }
}
