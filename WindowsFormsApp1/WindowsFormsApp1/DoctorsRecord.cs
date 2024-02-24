using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Queries;

namespace WindowsFormsApp1
{
    
    public partial class fom : Form
    {
        DbConnect db =new DbConnect();
        public fom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsRecord_Load(object sender, EventArgs e)
        {
            fetchDoctorRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDocManagement ADM= new AdminDocManagement();
            ADM.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void fetchDoctorRecord()
        {
            
            try {
                MySqlConnection connection = db.MakeConnection();
                string sql = "SELECT * FROM doctors";
                MySqlCommand cmd= new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.Columns.Remove("password");
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridviewDoctor.DataSource = bindingSource;
                
                db.CloseConnection();   
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridviewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
