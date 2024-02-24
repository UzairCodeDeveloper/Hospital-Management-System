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
    public partial class StaffRecord : Form
    {
        DbConnect db =new DbConnect();
        public StaffRecord()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddStaff staff = new AddStaff();
            staff.Show();
        }

        private void NurseRecord_Load(object sender, EventArgs e)
        {
            fetchRecord();
        }
        public void fetchRecord() {
            
            try
            {
                MySqlConnection connection = db.MakeConnection();
                string sql = "SELECT * FROM staff";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridViewNurse.DataSource = bindingSource;

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminStaffManagement adminStaffManagement = new AdminStaffManagement();
            adminStaffManagement.Show();
        }
    }
}
