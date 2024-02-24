using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Queries;

namespace WindowsFormsApp1
{
    public partial class AddWard : Form
    { 
       AdminWard AW = new AdminWard();

        public AddWard()
        {
            InitializeComponent();
        }

        private void AddREcord_Click(object sender, EventArgs e)
        {
            if (
               Wardname.Text == "" ||
               Wardcapacity.Text == "" ||
               Wardincharge.Text == ""
              
               )
            {
                MessageBox.Show("Please fill all Credentials");
            }
            else
            {
                AW.InsertRecord(
                Wardname.Text,
                Wardcapacity.Text,
                Wardincharge.Text
                
                    );
            }
        }

        private void AddWard_Load(object sender, EventArgs e)
        {

        }
    }
}
