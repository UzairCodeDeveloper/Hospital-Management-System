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
    public partial class AppointmentStatus : Form
    {
        DbConnect db = new DbConnect();
        public AppointmentStatus()
        {
            InitializeComponent();
        }

        private void AppointmentStatus_Load(object sender, EventArgs e)
        {
            fetchRecord();
        }
        public void fetchRecord()
        {

            try
            {
                MySqlConnection connection = db.MakeConnection();
                string sql = "SELECT * FROM appointments";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                AppointmentGrid.DataSource = bindingSource;

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
