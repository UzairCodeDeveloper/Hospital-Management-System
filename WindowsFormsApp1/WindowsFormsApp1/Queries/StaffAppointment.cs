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
    internal class StaffAppointment
    {
        DbConnect db = new DbConnect();
        public DataTable SearchById(int patientId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection connection = db.MakeConnection();

                string sql = "SELECT * FROM patients WHERE patient_id = @patientId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@patientId", patientId);

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


        public void InsertRecord(string patientid, string date, string doctorId)
        {
            try
            {
                MySqlConnection connection = db.MakeConnection();

                string status = "Pending";
                string sql = "INSERT INTO appointments (patient_id, appointment_date, doctor_id,status) VALUES (@patientid, @date, @doctorId, @status)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@patientid", patientid); // Fix parameter name here
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@status", status);

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
