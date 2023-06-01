using JobsManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JobsManagement.DAO
{
    internal class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            /*
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
            */
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAO();
                }
                return instance;
            }
        }
        public TaiKhoanDAO() { }

        //public TaiKhoan CurrentAcc(string username)
        //{
        //    DataTable data = DataProvider.Instance.truyVanCoKetQua("select * from taikhoan where tendangnhap ='" + username + "'");
        //    foreach (DataRow item in data.Rows)
        //    {
        //        return new TaiKhoan(item);
        //    }
        //    return null;
        //}


        /*
        public bool DKTK(string username, string password, string tenHT, string chbm, string tl)
        {
            bool kq = DataProvider.Instance.truyVanKTraVe(string.Format("insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi) values('{0}','{1}',N'{2}',N'{3}',N'{4}')",username,password,tenHT,chbm,tl));
            return kq;
        }
        */
        public bool signUp(string tenDN, string MK, string MK1, string tenHT, string cauHoi, string traLoi)
        {
            if (tenDN == "" || MK != MK1 || MK == "" || tenHT == "" || traLoi == "" || cauHoi == null)
            {
                return false;
            }
            else
            {
                string query = "exec DangKy_1 @tenDN , @MK , @tenHT , @cauHoi , @traLoi ";
                DataTable data = DataProvider.Instance.truyVanCoKetQua(query, new object[] { tenDN, MK, tenHT, cauHoi, traLoi });
                return true;
            }
        }

        public TaiKhoan CurrentAcc(string userName)
        {
            string query = "exec DangNhap_2 @userName ";
            DataTable data = DataProvider.Instance.truyVanCoKetQua(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }

            return null;
        }
        
        /*
        public bool login(string username, string password)
        {
            DataTable kq = DataProvider.Instance.truyVanCoKetQua("select * from taikhoan where tendangnhap ='" + username + "' and matkhau = '" + password + "'");
            try
            {
                if (kq.Rows.Count == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        */
        public bool Login(string userName, string passWord)
        {
            string query = "exec DangNhap_1 @userName , @passWord ";
            DataTable data = DataProvider.Instance.truyVanCoKetQua(query, new object[] { userName, passWord });
            return data.Rows.Count > 0;
        }
        public void setKhoiDong(string userName, bool isOn)
        {
            if (isOn)
            {
                DataProvider.Instance.truyVanKTraVe("update TaiKhoan set khoiDong = 1 where tenDangNhap ='" + userName + "'");

            }
            else DataProvider.Instance.truyVanKTraVe("update TaiKhoan set khoiDong = 0 where tenDangNhap ='" + userName + "'");
        }
        public void setNhacNho(string userName, bool isOn)
        {
            if (isOn)
            {
                DataProvider.Instance.truyVanKTraVe("update TaiKhoan set nhacNho = 1 where tenDangNhap ='" + userName + "'");
            }else DataProvider.Instance.truyVanKTraVe("update TaiKhoan set nhacNho = 0 where tenDangNhap ='" + userName + "'");
        }
        public void setGhiNho(string userName, bool isOn)
        {
            if (isOn)
            {
                DataProvider.Instance.truyVanKTraVe("update TaiKhoan set ghiNho = 1 where tenDangNhap ='" + userName + "'");
            }else DataProvider.Instance.truyVanKTraVe("update TaiKhoan set ghiNho = 0 where tenDangNhap ='" + userName + "'");
        }

        public void setTimeNhacNho(string userName, int h, int m)
        {
            DataProvider.Instance.truyVanKTraVe(string.Format("update TaiKhoan set hNhacNho = {0}, mNhacNho = {1} where tenDangNhap = '{2}'",h,m,userName));
        }
    }
}
