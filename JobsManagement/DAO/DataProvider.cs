using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JobsManagement.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            /*
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
            */
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
        private DataProvider() { }

        private static string ConnectionString = "Data Source=DESKTOP-JUT8TOT\\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True";

        public DataTable truyVanCoKetQua(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
             
                adt.Fill(dt);

                conn.Close();
            }    
            return dt;
        }

        public bool truyVanKTraVe(string query)
        {
            bool kq = false;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (cmd.ExecuteNonQuery() > 0) kq = true;

                conn.Close();
            }
            return kq;
        }
    }
}
