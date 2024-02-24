using Google.Protobuf.WellKnownTypes;
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
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            Appointments appointmentRecord = new Appointments();
            appointmentRecord.TopLevel = false;
            displayPanel.Controls.Add(appointmentRecord);
            appointmentRecord.currDoc.Text = loginAsDoctor.Text.ToString();
            appointmentRecord.Show();
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            CheckPatients patientsRecord = new CheckPatients();
            patientsRecord.TopLevel = false;
            displayPanel.Controls.Add(patientsRecord);
            patientsRecord.currDoc.Text = loginAsDoctor.Text.ToString();
            patientsRecord.Show();
            patientsRecord.check_doctor_dept();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            PatientRecord patientsRecord = new PatientRecord();
            patientsRecord.TopLevel = false;
            displayPanel.Controls.Add(patientsRecord);
            patientsRecord.currDoc.Text = loginAsDoctor.Text.ToString();
            patientsRecord.Show();
        }

        public void loginAsDoctor_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HMS objMainWindow = new HMS();
            objMainWindow.Show();
            this.Close();
        }
    }
}
