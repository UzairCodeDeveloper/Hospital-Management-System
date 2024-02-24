using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Queries
{
    internal class StaffPatient
    {
        DbConnect db = new DbConnect();

        public void InsertRecord(string name, string Gender, string Dob, string Contact, string address)
        {

            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "INSERT INTO patients (name,gender,date_of_birth,contact_number,address) VALUES (@name, @Gender, @Dob, @Contact, @address)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Dob", Dob);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@address", address);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
