namespace WindowsFormsApp1
{
    partial class AddPrescription
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.preWindowDate = new System.Windows.Forms.TextBox();
            this.preWindowContact = new System.Windows.Forms.TextBox();
            this.Num_of_days = new System.Windows.Forms.TextBox();
            this.preWindowDisease = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.comboboxMedicineName = new System.Windows.Forms.ComboBox();
            this.comboboxTiming = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Disease";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Medicine Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "No of Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Timing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save And Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDocId
            // 
            this.txtDocId.Enabled = false;
            this.txtDocId.Location = new System.Drawing.Point(269, 29);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(115, 26);
            this.txtDocId.TabIndex = 8;
            this.txtDocId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // preWindowDate
            // 
            this.preWindowDate.Location = new System.Drawing.Point(269, 132);
            this.preWindowDate.Name = "preWindowDate";
            this.preWindowDate.Size = new System.Drawing.Size(115, 26);
            this.preWindowDate.TabIndex = 9;
            this.preWindowDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // preWindowContact
            // 
            this.preWindowContact.Location = new System.Drawing.Point(269, 81);
            this.preWindowContact.Name = "preWindowContact";
            this.preWindowContact.Size = new System.Drawing.Size(115, 26);
            this.preWindowContact.TabIndex = 9;
            this.preWindowContact.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Num_of_days
            // 
            this.Num_of_days.Location = new System.Drawing.Point(269, 288);
            this.Num_of_days.Name = "Num_of_days";
            this.Num_of_days.Size = new System.Drawing.Size(115, 26);
            this.Num_of_days.TabIndex = 11;
            // 
            // preWindowDisease
            // 
            this.preWindowDisease.Location = new System.Drawing.Point(269, 185);
            this.preWindowDisease.Name = "preWindowDisease";
            this.preWindowDisease.Size = new System.Drawing.Size(115, 26);
            this.preWindowDisease.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(269, 340);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(115, 26);
            this.txtQuantity.TabIndex = 13;
            // 
            // comboboxMedicineName
            // 
            this.comboboxMedicineName.FormattingEnabled = true;
            this.comboboxMedicineName.Location = new System.Drawing.Point(269, 234);
            this.comboboxMedicineName.Name = "comboboxMedicineName";
            this.comboboxMedicineName.Size = new System.Drawing.Size(121, 28);
            this.comboboxMedicineName.TabIndex = 17;
            // 
            // comboboxTiming
            // 
            this.comboboxTiming.FormattingEnabled = true;
            this.comboboxTiming.Location = new System.Drawing.Point(269, 391);
            this.comboboxTiming.Name = "comboboxTiming";
            this.comboboxTiming.Size = new System.Drawing.Size(121, 28);
            this.comboboxTiming.TabIndex = 18;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 536);
            this.Controls.Add(this.comboboxTiming);
            this.Controls.Add(this.comboboxMedicineName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.Num_of_days);
            this.Controls.Add(this.preWindowDisease);
            this.Controls.Add(this.preWindowContact);
            this.Controls.Add(this.preWindowDate);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.TextBox preWindowDate;
        private System.Windows.Forms.TextBox preWindowContact;
        private System.Windows.Forms.TextBox Num_of_days;
        public System.Windows.Forms.TextBox preWindowDisease;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox comboboxMedicineName;
        private System.Windows.Forms.ComboBox comboboxTiming;
    }
}