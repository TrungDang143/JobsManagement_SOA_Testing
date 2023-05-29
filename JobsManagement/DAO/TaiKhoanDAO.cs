using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsManagement.DAO
{
    internal class TaiKhoanDAO
    {
        public TaiKhoanDAO() { }
        public static bool login(string username, string password)
        {
            DataTable kq =  DataProvider.truyVanCoKetQua("select * from taikhoan where tendangnhap ='" + username + "' and matkhau = '" + password+"'");
            try
            {
                if (kq.Rows.Count == 1 ) {
                    return true;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public static string getUserName(string tenDN)
        {
            string kq = "";
            try
            {
                DataTable dt = DataProvider.truyVanCoKetQua("select tenHienThi from taikhoan where tendangnhap ='" + tenDN+"'");
                kq = dt.Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                kq = "khong tim thay";
            }
            return kq;
        }
        public static bool isAdmin(string tenDN)
        {
            bool kq = false;
            try
            {
                DataTable dt = DataProvider.truyVanCoKetQua("select isAD from taikhoan where tendangnhap ='" + tenDN + "'");
                string output= dt.Rows[0].ItemArray[0].ToString();
                if (output == "True") kq = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi tim ad");
            }
            return kq;
        }
    }
}
