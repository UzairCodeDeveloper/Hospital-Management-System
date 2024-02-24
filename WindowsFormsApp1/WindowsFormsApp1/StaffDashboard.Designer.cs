namespace WindowsFormsApp1
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            this.displayPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Takeappointment = new System.Windows.Forms.Button();
            this.DoctorSchedule = new System.Windows.Forms.Button();
            this.AddPatient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.White;
            this.displayPanel.Location = new System.Drawing.Point(275, 88);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(850, 730);
            this.displayPanel.TabIndex = 13;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.Takeappointment);
            this.panel2.Controls.Add(this.DoctorSchedule);
            this.panel2.Controls.Add(this.AddPatient);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 78);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel2.Size = new System.Drawing.Size(270, 741);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 10);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Appointment Status";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Takeappointment
            // 
            this.Takeappointment.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold);
            this.Takeappointment.Location = new System.Drawing.Point(1, 297);
            this.Takeappointment.Name = "Takeappointment";
            this.Takeappointment.Size = new System.Drawing.Size(270, 48);
            this.Takeappointment.TabIndex = 5;
            this.Takeappointment.Text = "Take Appointment";
            this.Takeappointment.UseVisualStyleBackColor = true;
            this.Takeappointment.Click += new System.EventHandler(this.Takeappointment_Click);
            // 
            // DoctorSchedule
            // 
            this.DoctorSchedule.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold);
            this.DoctorSchedule.Location = new System.Drawing.Point(1, 232);
            this.DoctorSchedule.Name = "DoctorSchedule";
            this.DoctorSchedule.Size = new System.Drawing.Size(270, 48);
            this.DoctorSchedule.TabIndex = 5;
            this.DoctorSchedule.Text = "Doctor Schedule";
            this.DoctorSchedule.UseVisualStyleBackColor = true;
            this.DoctorSchedule.Click += new System.EventHandler(this.DoctorSchedule_Click);
            // 
            // AddPatient
            // 
            this.AddPatient.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatient.Location = new System.Drawing.Point(1, 168);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(270, 48);
            this.AddPatient.TabIndex = 5;
            this.AddPatient.Text = "Admit Patient";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Demo Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Al Shifa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1352, 83);
            this.panel3.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1086, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "X";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 816);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDashboard";
            this.Text = "StaffDashboard";
            this.Load += new System.EventHandler(this.StaffDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Takeappointment;
        private System.Windows.Forms.Button DoctorSchedule;
        private System.Windows.Forms.Button AddPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
    }
}