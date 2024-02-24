namespace WindowsFormsApp1
{
    partial class AdminDocManagement
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
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.UpdateRecord = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WhInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pwdInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CnInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.DoctorSearchInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(572, 325);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(195, 28);
            this.cmbGender.TabIndex = 25;
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateRecord.ForeColor = System.Drawing.Color.White;
            this.UpdateRecord.Location = new System.Drawing.Point(162, 614);
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(183, 68);
            this.UpdateRecord.TabIndex = 24;
            this.UpdateRecord.Text = "Update";
            this.UpdateRecord.UseVisualStyleBackColor = false;
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(572, 254);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(195, 26);
            this.NameInput.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // SpInput
            // 
            this.SpInput.Location = new System.Drawing.Point(572, 398);
            this.SpInput.Name = "SpInput";
            this.SpInput.Size = new System.Drawing.Size(195, 26);
            this.SpInput.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Specialization";
            // 
            // WhInput
            // 
            this.WhInput.Location = new System.Drawing.Point(572, 471);
            this.WhInput.Name = "WhInput";
            this.WhInput.Size = new System.Drawing.Size(195, 26);
            this.WhInput.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Working Hours";
            // 
            // pwdInput
            // 
            this.pwdInput.Location = new System.Drawing.Point(150, 526);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.Size = new System.Drawing.Size(195, 26);
            this.pwdInput.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 532);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Password";
            // 
            // CnInput
            // 
            this.CnInput.Location = new System.Drawing.Point(150, 471);
            this.CnInput.Name = "CnInput";
            this.CnInput.Size = new System.Drawing.Size(195, 26);
            this.CnInput.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contact No";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(150, 395);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(195, 26);
            this.EmailInput.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // AgeInput
            // 
            this.AgeInput.Location = new System.Drawing.Point(150, 331);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(195, 26);
            this.AgeInput.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // doctorId
            // 
            this.doctorId.Enabled = false;
            this.doctorId.Location = new System.Drawing.Point(150, 254);
            this.doctorId.Name = "doctorId";
            this.doctorId.Size = new System.Drawing.Size(195, 26);
            this.doctorId.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doctor Data Management";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Doctor ID";
            // 
            // SearchRecord
            // 
            this.SearchRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchRecord.ForeColor = System.Drawing.Color.White;
            this.SearchRecord.Location = new System.Drawing.Point(536, 147);
            this.SearchRecord.Name = "SearchRecord";
            this.SearchRecord.Size = new System.Drawing.Size(121, 47);
            this.SearchRecord.TabIndex = 24;
            this.SearchRecord.Text = "Search";
            this.SearchRecord.UseVisualStyleBackColor = false;
            this.SearchRecord.Click += new System.EventHandler(this.SearchRecord_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.Red;
            this.DeleteRecord.ForeColor = System.Drawing.Color.White;
            this.DeleteRecord.Location = new System.Drawing.Point(443, 614);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(158, 68);
            this.DeleteRecord.TabIndex = 24;
            this.DeleteRecord.Text = "Delete";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoctorSearchInput
            // 
            this.DoctorSearchInput.Location = new System.Drawing.Point(317, 157);
            this.DoctorSearchInput.Name = "DoctorSearchInput";
            this.DoctorSearchInput.Size = new System.Drawing.Size(195, 26);
            this.DoctorSearchInput.TabIndex = 22;
            this.DoctorSearchInput.TextChanged += new System.EventHandler(this.DoctorSearchInput_TextChanged);
            // 
            // AdminDocManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 727);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.SearchRecord);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.UpdateRecord);
            this.Controls.Add(this.DoctorSearchInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WhInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pwdInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CnInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgeInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.doctorId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminDocManagement";
            this.Text = "AdminDocManipulate";
            this.Load += new System.EventHandler(this.AdminDocManipulate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button UpdateRecord;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SpInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WhInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pwdInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CnInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doctorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SearchRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.TextBox DoctorSearchInput;
    }
}