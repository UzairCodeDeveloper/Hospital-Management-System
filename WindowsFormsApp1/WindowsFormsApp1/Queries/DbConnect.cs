using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Queries
{
    internal class DbConnect
    {
        

        private string connstring = "server=localhost;uid=root;pwd=root;database=hms";
        private MySqlConnection conn;

        public MySqlConnection MakeConnection()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();

            return conn;
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
