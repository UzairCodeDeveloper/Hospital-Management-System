using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Queries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            fetchAppointmentRecord();
        }

        public void fetchAppointmentRecord()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();

                // Fetch pending requests
                string sqlPending = "SELECT appointment_id, patient_id, appointment_date, status FROM appointments WHERE status = 'Pending' AND doctor_id = '" + currDoc.Text + "';";
                MySqlCommand cmdPending = new MySqlCommand(sqlPending, conn);
                MySqlDataAdapter adapterPending = new MySqlDataAdapter();
                adapterPending.SelectCommand = cmdPending;
                DataTable dtPending = new DataTable();
                adapterPending.Fill(dtPending);
                BindingSource bindingSourcePending = new BindingSource();
                bindingSourcePending.DataSource = dtPending;
                dataGridViewAppointment1.DataSource = bindingSourcePending;

                // Fetch accepted requests
                string sqlAccepted = "SELECT appointment_id, patient_id, appointment_date, status FROM appointments WHERE status = 'Accepted' AND doctor_id = '" + currDoc.Text + "';";
                MySqlCommand cmdAccepted = new MySqlCommand(sqlAccepted, conn);
                MySqlDataAdapter adapterAccepted = new MySqlDataAdapter();
                adapterAccepted.SelectCommand = cmdAccepted;
                DataTable dtAccepted = new DataTable();
                adapterAccepted.Fill(dtAccepted);
                BindingSource bindingSourceAccepted = new BindingSource();
                bindingSourceAccepted.DataSource = dtAccepted;
                dataGridViewAppointment2.DataSource = bindingSourceAccepted;

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewAppointment1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void accept_table()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";

            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT appointment_id, patient_id, appointment_date, status FROM appointments where status='" + "Accepted"+ "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridViewAppointment2.DataSource = bindingSource;
                dataGridViewAppointment2.Refresh();
            }
            catch (Exception accept)
            {
                MessageBox.Show(accept.Message.ToString());
            }

        }

        void show_all()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT appointment_id, patient_id, appointment_date, status FROM appointments where status='" + "pending"+"';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridViewAppointment1.DataSource = bindingSource;
                dataGridViewAppointment1.Refresh();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    // Check if there is at least one selected row
                    if (dataGridViewAppointment1.SelectedRows.Count > 0)
                    {
                        // Access the first selected row (assuming single row selection)
                        DataGridViewRow selectedRow = dataGridViewAppointment1.SelectedRows[0];

                        // Access data in specific cells of the selected row
                        string appointment_id = selectedRow.Cells["appointment_id"].Value.ToString();
                        string patient_id = selectedRow.Cells["patient_id"].Value.ToString();

                        string sql = "UPDATE hms.appointments SET status = 'Accepted' WHERE appointment_id = @appointment_id AND patient_id = @patient_id;";

                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            // Add parameters to the query to prevent SQL injection
                            command.Parameters.AddWithValue("@appointment_id", appointment_id);
                            command.Parameters.AddWithValue("@patient_id", patient_id);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment Accepted Successfully.");
                                // Additional actions after successful update
                                accept_table();
                                show_all();
                            }
                            else
                            {
                                MessageBox.Show("No appointment found for the specified criteria.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a row in the grid.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    // Check if there is at least one selected row
                    if (dataGridViewAppointment1.SelectedRows.Count > 0)
                    {
                        // Access the first selected row (assuming single row selection)
                        DataGridViewRow selectedRow = dataGridViewAppointment1.SelectedRows[0];

                        // Access data in specific cells of the selected row
                        string appointment_id = selectedRow.Cells["appointment_id"].Value.ToString();
                        string patient_id = selectedRow.Cells["patient_id"].Value.ToString();

                        string sql = "DELETE FROM hms.appointments WHERE appointment_id = @appointment_id AND patient_id = @patient_id;";
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            // Add parameters to the query to prevent SQL injection
                            command.Parameters.AddWithValue("@appointment_id", appointment_id);
                            command.Parameters.AddWithValue("@patient_id", patient_id);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment Rejected Successfully.");
                                // Additional actions after successful update
                                show_all();
                            }
                            else
                            {
                                MessageBox.Show("No appointment found for the specified criteria.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a row in the grid.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

