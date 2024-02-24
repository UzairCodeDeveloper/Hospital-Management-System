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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {

        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            AddPatient addpatient = new AddPatient();
            addpatient.TopLevel = false;
            displayPanel.Controls.Add(addpatient);
            addpatient.Show();
        }

        private void DoctorSchedule_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            doctorSchedule ds = new doctorSchedule();
            ds.TopLevel = false;
            displayPanel.Controls.Add(ds);
            ds.Show();
        }

        private void Takeappointment_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            TakeAppointment Tappointment = new TakeAppointment();
            Tappointment.TopLevel = false;
            displayPanel.Controls.Add(Tappointment);
            Tappointment.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            AppointmentStatus Aps = new AppointmentStatus();
            Aps.TopLevel = false;
            displayPanel.Controls.Add(Aps);
            Aps.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
