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
    public partial class AdminStaffManagement : Form
    {
        AdminStaff AS =new AdminStaff();
        public AdminStaffManagement()
        {
            InitializeComponent();
        }

        private void AdminStaffManagement_Load(object sender, EventArgs e)
        {
            InputsDisplay(false);
        }




        private void SearchRecord_Click(object sender, EventArgs e)
        {

            if (int.TryParse(StaffInputSearch.Text, out int doctorIdToSearch))
            {
                DataTable result = AS.SearchById(doctorIdToSearch);

                if (result.Rows.Count > 0)
                {
                    InputsDisplay(true);

                    IdInput.Text = result.Rows[0]["staff_id"].ToString();
                    NameInput.Text = result.Rows[0]["Name"].ToString();
                    AgeInput.Text = result.Rows[0]["Age"].ToString();
                    cmbGender.Text = result.Rows[0]["Gender"].ToString();
                    EmailInput.Text = result.Rows[0]["email"].ToString();
                    AddressInput.Text = result.Rows[0]["Address"].ToString();
                    cmbRole.Text = result.Rows[0]["position"].ToString();
                    pwdInput.Text = result.Rows[0]["password"].ToString();
                    ContactInput.Text = result.Rows[0]["contact_number"].ToString();
                    cmbShift.Text = result.Rows[0]["Shift"].ToString();
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

        public void InputsDisplay(bool show)
        {
            IdInput.Enabled = show;
            NameInput.Enabled = show;
            AgeInput.Enabled = show;
            EmailInput.Enabled = show;
            cmbShift.Enabled = show;
            cmbRole.Enabled = show;
            pwdInput.Enabled = show;
            ContactInput.Enabled = show;
            cmbGender.Enabled = show;
            AddressInput.Enabled = show;
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (AS.DeleteById(int.Parse(IdInput.Text)))
                {
                    IdInput.Text = "";
                    NameInput.Text = "";
                    AgeInput.Text = "";
                    cmbGender.Text = "";
                    EmailInput.Text = "";
                    cmbShift.Text = "";
                    cmbRole.Text = "";
                    pwdInput.Text = "";
                    ContactInput.Text = "";
                    StaffInputSearch.Text = "";
                    InputsDisplay(false);
                }
            }
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            AS.UpdateRecord(
                int.Parse(IdInput.Text),
                NameInput.Text, AgeInput.Text,
                ContactInput.Text,
                cmbRole.Text,
                cmbGender.Text,
                EmailInput.Text,
                pwdInput.Text,
                
                cmbShift.Text,
                AddressInput.Text
                );

            IdInput.Text = "";
            NameInput.Text = "";
            AgeInput.Text = "";
            cmbGender.Text = "";
            EmailInput.Text = "";
            cmbShift.Text = "";
            cmbRole.Text = "";
            pwdInput.Text = "";
            ContactInput.Text = "";
            StaffInputSearch.Text = "";
            cmbShift.Text = "";
            AddressInput.Text = "";
            InputsDisplay(false);
        }
    }
}
