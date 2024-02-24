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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            fom docRecord=new fom();
            docRecord.TopLevel = false;
            displayPanel.Controls.Add(docRecord);
            docRecord.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            Dashboard dboard = new Dashboard(); 
            dboard.TopLevel = false;
            displayPanel.Controls.Add(dboard);
            dboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            StaffRecord nurse = new StaffRecord();
            nurse.TopLevel = false;
            displayPanel.Controls.Add(nurse);
            nurse.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            MedicineRecord medicineRecord = new MedicineRecord();
            medicineRecord.TopLevel = false;
            displayPanel.Controls.Add(medicineRecord);
            medicineRecord.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            WardroomRecord wardroom = new WardroomRecord();
            wardroom.TopLevel = false;
            displayPanel.Controls.Add(wardroom);
            wardroom.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
