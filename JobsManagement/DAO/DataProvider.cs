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
        private static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True";

        public static DataTable truyVanCoKetQua(string query)
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

        public static bool truyVanKTraVe(string query)
        {
            bool kq = false;
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (cmd.ExecuteNonQuery() > 0) kq = true;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kq;
        }
    }
}
