﻿using JobsManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JobsManagement.DAO
{
    internal class CongViecDAO
    {
        public static bool addJob(CongViec cv)
        {
            int idLap = cv.IdLap;
            string nd = cv.NoiDung;
            DateTime tgBD = cv.TgBD;
            DateTime tgKT = cv.TgKT;
            string trangThai = cv.TrangThai;
            int t2;
            int t3;
            int t4;
            int t5;
            int t6;
            int t7;
            int cn;

            if (cv.LapLai[0] == true)
            {
                t2 = 0;
                t3 = 0;
                t4 = 0;
                cn = 0;
                t5 = 0;
                t6 = 0;
                t7 = 0;
            }
            else if (cv.LapLai[1] == true)
            {
                t2 = 1;
                t3 = 1;
                t4 = 1;
                cn = 1;
                t5 = 1;
                t6 = 1;
                t7 = 1;
            }
            else
            {
                t2 = cv.LapLai[2] == true ? 1 : 0;
                t3 = cv.LapLai[3] == true ? 1 : 0;
                t4 = cv.LapLai[4] == true ? 1 : 0;
                t5 = cv.LapLai[5] == true ? 1 : 0;
                t6 = cv.LapLai[6] == true ? 1 : 0;
                t7 = cv.LapLai[7] == true ? 1 : 0;
                cn = cv.LapLai[8] == true ? 1 : 0;
            }

            bool kq = DAO.DataProvider.Instance.truyVanKTraVe("exec AddJob @id , @noiDungCV , @tgBD , @tgKT , @trangThai , @t2 , @t3 , @t4 , @t5 , @t6 , @t7 , @cn , @tenDangNhap",new object[] { idLap, nd, tgBD, tgKT, trangThai, t2, t3, t4, t5, t6, t7, cn, cv.TenDN });
            return kq;
        }
        public static bool changeJob(CongViec cv, int th)
        {
            int id = cv.Id;
            int idLap = cv.IdLap;
            string nd = cv.NoiDung;
            DateTime tgBD = cv.TgBD;
            DateTime tgKT = cv.TgKT;
            string trangThai = cv.TrangThai;
            int t2;
            int t3;
            int t4;
            int t5;
            int t6;
            int t7;
            int cn;

            if (cv.LapLai[0] == true)
            {
                t2 = 0;
                t3 = 0;
                t4 = 0;
                cn = 0;
                t5 = 0;
                t6 = 0;
                t7 = 0;
            }
            else if (cv.LapLai[1] == true)
            {
                t2 = 1;
                t3 = 1;
                t4 = 1;
                cn = 1;
                t5 = 1;
                t6 = 1;
                t7 = 1;
            }
            else
            {
                t2 = cv.LapLai[2] == true ? 1 : 0;
                t3 = cv.LapLai[3] == true ? 1 : 0;
                t4 = cv.LapLai[4] == true ? 1 : 0;
                t5 = cv.LapLai[5] == true ? 1 : 0;
                t6 = cv.LapLai[6] == true ? 1 : 0;
                t7 = cv.LapLai[7] == true ? 1 : 0;
                cn = cv.LapLai[8] == true ? 1 : 0;
            }

            bool kq = DAO.DataProvider.Instance.truyVanKTraVe("exec ChangeJob @th , @id , @idLap , @noiDungCV , @tgBD , @tgKT , @trangThai , @t2 , @t3 , @t4 , @t5 , @t6 , @t7 , @cn , @tenDangNhap", new object[] {th, id, idLap, nd, tgBD, tgKT, trangThai, t2, t3, t4, t5, t6, t7, cn, cv.TenDN });
            return kq;
        }
        public static int nextIdLap(string userName)
        {
            return (int)DAO.DataProvider.Instance.truyVanCoMotKetQua("select dbo.getNextIdLap( @username )", new object[] { userName });
        }

        public static int tongCV(string userName)
        {
            int kq = (int)DAO.DataProvider.Instance.truyVanCoMotKetQua("exec GetSoCVbyTimeRange @username , @start , @end", new object[] { userName, DateTime.Now, DateTime.Now });
            return kq;
        }
        public static int getSoCVbyTT(string userName, string tt)
        {
            int kq = (int)DAO.DataProvider.Instance.truyVanCoMotKetQua("exec GetSoCVbyTTandTimeRange @tt , @username , @start , @end", new object[] { tt, userName, DateTime.Now, DateTime.Now });
            return kq;
        }

        public static void setTrangThai(string username)
        {
            string query = "exec GetCongViecByDateRange @tgbd , @tgkt , @username";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.truyVanCoKetQua(query, new object[] { DateTime.Now, DateTime.Now, username });
            
            foreach (DataRow items in dt.Rows)
            {
                DateTime start = (DateTime)items[2];
                DateTime finish = (DateTime)items[3];
        
                if(start >= DateTime.Now && finish > DateTime.Now && items[4].ToString() == "Sắp diễn ra")
                {
                    setTT((int)items[0], username, "Đang diễn ra");
                }
                else if(finish <= DateTime.Now && items[4].ToString() == "Đang diễn ra")
                {
                    setTT((int)items[0], username, "Chưa hoàn thành");
                }    
            }
            if(CongViecDAO.getSoCVbyTT(username, "Sắp diễn ra") > 0)
            {
                mainUI.CoCVsdr = true;
            }    
            else mainUI.CoCVsdr = false;
        }
        public static CongViec GetCongViecByID_Username(int id, string username)
        {
            DataTable dt = DAO.DataProvider.Instance.truyVanCoKetQua("exec GetCongViecByID_Username @id , @username", new object[] { id, username });
            try
            {
                DataRow dr = dt.Rows[0];
                CongViec cv = new CongViec(dr);
            
                return cv;
            }
            catch
            {
                throw new Exception("Hãy chọn công việc!");
            }

        }

        public static void XoaCongViec(int id, int idLap, string username)
        {
            DAO.DataProvider.Instance.truyVanKTraVe("exec XoaCongViec @id , @idLap , @username", new object[] { id, idLap, username });
        }

        public static int getIdLap(int id, string username)
        {
            return (int)DAO.DataProvider.Instance.truyVanCoMotKetQua("select dbo.GetIdLapLai( @id , @username )", new object[] { id, username });
        }

        public static void setTT(int id, string username, string tt)
        {
            DAO.DataProvider.Instance.truyVanKTraVe("exec DoiTrangThai @id , @username , @tt", new object[] { id, username, tt });
        }
        public static void XoaTatCaCongViec(string username)
        {
            bool kq = DAO.DataProvider.Instance.truyVanKTraVe("exec XoaTatCaCongViec @username ", new object[] {username} );
			MessageBox.Show("Xóa tất cả công việc ","Thông báo");
//			if ( kq )
//           {
//				MessageBox.Show();
//			}
        }
    }
}
