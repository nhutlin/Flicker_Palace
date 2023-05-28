using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class DBConnection
    {
        private static string sql_conn = @"Data Source=TRITUONG;Initial Catalog=FLICKERPALACE;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(sql_conn);
        }
    }
}
