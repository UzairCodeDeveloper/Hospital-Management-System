namespace WindowsFormsApp1
{
    partial class AddPatient
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.Addrecordbtn = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CnInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(574, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(157, 273);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(195, 28);
            this.cmbGender.TabIndex = 35;
            // 
            // Addrecordbtn
            // 
            this.Addrecordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.Addrecordbtn.ForeColor = System.Drawing.Color.White;
            this.Addrecordbtn.Location = new System.Drawing.Point(305, 361);
            this.Addrecordbtn.Name = "Addrecordbtn";
            this.Addrecordbtn.Size = new System.Drawing.Size(235, 68);
            this.Addrecordbtn.TabIndex = 34;
            this.Addrecordbtn.Text = "Add Record";
            this.Addrecordbtn.UseVisualStyleBackColor = false;
            this.Addrecordbtn.Click += new System.EventHandler(this.Addrecordbtn_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(574, 136);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(195, 26);
            this.NameInput.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gender";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(574, 201);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(195, 26);
            this.Address.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Address";
            // 
            // CnInput
            // 
            this.CnInput.Location = new System.Drawing.Point(157, 198);
            this.CnInput.Name = "CnInput";
            this.CnInput.Size = new System.Drawing.Size(195, 26);
            this.CnInput.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contact No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 60);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add Patient";
            // 
            // P_ID
            // 
            this.P_ID.Enabled = false;
            this.P_ID.Location = new System.Drawing.Point(152, 136);
            this.P_ID.Name = "P_ID";
            this.P_ID.Size = new System.Drawing.Size(200, 26);
            this.P_ID.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 730);
            this.Controls.Add(this.P_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.Addrecordbtn);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CnInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button Addrecordbtn;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CnInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox P_ID;
        private System.Windows.Forms.Label label2;
    }
}