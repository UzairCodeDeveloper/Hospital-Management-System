using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Web;
using System.Data;

namespace WindowsFormsApp1.Queries
{
    internal class AdminStaff
    {
        DbConnect db = new DbConnect();
        public void InsertRecord(string name, string age, string cn, string role, string gender, string email, string pwd, string shift, string address)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "INSERT INTO staff (Name, Age, Gender, email, contact_number, Password, position, Shift, Address) " +
                             "VALUES (@name, @age, @gender, @email, @cn, @pwd, @role, @shift, @address)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cn", cn);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@role", role); // Add this line for the 'position' parameter
                cmd.Parameters.AddWithValue("@shift", shift);
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

        public DataTable SearchById(int staffId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "SELECT * FROM staff WHERE staff_id = @staffId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@staffId", staffId);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return dataTable;
        }


        public bool DeleteById(int staffId)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "DELETE FROM staff WHERE staff_id = @staffId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@staffId", staffId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    return true;
                }
                else
                {
                    MessageBox.Show("No record found for the specified ID.");
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                db.CloseConnection();
            }

            return false;
        }


        public void UpdateRecord(int staffId, string name, string age, string cn, string role, string gender, string email, string pwd, string shift, string address)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "UPDATE staff SET Name = @name, Age = @age, Gender = @gender, " +
                             "email = @email, contact_number = @cn, Password = @pwd, " +
                             "position = @role, Shift = @shift, Address = @address WHERE staff_id = @staffId";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cn", cn);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@shift", shift);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@staffId", staffId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
            
        

    }
}
