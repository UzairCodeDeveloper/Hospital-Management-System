namespace WindowsFormsApp1
{
    partial class AddStaff
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
            this.button1 = new System.Windows.Forms.Button();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pwdInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(298, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 68);
            this.button1.TabIndex = 49;
            this.button1.Text = "Add Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgeInput
            // 
            this.AgeInput.Location = new System.Drawing.Point(577, 125);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(195, 26);
            this.AgeInput.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Age";
            // 
            // ContactInput
            // 
            this.ContactInput.Location = new System.Drawing.Point(577, 199);
            this.ContactInput.Name = "ContactInput";
            this.ContactInput.Size = new System.Drawing.Size(195, 26);
            this.ContactInput.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Contact No";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(156, 333);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(195, 26);
            this.EmailInput.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Role";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(155, 202);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(195, 26);
            this.NameInput.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Name";
            // 
            // IdInput
            // 
            this.IdInput.Enabled = false;
            this.IdInput.Location = new System.Drawing.Point(155, 125);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(195, 26);
            this.IdInput.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 60);
            this.label1.TabIndex = 36;
            this.label1.Text = "Add Staff";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Nurse",
            "Receptionist",
            "Cleaner"});
            this.cmbRole.Location = new System.Drawing.Point(155, 270);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(195, 28);
            this.cmbRole.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(577, 270);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(195, 28);
            this.cmbGender.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Password";
            // 
            // pwdInput
            // 
            this.pwdInput.Location = new System.Drawing.Point(577, 330);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.Size = new System.Drawing.Size(195, 26);
            this.pwdInput.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Shift";
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "Morning ",
            "Night"});
            this.cmbShift.Location = new System.Drawing.Point(155, 403);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(195, 28);
            this.cmbShift.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(444, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Address";
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(577, 403);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(195, 26);
            this.AddressInput.TabIndex = 43;
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.button1);
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
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContactInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pwdInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddressInput;
    }
}