namespace WindowsFormsApp1
{
    partial class TakeAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeAppointment));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchRecord = new System.Windows.Forms.Button();
            this.DoctorSearchInput = new System.Windows.Forms.TextBox();
            this.Patientid = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.Addrecordbtn = new System.Windows.Forms.Button();
            this.DocId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DocSpeciliazation = new System.Windows.Forms.TextBox();
            this.Docname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pcontact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 523);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(397, 364);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // SearchRecord
            // 
            this.SearchRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchRecord.ForeColor = System.Drawing.Color.White;
            this.SearchRecord.Location = new System.Drawing.Point(586, 67);
            this.SearchRecord.Name = "SearchRecord";
            this.SearchRecord.Size = new System.Drawing.Size(121, 47);
            this.SearchRecord.TabIndex = 59;
            this.SearchRecord.Text = "Search";
            this.SearchRecord.UseVisualStyleBackColor = false;
            this.SearchRecord.Click += new System.EventHandler(this.SearchRecord_Click);
            // 
            // DoctorSearchInput
            // 
            this.DoctorSearchInput.Location = new System.Drawing.Point(367, 77);
            this.DoctorSearchInput.Name = "DoctorSearchInput";
            this.DoctorSearchInput.Size = new System.Drawing.Size(195, 26);
            this.DoctorSearchInput.TabIndex = 58;
            // 
            // Patientid
            // 
            this.Patientid.AutoSize = true;
            this.Patientid.Location = new System.Drawing.Point(251, 80);
            this.Patientid.Name = "Patientid";
            this.Patientid.Size = new System.Drawing.Size(80, 20);
            this.Patientid.TabIndex = 57;
            this.Patientid.Text = "Patient ID";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(607, 269);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(195, 28);
            this.cmbGender.TabIndex = 56;
            // 
            // Addrecordbtn
            // 
            this.Addrecordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.Addrecordbtn.ForeColor = System.Drawing.Color.White;
            this.Addrecordbtn.Location = new System.Drawing.Point(576, 572);
            this.Addrecordbtn.Name = "Addrecordbtn";
            this.Addrecordbtn.Size = new System.Drawing.Size(235, 68);
            this.Addrecordbtn.TabIndex = 55;
            this.Addrecordbtn.Text = "Add Record";
            this.Addrecordbtn.UseVisualStyleBackColor = false;
            this.Addrecordbtn.Click += new System.EventHandler(this.Addrecordbtn_Click);
            // 
            // DocId
            // 
            this.DocId.Location = new System.Drawing.Point(607, 338);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(195, 26);
            this.DocId.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Doctor Id";
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(607, 130);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(195, 26);
            this.Pname.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Patient Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Gender";
            // 
            // DocSpeciliazation
            // 
            this.DocSpeciliazation.Location = new System.Drawing.Point(607, 471);
            this.DocSpeciliazation.Name = "DocSpeciliazation";
            this.DocSpeciliazation.Size = new System.Drawing.Size(195, 26);
            this.DocSpeciliazation.TabIndex = 52;
            // 
            // Docname
            // 
            this.Docname.Location = new System.Drawing.Point(607, 405);
            this.Docname.Name = "Docname";
            this.Docname.Size = new System.Drawing.Size(195, 26);
            this.Docname.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Appoint Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Specilization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Doctor Name";
            // 
            // Pcontact
            // 
            this.Pcontact.Location = new System.Drawing.Point(607, 197);
            this.Pcontact.Name = "Pcontact";
            this.Pcontact.Size = new System.Drawing.Size(195, 26);
            this.Pcontact.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Contact No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 60);
            this.label1.TabIndex = 42;
            this.label1.Text = "Appointment";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 730);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchRecord);
            this.Controls.Add(this.DoctorSearchInput);
            this.Controls.Add(this.Patientid);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.Addrecordbtn);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DocSpeciliazation);
            this.Controls.Add(this.Docname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pcontact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakeAppointment";
            this.Text = "TakeAppointment";
            this.Load += new System.EventHandler(this.TakeAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchRecord;
        private System.Windows.Forms.TextBox DoctorSearchInput;
        private System.Windows.Forms.Label Patientid;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button Addrecordbtn;
        private System.Windows.Forms.TextBox DocId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DocSpeciliazation;
        private System.Windows.Forms.TextBox Docname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pcontact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}