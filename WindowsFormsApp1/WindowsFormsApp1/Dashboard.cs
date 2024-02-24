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
    public partial class Dashboard : Form
    {

        DbConnect db = new DbConnect();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = db.MakeConnection();

            try
            {
                string[] tables = { "doctors", "wards", "staff", "medicines" };
                Label[] labels = { doctorCount, wardCount, staffCount, medicineCount };

                for (int i = 0; i < tables.Length; i++)
                {
                    string sqlQuery = $"SELECT COUNT(*) AS TotalRecords FROM {tables[i]}";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int totalRecords = Convert.ToInt32(result);
                        labels[i].Text = Convert.ToString(totalRecords);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
