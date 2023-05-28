using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement
{
    internal class connectDB
    {
        private static string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(ConnString);

        public static string ConnString { get => connString; set => connString = value; }

        public void openConn()
        { 
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open(); 
        }

        public void closeConn()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
        }
        public DataTable truyVan(string query)
        {
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dataTable);
            return dataTable;
        }
        
    }
}
