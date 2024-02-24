using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CheckPatients : Form
    {
        public CheckPatients()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        ///Variables For Medicine list
        public string med_name = "";
        public string quantity = "";
        public string days = "";
        public string timeOfDay = "";

        public string type = "";
        public string Query = "";
        public string Query78;
        public string doc_dept = "";
        public void check_doctor_dept()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                Query78 = "select department from hms.doctors where doctor_id='" + currDoc.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query78, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    doc_dept = MyReader2.GetString(0);
                }
                MyReader2.Close();

                if (doc_dept.Equals("Cardiology"))
                {
                    string Query100 = "select distinct disease_name from hms.medicines where disease_type='" + "Cardiac" + "';";
                    MySqlCommand MyCommand100 = new MySqlCommand(Query100, conn);
                    MySqlDataReader MyReader100;
                    MyReader100 = MyCommand100.ExecuteReader();
                    while (MyReader100.Read())
                    {
                        string name = MyReader100.GetString(0);
                        this.comboboxDiseaseName.Items.Add(name);
                    }
                    MyReader100.Close();

                }

                else if (doc_dept.Equals("Neurology"))
                {

                    string Query101 = "select distinct disease_name from hms.medicines where disease_type='" + "Neurological" + "';";
                    MySqlCommand MyCommand101 = new MySqlCommand(Query101, conn);
                    MySqlDataReader MyReader101;
                    MyReader101 = MyCommand101.ExecuteReader();
                    while (MyReader101.Read())
                    {
                        string name = MyReader101.GetString(0);
                        this.comboboxDiseaseName.Items.Add(name);
                    }
                    MyReader101.Close();
                }

                else if (doc_dept.Equals("Orthopedics"))
                {
                    string Query102 = "select distinct disease_name from hms.medicines where disease_type='" + "Orthopedic" + "';";
                    MySqlCommand MyCommand102 = new MySqlCommand(Query102, conn);
                    MySqlDataReader MyReader102;
                    MyReader102 = MyCommand102.ExecuteReader();
                    while (MyReader102.Read())
                    {
                        string name = MyReader102.GetString(0);
                        this.comboboxDiseaseName.Items.Add(name);
                    }
                    MyReader102.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void add_more_medicines()
        {
            AddPrescription prescriptionWindow = new AddPrescription(this);

            // Check if the controls in AddPrescription are initialized
            if (prescriptionWindow.preWindowDateTextBox != null &&
                prescriptionWindow.preWindowContactTextBox != null &&
                prescriptionWindow.txtDocId != null &&
                prescriptionWindow.preWindowDisease != null &&
                prescriptionWindow.ComboboxMedicineName != null)
            {
                prescriptionWindow.preWindowDateTextBox.Text = txtDate.Text;
                prescriptionWindow.preWindowContactTextBox.Text = txtContact.Text;
                prescriptionWindow.txtDocId.Text = currDoc.Text;
                prescriptionWindow.preWindowDisease.Text = comboboxDiseaseName.SelectedItem.ToString();

                prescriptionWindow.Show();
            }
            else
            {
                MessageBox.Show("Controls in AddPrescription form are not initialized.");
            }
        }

        public void see_medicine_list()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    // Retrieve patient_id
                    string selectPatientQuery = "SELECT patient_id FROM patients WHERE contact_number = @contactNumber";
                    MySqlCommand selectPatientCommand = new MySqlCommand(selectPatientQuery, conn);
                    selectPatientCommand.Parameters.AddWithValue("@contactNumber", txtContact.Text);

                    int patientId = Convert.ToInt32(selectPatientCommand.ExecuteScalar());
                    int appointmentId = Convert.ToInt32(selectPatientCommand.ExecuteScalar());

                    // Retrieve appointment_id
                    string selectAppointmentQuery = "SELECT appointment_id FROM appointments WHERE patient_id = @patientId AND appointment_date = @appointmentDate AND doctor_id = @docId";
                    MySqlCommand selectAppointmentCommand = new MySqlCommand(selectAppointmentQuery, conn);
                    selectAppointmentCommand.Parameters.AddWithValue("@patientId", patientId);
                    selectAppointmentCommand.Parameters.AddWithValue("@appointmentId", appointmentId);
                    selectAppointmentCommand.Parameters.AddWithValue("@appointmentDate", DateTime.Parse(txtDate.Text));

                    // Retrieve prescription records
                    string sql = "SELECT * FROM prescription WHERE patient_id = @patientId AND appointment_id = @appointmentId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    dataGridView2.DataSource = bindingSource;

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
                        MessageBox.Show("Patient checked successfully...");

                        // Reset form fields and refresh data
                        txtAge.Text = "";
                        txtContact.Text = "";
                        txtDate.Text = "";
                        comboboxDiseaseName.Text = "";
                        txtPName.Text = "";

            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

        } 




    private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView2.Refresh();
        }

        public int count = 0;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    count++;
                    if (count > 1)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }

                    // Retrieve patient_id
                    string selectPatientQuery = "SELECT patient_id FROM patients WHERE contact_number = @contactNumber";
                    MySqlCommand selectPatientCommand = new MySqlCommand(selectPatientQuery, conn);
                    selectPatientCommand.Parameters.AddWithValue("@contactNumber", txtContact.Text);

                    int patientId = Convert.ToInt32(selectPatientCommand.ExecuteScalar());

                    // Retrieve appointment_id
                    string selectAppointmentQuery = "SELECT appointment_id FROM appointments WHERE patient_id = @patientId AND appointment_date = @appointmentDate";
                    MySqlCommand selectAppointmentCommand = new MySqlCommand(selectAppointmentQuery, conn);
                    selectAppointmentCommand.Parameters.AddWithValue("@patientId", patientId);
                    selectAppointmentCommand.Parameters.AddWithValue("@appointmentDate", DateTime.Parse(txtDate.Text));

                    int appointmentId = Convert.ToInt32(selectAppointmentCommand.ExecuteScalar());

                    // Delete prescription
                    string sql = "DELETE FROM hms.prescription WHERE patient_id = @patientId AND appointment_id = @appointmentId AND disease = @disease AND medicine_name = @medicineName AND quantity = @quantity AND days = @days AND time_of_day = @timeOfDay";
                    MySqlCommand deleteCommand = new MySqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@patientId", patientId);
                    deleteCommand.Parameters.AddWithValue("@appointmentId", appointmentId);

                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    deleteCommand.Parameters.AddWithValue("@disease", selectedRow.Cells["disease"].Value.ToString());
                    deleteCommand.Parameters.AddWithValue("@medicineName", selectedRow.Cells["medicine_name"].Value.ToString());
                    deleteCommand.Parameters.AddWithValue("@quantity", Convert.ToInt32(selectedRow.Cells["quantity"].Value));
                    deleteCommand.Parameters.AddWithValue("@days", Convert.ToInt32(selectedRow.Cells["days"].Value));
                    deleteCommand.Parameters.AddWithValue("@timeOfDay", selectedRow.Cells["time_of_day"].Value.ToString());

                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medicine Removed!");
                        dataGridView2.Rows.Remove(selectedRow);
                        dataGridView2.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No matching record found to remove.");
                    }

                    conn.Close();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message.ToString());
            }
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            add_more_medicines();
        }
        private void btnPrescribe_Click(object sender, EventArgs e)
        {
            add_more_medicines();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT patients.patient_id, patients.name, patients.gender, patients.date_of_birth, patients.contact_number, patients.address," +
              "appointments.appointment_date FROM patients LEFT JOIN appointments ON patients.patient_id = appointments.patient_id " +
              "WHERE appointments.doctor_id ='" + currDoc.Text + "' AND appointments.status = 'Accepted'";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT * FROM admissions WHERE doc_id='" + currDoc.Text + "';";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Update TextBoxes with relevant values
                txtContact.Text = selectedRow.Cells["contact_number"].Value.ToString();
                txtPName.Text = selectedRow.Cells["name"].Value.ToString();
                txtAge.Text = selectedRow.Cells["date_of_birth"].Value.ToString();
                txtDate.Text = selectedRow.Cells["appointment_date"].Value.ToString();
                //txtDisease.Text = selectedRow.Cells["Disease"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CheckPatients_Load(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
