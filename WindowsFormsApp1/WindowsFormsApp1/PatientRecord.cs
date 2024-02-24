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

namespace WindowsFormsApp1
{
    public partial class PatientRecord : Form
    {
        public PatientRecord()
        {
            InitializeComponent();
        }

        private void PatientRecord_Load_1(object sender, EventArgs e)
        {
            fetchPatientsRecord();
        }

        public void fetchPatientsRecord()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT patients.patient_id, patients.name, patients.date_of_birth, patients.contact_number, admissions.diagnosis, patients.address," +
      " admissions.appointment_date FROM patients LEFT JOIN admissions ON patients.patient_id = admissions.patient_id";
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
