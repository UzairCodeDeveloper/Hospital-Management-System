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
    public partial class AddMedicine : Form
    {
        AdminMedicine AM = new AdminMedicine();
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (
                          MName.Text == "" ||
                          Edtp.Text == "" ||
                          MCompany.Text == "" ||
                          MContact.Text == "" ||
                          costInput.Text == "" ||
                          lable2.Text == "" ||
                          DiseaseType.Text == ""
                          )
            {
                MessageBox.Show("Please fill all Credentials");
            }
            else
            {
                AM.InsertRecord(
                MName.Text,
                Edtp.Value.ToString("yyyy-MM-dd"),
                MCompany.Text,
                MContact.Text
                , costInput.Text,
                lable2.Text,
                DiseaseType.Text
                    );
            }
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
           /* MessageBox.Show(Edtp.Value.ToString("yyyy-MM-dd"));*/
        }
    }
}
