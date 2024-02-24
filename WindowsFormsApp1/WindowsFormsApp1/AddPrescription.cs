using MySql.Data.MySqlClient;
using System;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddPrescription : Form
    {
        public CheckPatients p;
        // Public properties to access TextBox controls
        public System.Windows.Forms.TextBox preWindowDateTextBox => preWindowDate;
        public System.Windows.Forms.TextBox preWindowContactTextBox => preWindowContact;
        public System.Windows.Forms.TextBox comboboxDiseaseName;

        public System.Windows.Forms.ComboBox ComboboxMedicineName => comboboxMedicineName;
        // Example: Initializing p in the constructor
        public AddPrescription(CheckPatients checkPatientsForm)
        {
            InitializeComponent();
            p = checkPatientsForm;
            fill_combo_timming();
            fill_combo_medicine_name();
        }


        void fill_combo_medicine_name()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string QueryMedicine = "select medicine_name from hms.medicines;";

                MySqlCommand MyCommand2 = new MySqlCommand(QueryMedicine, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    this.comboboxMedicineName.Items.Add(name);
                }
                MyReader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fill_combo_timming()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string Query = "select * from hms.timing;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    this.comboboxTiming.Items.Add(name);
                }
                MyReader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {

        }

        public void add_medicine()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    // preWindowContact.Text is the contact_number
                    string selectPatientQuery = "SELECT patient_id FROM patients WHERE contact_number = @contactNumber";
                    MySqlCommand selectPatientCommand = new MySqlCommand(selectPatientQuery, conn);
                    selectPatientCommand.Parameters.AddWithValue("@contactNumber", preWindowContact.Text);

                    int patientId = Convert.ToInt32(selectPatientCommand.ExecuteScalar());
                    int appointmentId = Convert.ToInt32(selectPatientCommand.ExecuteScalar());

                    // preWindowDate.Text is the appointment_date
                    string selectAppointmentQuery = "SELECT appointment_id AND patient_id FROM appointments WHERE appointment_date = @appointmentDate";
                    MySqlCommand selectAppointmentCommand = new MySqlCommand(selectAppointmentQuery, conn);
                    selectAppointmentCommand.Parameters.AddWithValue("@patientId", patientId);
                    selectAppointmentCommand.Parameters.AddWithValue("@appointmentId", appointmentId);
                    selectAppointmentCommand.Parameters.AddWithValue("@appointmentDate", DateTime.Parse(preWindowDate.Text));

                    // Now insert into prescription using the obtained patientId and appointmentId
                    string insertQuery = "INSERT INTO hms.prescription (patient_id, doctor_id, appointment_id, disease, medicine_name, quantity, days, time_of_day) VALUES (@patientId, @docId, @appointmentId,@disease, @medicineName, @quantity, @days, @timeOfDay)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);

                    insertCommand.Parameters.AddWithValue("@patientId", Convert.ToInt32(patientId));
                    insertCommand.Parameters.AddWithValue("@docId", Convert.ToInt32(txtDocId.Text));
                    insertCommand.Parameters.AddWithValue("@appointmentId", Convert.ToInt32(appointmentId));
                    insertCommand.Parameters.AddWithValue("@disease", Convert.ToString(preWindowDisease.Text));
                    insertCommand.Parameters.AddWithValue("@medicineName", comboboxMedicineName.SelectedItem.ToString());
                    insertCommand.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text));
                    insertCommand.Parameters.AddWithValue("@days", Convert.ToInt32(Num_of_days.Text));
                    insertCommand.Parameters.AddWithValue("@timeOfDay", comboboxTiming.Text);

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Prescription Added...");
                    p.btnExit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_medicine();
            p.see_medicine_list();
            this.Close();
            p.btnAddMore.Enabled = true;
            p.btnRemove.Enabled = true;
            p.btnSubmit.Enabled = true;
            p.btnExit.Enabled=true;
        }
    }
}
