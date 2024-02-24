namespace WindowsFormsApp1
{
    partial class AddDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CnInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WhInput = new System.Windows.Forms.TextBox();
            this.Addrecordbtn = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pwdInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(139, 131);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(195, 26);
            this.NameInput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AgeInput
            // 
            this.AgeInput.Location = new System.Drawing.Point(139, 204);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(195, 26);
            this.AgeInput.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(561, 131);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(195, 26);
            this.EmailInput.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Specialization";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // SpInput
            // 
            this.SpInput.Location = new System.Drawing.Point(561, 271);
            this.SpInput.Name = "SpInput";
            this.SpInput.Size = new System.Drawing.Size(195, 26);
            this.SpInput.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Contact No";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // CnInput
            // 
            this.CnInput.Location = new System.Drawing.Point(139, 344);
            this.CnInput.Name = "CnInput";
            this.CnInput.Size = new System.Drawing.Size(195, 26);
            this.CnInput.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Working Hours";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // WhInput
            // 
            this.WhInput.Location = new System.Drawing.Point(561, 344);
            this.WhInput.Name = "WhInput";
            this.WhInput.Size = new System.Drawing.Size(195, 26);
            this.WhInput.TabIndex = 2;
            // 
            // Addrecordbtn
            // 
            this.Addrecordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.Addrecordbtn.ForeColor = System.Drawing.Color.White;
            this.Addrecordbtn.Location = new System.Drawing.Point(300, 449);
            this.Addrecordbtn.Name = "Addrecordbtn";
            this.Addrecordbtn.Size = new System.Drawing.Size(235, 68);
            this.Addrecordbtn.TabIndex = 3;
            this.Addrecordbtn.Text = "Add Record";
            this.Addrecordbtn.UseVisualStyleBackColor = false;
            this.Addrecordbtn.Click += new System.EventHandler(this.Addrecordbtn_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(561, 198);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(195, 28);
            this.cmbGender.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Password";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // pwdInput
            // 
            this.pwdInput.Location = new System.Drawing.Point(139, 274);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.Size = new System.Drawing.Size(195, 26);
            this.pwdInput.TabIndex = 2;
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 674);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.Addrecordbtn);
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
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDoctor";
            this.Text = "AddDoctor";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SpInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CnInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WhInput;
        private System.Windows.Forms.Button Addrecordbtn;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pwdInput;
    }
}