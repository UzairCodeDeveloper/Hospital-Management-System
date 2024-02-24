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
    public partial class AdminMedManagement : Form
    {
        AdminMedicine AM =new AdminMedicine();
        public AdminMedManagement()
        {
            InitializeComponent();
        }

        private void AdminMedManagement_Load(object sender, EventArgs e)
        {
            InputsDisplay(false);
        }

        private void SearchRecord_Click(object sender, EventArgs e)
        {
            if (int.TryParse(MedInputSearch.Text, out int doctorIdToSearch))
            {
                DataTable result = AM.SearchById(doctorIdToSearch);

                if (result.Rows.Count > 0)
                {
                    InputsDisplay(true);

                    MId.Text = result.Rows[0]["medicine_id"].ToString();
                    MName.Text = result.Rows[0]["Medicine_Name"].ToString();
                    MCompany.Text = result.Rows[0]["Company_Name"].ToString();
                    MContact.Text = result.Rows[0]["Company_Contact"].ToString();
                    Edtp.Text = result.Rows[0]["Expire_Date"].ToString();
                    costInput.Text = result.Rows[0]["Cost"].ToString();
                   
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
            MId.Enabled = show;
            MName.Enabled = show;
            MCompany.Enabled = show;
            MContact.Enabled = show;
            Edtp.Enabled = show;
            costInput.Enabled = show;
           
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (AM.DeleteById(int.Parse(MId.Text)))
                {
                    MId.Text = "";
                    MName.Text = "";
                    MCompany.Text = "";
                    MContact.Text = "";
                    Edtp.Text = "";
                    costInput.Text = "";
                    
                    InputsDisplay(false);
                }
            }
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            AM.UpdateRecord(
                int.Parse(MId.Text),
                MName.Text,
                MCompany.Text,
                MContact.Text,
                Edtp.Value.ToString("yyyy-MM-dd"),
                costInput.Text
                );

            MId.Text = "";
            MName.Text = "";
            MCompany.Text = "";
            MContact.Text = "";
            Edtp.Text = "";
            costInput.Text = "";
            
            InputsDisplay(false);
        }
    }
}
