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
    public partial class WardroomRecord : Form
    {
        DbConnect db = new DbConnect();
        public WardroomRecord()
        {
            InitializeComponent();
        }

        private void WardroomRecord_Load(object sender, EventArgs e)
        {
            fetchRecord();
        }

        public void fetchRecord()
        {

            try
            {
                MySqlConnection connection = db.MakeConnection();
                string sql = "SELECT * FROM wards";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridViewWard.DataSource = bindingSource;

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWard addWard = new AddWard();
            addWard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminWardManagement adminWardManagement = new AdminWardManagement();    
            adminWardManagement.Show(); 
        }
    }
}
