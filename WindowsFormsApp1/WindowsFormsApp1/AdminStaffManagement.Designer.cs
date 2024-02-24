﻿namespace WindowsFormsApp1
{
    partial class AdminStaffManagement
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
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pwdInput = new System.Windows.Forms.TextBox();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchRecord = new System.Windows.Forms.Button();
            this.StaffInputSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.UpdateRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "Morning ",
            "Night"});
            this.cmbShift.Location = new System.Drawing.Point(151, 509);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(195, 28);
            this.cmbShift.TabIndex = 72;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(573, 376);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(195, 28);
            this.cmbGender.TabIndex = 71;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Nurse",
            "Receptionist",
            "Cleaner"});
            this.cmbRole.Location = new System.Drawing.Point(151, 376);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(195, 28);
            this.cmbRole.TabIndex = 70;
            // 
            // AgeInput
            // 
            this.AgeInput.Location = new System.Drawing.Point(573, 231);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(195, 26);
            this.AgeInput.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Age";
            // 
            // ContactInput
            // 
            this.ContactInput.Location = new System.Drawing.Point(573, 305);
            this.ContactInput.Name = "ContactInput";
            this.ContactInput.Size = new System.Drawing.Size(195, 26);
            this.ContactInput.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Contact No";
            // 
            // pwdInput
            // 
            this.pwdInput.Location = new System.Drawing.Point(573, 436);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.Size = new System.Drawing.Size(195, 26);
            this.pwdInput.TabIndex = 63;
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(573, 509);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(195, 26);
            this.AddressInput.TabIndex = 64;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(152, 439);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(195, 26);
            this.EmailInput.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Shift";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Role";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(151, 308);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(195, 26);
            this.NameInput.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Name";
            // 
            // IdInput
            // 
            this.IdInput.Enabled = false;
            this.IdInput.Location = new System.Drawing.Point(151, 231);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(195, 26);
            this.IdInput.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 60);
            this.label1.TabIndex = 51;
            this.label1.Text = "Staff Management";
            // 
            // SearchRecord
            // 
            this.SearchRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchRecord.ForeColor = System.Drawing.Color.White;
            this.SearchRecord.Location = new System.Drawing.Point(529, 119);
            this.SearchRecord.Name = "SearchRecord";
            this.SearchRecord.Size = new System.Drawing.Size(121, 47);
            this.SearchRecord.TabIndex = 75;
            this.SearchRecord.Text = "Search";
            this.SearchRecord.UseVisualStyleBackColor = false;
            this.SearchRecord.Click += new System.EventHandler(this.SearchRecord_Click);
            // 
            // StaffInputSearch
            // 
            this.StaffInputSearch.Location = new System.Drawing.Point(310, 129);
            this.StaffInputSearch.Name = "StaffInputSearch";
            this.StaffInputSearch.Size = new System.Drawing.Size(195, 26);
            this.StaffInputSearch.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 73;
            this.label12.Text = "Staff ID";
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.Red;
            this.DeleteRecord.ForeColor = System.Drawing.Color.White;
            this.DeleteRecord.Location = new System.Drawing.Point(464, 611);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(158, 68);
            this.DeleteRecord.TabIndex = 76;
            this.DeleteRecord.Text = "Delete";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateRecord.ForeColor = System.Drawing.Color.White;
            this.UpdateRecord.Location = new System.Drawing.Point(183, 611);
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(183, 68);
            this.UpdateRecord.TabIndex = 77;
            this.UpdateRecord.Text = "Update";
            this.UpdateRecord.UseVisualStyleBackColor = false;
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // AdminStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 728);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.UpdateRecord);
            this.Controls.Add(this.SearchRecord);
            this.Controls.Add(this.StaffInputSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.AgeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContactInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pwdInput);
            this.Controls.Add(this.AddressInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminStaffManagement";
            this.Text = "AdminStaffManagement";
            this.Load += new System.EventHandler(this.AdminStaffManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContactInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pwdInput;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchRecord;
        private System.Windows.Forms.TextBox StaffInputSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Button UpdateRecord;
    }
}