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
    public partial class doctorSchedule : Form
    {
        DbConnect db = new DbConnect();
        public doctorSchedule()
        {
            InitializeComponent();
        }

        private void doctorSchedule_Load(object sender, EventArgs e)
        {
            fetchDoctorRecord();
        }
        public void fetchDoctorRecord()
        {

            try
            {
                MySqlConnection connection = db.MakeConnection();
                string sql = "SELECT * FROM doctors";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.Columns.Remove("password");
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                DoctorGrid.DataSource = bindingSource;

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DoctorGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
