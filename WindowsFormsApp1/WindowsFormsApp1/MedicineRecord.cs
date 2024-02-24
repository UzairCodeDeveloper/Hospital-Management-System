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

namespace WindowsFormsApp1
{
    public partial class MedicineRecord : Form
    {
        public MedicineRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMedicine medicine = new AddMedicine();
            medicine.Show();
        }

        private void MedicineRecord_Load(object sender, EventArgs e)
        {
            fetchRecord();
        }
        public void fetchRecord()
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=hms";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "SELECT * FROM medicines";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridViewMedicine.DataSource = bindingSource;

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMedManagement adminMedManagement = new AdminMedManagement();   
            adminMedManagement.Show();
        }

        private void dataGridViewMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
