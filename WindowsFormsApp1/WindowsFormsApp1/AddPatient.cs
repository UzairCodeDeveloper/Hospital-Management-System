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
using WindowsFormsApp1.Queries;

namespace WindowsFormsApp1
{
    public partial class AddPatient : Form
    {
        StaffPatient sp = new StaffPatient();
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT COUNT(*) AS TotalRecords FROM patients";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int totalRecords = Convert.ToInt32(result) + 1;
                    P_ID.Text = Convert.ToString(totalRecords);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Addrecordbtn_Click(object sender, EventArgs e)
        {
            if (NameInput.Text == "" || cmbGender.Text == "" || dateTimePicker1.Value.ToString() == "" || CnInput.Text == "" || Address.Text == "")
            {
                MessageBox.Show("Please fill all Credentials");
            }
            else
            {
                sp.InsertRecord(NameInput.Text, cmbGender.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), CnInput.Text, Address.Text);
            }

        }
    }
}
