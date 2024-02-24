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

namespace WindowsFormsApp1
{
    public partial class AdminDocManagement : Form
    {
       AdminDoctor AD =new AdminDoctor();
        public AdminDocManagement()
        {
            InitializeComponent();
        }

        private void AdminDocManipulate_Load(object sender, EventArgs e)
        {
            InputsDisplay(false);
        }

        private void SearchRecord_Click(object sender, EventArgs e)
        {

            if (int.TryParse(DoctorSearchInput.Text, out int doctorIdToSearch))
            {
                DataTable result = AD.SearchById(doctorIdToSearch);

                if (result.Rows.Count > 0)
                {
                    InputsDisplay(true);
                    
                    doctorId.Text= result.Rows[0]["doctor_id"].ToString();
                    NameInput.Text = result.Rows[0]["Name"].ToString();
                    AgeInput.Text = result.Rows[0]["Age"].ToString();
                    cmbGender.Text = result.Rows[0]["Gender"].ToString();
                    EmailInput.Text = result.Rows[0]["email"].ToString();
                    SpInput.Text = result.Rows[0]["specialization"].ToString();
                    WhInput.Text = result.Rows[0]["WorkingHours"].ToString();
                    pwdInput.Text = result.Rows[0]["password"].ToString();
                    CnInput.Text = result.Rows[0]["contact_number"].ToString();
                }
                else
                {
                    // No record found for the given ID
                    MessageBox.Show("No record found for the specified ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the Doctor ID.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
              if(AD.DeleteById(int.Parse(doctorId.Text)))
                {
                    doctorId.Text ="";
                    NameInput.Text ="";
                    AgeInput.Text = "";
                    cmbGender.Text = "";
                    EmailInput.Text = "";
                    SpInput.Text = "";
                    WhInput.Text = "";
                    pwdInput.Text = "";
                    CnInput.Text = "";
                    InputsDisplay(false);
                }
            }
        }


        public void InputsDisplay(bool show)
        {
            NameInput.Enabled = show;
            AgeInput.Enabled  = show;
            EmailInput.Enabled = show;
            SpInput.Enabled = show;
            WhInput.Enabled = show;
            pwdInput.Enabled = show;
            CnInput .Enabled = show;
            cmbGender.Enabled = show;
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            AD.UpdateRecord(
            int.Parse(doctorId.Text),
            NameInput.Text,
            AgeInput.Text,
            cmbGender.Text,
            EmailInput.Text,
            SpInput.Text,
            WhInput.Text,
            pwdInput.Text,
            CnInput.Text);
        }

        private void DoctorSearchInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
