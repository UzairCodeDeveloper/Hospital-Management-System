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
    public partial class AddStaff : Form
    {
        AdminStaff aS =new AdminStaff();
        public AddStaff()
        {
            InitializeComponent();
        }


        private void AddStaff_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT COUNT(*) AS TotalRecords FROM staff";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int totalRecords = Convert.ToInt32(result) + 1;
                    IdInput.Text = Convert.ToString(totalRecords);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NameInput.Text==""|| AgeInput.Text=="" ||
                ContactInput.Text=="" || cmbRole.Text==""
                || cmbGender.Text=="" || EmailInput.Text==""||
                pwdInput.Text==""|| cmbShift.Text==""||AddressInput.Text=="")
            {
                MessageBox.Show("Please fill all Credentials");
            }
            else
            {
               aS.InsertRecord(NameInput.Text, AgeInput.Text,
                ContactInput.Text, cmbRole.Text,
                cmbGender.Text, EmailInput.Text,
               pwdInput.Text,cmbShift.Text,AddressInput.Text);
            }
        }
    }
}
