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
        public static string connString = "Data Source=DTRUNG\\SQLEXPRESS;Initial Catalog=testThemXoaSua;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connString);

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
