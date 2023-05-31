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
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True";

        public DataTable truyVanCoKetQua(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

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

                int k = cmd.ExecuteNonQuery();
                if ( k > 0) kq = true;

                conn.Close();
            }
            return kq;
        }
        
        public object truyVanCoMotKetQua(string query)
        {
            object kq = 0;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                kq = cmd.ExecuteScalar();

                conn.Close();
            }
            return kq;
        }
    }
}
