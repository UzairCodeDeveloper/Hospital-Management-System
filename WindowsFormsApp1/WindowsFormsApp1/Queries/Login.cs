using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Queries
{
    internal class Login
    {
        DbConnect db =new DbConnect();


        public bool checkLogin(string selection, string username, string pwd)
        {
            bool isAuthenticated = false;

            try
            {
                MySqlConnection connection = db.MakeConnection();
                MySqlCommand cmd;

                if (selection == "Doctor")
                {
                    string sql = "SELECT * FROM doctors WHERE doctor_id=@username AND password=@pwd";
                    cmd = new MySqlCommand(sql, connection);
                }
                else if (selection == "Administrator")
                {
                    string sql = "SELECT * FROM admins WHERE username=@username AND password=@pwd";
                    cmd = new MySqlCommand(sql, connection);
                }
                else if (selection == "Staff")
                {
                    string sql = "SELECT * FROM staff WHERE staff_id=@username AND Password=@pwd";
                    cmd = new MySqlCommand(sql, connection);
                }
                else
                {
                    // Handle unknown selection value
                    return false;
                }

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // If there is a matching record, set isAuthenticated to true
                        isAuthenticated = true;
                    }
                }

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return isAuthenticated;
        }

    }
}
