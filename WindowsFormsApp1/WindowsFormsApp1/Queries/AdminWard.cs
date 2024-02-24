using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Queries
{
    internal class AdminWard

    {       DbConnect db = new DbConnect();
        public void InsertRecord(string wardname, string wardCapacity, string wardIncharge)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "INSERT INTO wards (ward_name, capacity, wardIncharge) VALUES (@wardname, @wardCapacity, @wardIncharge)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@wardname", wardname); // Fix parameter name here
                cmd.Parameters.AddWithValue("@wardCapacity", wardCapacity);
                cmd.Parameters.AddWithValue("@wardIncharge", wardIncharge);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable SearchById(int wardId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "SELECT * FROM wards WHERE ward_number = @wardId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@wardId", wardId);

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

        public bool DeleteById(int wardId)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "DELETE FROM wards WHERE ward_number = @wardId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@wardId", wardId);

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


        public void UpdateRecord(int wardid, string wardName, string wardCapacity, string wardIncharge)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "UPDATE wards SET ward_name = @wardName, capacity = @wardCapacity, " +
                             "wardIncharge = @wardIncharge " +
                             "WHERE ward_number = @wardid";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@wardName", wardName);
                cmd.Parameters.AddWithValue("@wardCapacity", wardCapacity);
                cmd.Parameters.AddWithValue("@wardIncharge", wardIncharge);
                cmd.Parameters.AddWithValue("@wardid", wardid);

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
