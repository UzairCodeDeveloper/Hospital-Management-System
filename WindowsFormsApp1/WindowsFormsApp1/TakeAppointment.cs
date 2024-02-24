using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Queries;

namespace WindowsFormsApp1
{
    public partial class TakeAppointment : Form
    {
        DbConnect db = new DbConnect();
        StaffAppointment Sa = new StaffAppointment();
        public TakeAppointment()
        {
            InitializeComponent();
        }

        private void SearchRecord_Click(object sender, EventArgs e)
        {

            if (int.TryParse(DoctorSearchInput.Text, out int doctorIdToSearch))
            {
                DataTable result = Sa.SearchById(doctorIdToSearch);

                if (result.Rows.Count > 0)
                {
                    InputsDisplay(true);

                    Pname.Text = result.Rows[0]["name"].ToString();
                    Pcontact.Text = result.Rows[0]["contact_number"].ToString();
                    cmbGender.Text = result.Rows[0]["gender"].ToString();


                }
                else
                {
                    // No record found for the given ID
                    MessageBox.Show("No record found for the specified ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the Patient ID.");
            }
        }
        public void InputsDisplay(bool show)
        {
            Pname.Enabled = show;
            Pcontact.Enabled = show;
            cmbGender.Enabled = show;


        }

        private void TakeAppointment_Load(object sender, EventArgs e)
        {
            fetchDoctorRecord();
        }
        public void fetchDoctorRecord()
        {

            try
            {
                MySqlConnection connection = db.MakeConnection();
                string sql = "SELECT * FROM doctors";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.Columns.Remove("password");
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Addrecordbtn_Click(object sender, EventArgs e)
        {
            Sa.InsertRecord(DoctorSearchInput.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), DocId.Text);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            


                if (e.RowIndex >= 0) // Check if a valid row is clicked (not the header)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];


                    DocId.Text = selectedRow.Cells["doctor_id"].Value.ToString();
                    Docname.Text = selectedRow.Cells["name"].Value.ToString();
                    DocSpeciliazation.Text = selectedRow.Cells["specialization"].Value.ToString();


                }
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Al-Shifa Hospital", new Font("Arial", 40, FontStyle.Regular), Brushes.Black, new Point(250, 20));
            e.Graphics.DrawString("Where Care Meets Excellence.", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(280, 90));
            e.Graphics.DrawString("Patient Name: ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(80, 200));
            e.Graphics.DrawString(Pname.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(350, 200));
            e.Graphics.DrawString("Contact Number: ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(80, 250));
            e.Graphics.DrawString(Pcontact.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(350, 250));
            e.Graphics.DrawString("Gender: ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(80, 300));
            e.Graphics.DrawString(cmbGender.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(350, 300));
            e.Graphics.DrawString("Doctor Name: ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(80, 350));
            e.Graphics.DrawString(Docname.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(350, 350));
            e.Graphics.DrawString("Appointment Date: ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(80, 400));
            e.Graphics.DrawString(dateTimePicker1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(350, 400));
            e.Graphics.DrawString("Patient ID: ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(80, 500));
            e.Graphics.DrawString(DoctorSearchInput.Text, new Font("Arial", 60, FontStyle.Regular), Brushes.Black, new Point(350, 550));
        }
    }
}
