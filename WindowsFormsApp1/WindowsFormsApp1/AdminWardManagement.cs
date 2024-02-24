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
    public partial class AdminWardManagement : Form
    {
        AdminWard AW = new AdminWard();
        public AdminWardManagement()
        {
            InitializeComponent();
        }

        private void AdminWardManagement_Load(object sender, EventArgs e)
        {
            InputsDisplay(false);
        }

        public void InputsDisplay(bool show)
        {
            wardId.Enabled=show;
            Wardcapacity.Enabled = show;
            Wardname.Enabled = show;
            Wardincharge.Enabled = show;
           
        }

        private void SearchRecord_Click(object sender, EventArgs e)
        {

            if (int.TryParse(WardSearchInput.Text, out int doctorIdToSearch))
            {
                DataTable result = AW.SearchById(doctorIdToSearch);

                if (result.Rows.Count > 0)
                {
                    InputsDisplay(true);

                    wardId.Text = result.Rows[0]["ward_number"].ToString();
                    Wardname.Text = result.Rows[0]["ward_name"].ToString();
                    Wardcapacity.Text = result.Rows[0]["capacity"].ToString();
                    Wardincharge.Text = result.Rows[0]["wardIncharge"].ToString();
                    
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

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (AW.DeleteById(int.Parse(wardId.Text)))
                {
                    wardId.Text = "";
                    Wardname.Text = "";
                    Wardcapacity.Text = "";
                    Wardincharge.Text = "";
                    
                    InputsDisplay(false);
                }
            }
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            AW.UpdateRecord(
                int.Parse(wardId.Text),
                Wardname.Text,
                Wardcapacity.Text,
                Wardincharge.Text
                );

            Wardname.Text = "";
            Wardcapacity.Text = "";
            Wardincharge.Text = "";
            wardId.Text = "";
            InputsDisplay(false);
        }
    }
}
