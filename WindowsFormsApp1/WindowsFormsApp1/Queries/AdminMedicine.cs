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
    internal class AdminMedicine
    {
        DbConnect db = new DbConnect();

        public void InsertRecord(string name,string EDate,string Cname,string Contact,string cost, string diseasename, string diseasetype)
        {

            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "INSERT INTO medicines (medicine_name,Company_Name,Expire_Date,Company_Contact,Cost,disease_type,disease_name) VALUES (@name, @Cname, @EDate, @Contact, @cost,@diseasetype,@diseasename)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@Cname", Cname);
                cmd.Parameters.AddWithValue("@EDate", EDate);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@diseasetype", diseasetype);
                cmd.Parameters.AddWithValue("@diseasename", diseasename);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public DataTable SearchById(int medicineId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "SELECT * FROM medicines WHERE medicine_id = @medicineId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@medicineId", medicineId);

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
        public bool DeleteById(int medicineId)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "DELETE FROM medicines WHERE medicine_id = @medicineId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@medicineId", medicineId);

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

        public void UpdateRecord(int medicineId, string name, string companyName, string contact, string Date, string Cost)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "UPDATE medicines SET Medicine_Name = @name, Company_Name = @companyName, " +
                             "Company_Contact = @contact, Expire_Date = @Date, Cost = @Cost " +
                             "WHERE medicine_id = @medicineId";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@companyName", companyName);
                cmd.Parameters.AddWithValue("@contact", contact); // Fix parameter name here
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Cost", Cost);
                cmd.Parameters.AddWithValue("@medicineId", medicineId);

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
