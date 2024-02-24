using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Queries;

namespace WindowsFormsApp1
{
    public partial class HMS : Form
    {
        public HMS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(cmbSelection.Text=="" || usernameInput.Text=="" || pwdInput.Text == "")
            {
                MessageBox.Show("Please Fill All Credentials");
            }
            else
            {
                Login login = new Login();
                bool result = login.checkLogin(cmbSelection.Text, usernameInput.Text, pwdInput.Text);
                if (result)
                {
                    MessageBox.Show("Logged In Successfully");
                    this.Hide();
                    if (cmbSelection.Text == "Administrator")
                    {
                        Administrator administrator = new Administrator();
                        administrator.ShowDialog();
                    }
                    else if (cmbSelection.Text == "Doctor") {
                        DoctorDashboard doctor = new DoctorDashboard();
                        doctor.loginAsDoctor.Text = usernameInput.Text;
                        doctor.ShowDialog();
                    }
                    else if (cmbSelection.Text == "Staff")
                    {
                        StaffDashboard staff = new StaffDashboard();
                        staff.ShowDialog();
                    }


                }
                else
                {
                    MessageBox.Show("UserID or Password Doesn't Match");
                }
            }
            
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HMS_Load(object sender, EventArgs e)
        {

        }
    }
}
