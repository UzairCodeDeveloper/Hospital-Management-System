namespace WindowsFormsApp1
{
    partial class Appointments
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
            this.dataGridViewAppointment1 = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.dataGridViewAppointment2 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Requests";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // dataGridViewAppointment1
            // 
            this.dataGridViewAppointment1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAppointment1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAppointment1.Location = new System.Drawing.Point(0, 14);
            this.dataGridViewAppointment1.Name = "dataGridViewAppointment1";
            this.dataGridViewAppointment1.RowHeadersWidth = 62;
            this.dataGridViewAppointment1.RowTemplate.Height = 28;
            this.dataGridViewAppointment1.Size = new System.Drawing.Size(362, 427);
            this.dataGridViewAppointment1.TabIndex = 1;
            this.dataGridViewAppointment1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointment1_CellContentClick);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccept.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccept.Location = new System.Drawing.Point(23, 485);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(133, 39);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept Request";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReject.Location = new System.Drawing.Point(205, 485);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(134, 39);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject Request";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // dataGridViewAppointment2
            // 
            this.dataGridViewAppointment2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAppointment2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAppointment2.Location = new System.Drawing.Point(434, 14);
            this.dataGridViewAppointment2.Name = "dataGridViewAppointment2";
            this.dataGridViewAppointment2.RowHeadersWidth = 62;
            this.dataGridViewAppointment2.RowTemplate.Height = 28;
            this.dataGridViewAppointment2.Size = new System.Drawing.Size(362, 427);
            this.dataGridViewAppointment2.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(549, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "Accepted";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridViewAppointment1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dataGridViewAppointment2);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Location = new System.Drawing.Point(27, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 620);
            this.panel1.TabIndex = 7;
            // 
            // currDoc
            // 
            this.currDoc.Enabled = false;
            this.currDoc.Location = new System.Drawing.Point(27, 12);
            this.currDoc.Name = "currDoc";
            this.currDoc.Size = new System.Drawing.Size(100, 26);
            this.currDoc.TabIndex = 8;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(850, 730);
            this.Controls.Add(this.currDoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAppointment1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.DataGridView dataGridViewAppointment2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox currDoc;
    }
}