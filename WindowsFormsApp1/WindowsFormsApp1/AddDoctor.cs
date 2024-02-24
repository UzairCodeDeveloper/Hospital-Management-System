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
    public partial class AddDoctor : Form
    {
        AdminDoctor ad=new AdminDoctor();
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
        }

        private void Addrecordbtn_Click(object sender, EventArgs e)
        {
            if(NameInput.Text=="" ||
                AgeInput.Text=="" ||
                cmbGender.Text == "" ||
                EmailInput.Text == "" ||
                SpInput.Text == "" ||
                CnInput.Text == "" ||
                WhInput.Text == "" ||
               pwdInput.Text == "" )
            {
                MessageBox.Show("Please fill all Credentials");
            }
            else
            {
                ad.InsertRecord(
                NameInput.Text,
                AgeInput.Text,
                cmbGender.Text,
                EmailInput.Text,
                SpInput.Text,
                CnInput.Text,
                WhInput.Text,
               pwdInput.Text);
            }
            
        }
    }
}
