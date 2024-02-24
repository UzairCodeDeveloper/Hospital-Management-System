using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1.Queries
{

    internal class AdminDoctor
    {
        DbConnect db =new DbConnect();
        public void InsertRecord(string name, string age, string gender, string email, string sp, string cn, string wh,string pwd)
        {
            
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "INSERT INTO doctors (Name, Age, Gender, email, specialization, contact_number, WorkingHours,password) VALUES (@name, @age, @gender, @email, @sp, @cn, @wh,@pwd)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sp", sp);
                cmd.Parameters.AddWithValue("@cn", cn);
                cmd.Parameters.AddWithValue("@wh", wh);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");
                
                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable SearchById(int doctorId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "SELECT * FROM doctors WHERE doctor_id = @doctorId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);

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


        public bool DeleteById(int doctorId)
{
    try
    {
        MySqlConnection connection = db.MakeConnection();

        string sql = "DELETE FROM doctors WHERE doctor_id = @doctorId";
        MySqlCommand cmd = new MySqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@doctorId", doctorId);

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

        public void UpdateRecord(int doctorId, string name, string age, string gender, string email, string sp, string cn, string wh, string pwd)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "UPDATE doctors SET Name = @name, Age = @age, Gender = @gender, " +
                             "email = @email, specialization = @sp, contact_number = @cn, " +
                             "WorkingHours = @wh, password = @pwd WHERE doctor_id = @doctorId";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sp", sp);
                cmd.Parameters.AddWithValue("@cn", cn);
                cmd.Parameters.AddWithValue("@wh", wh);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);

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
