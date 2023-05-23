using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement
{
    internal class connectDB
    {
        public static string connString = "Data Source=DTRUNG\\SQLEXPRESS;Initial Catalog=JobsManagement;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connString);

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

        
    }
}
