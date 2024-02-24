namespace WindowsFormsApp1
{
    partial class doctorSchedule
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
            this.DoctorGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorGrid
            // 
            this.DoctorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorGrid.Location = new System.Drawing.Point(22, 233);
            this.DoctorGrid.Name = "DoctorGrid";
            this.DoctorGrid.RowHeadersWidth = 62;
            this.DoctorGrid.RowTemplate.Height = 28;
            this.DoctorGrid.Size = new System.Drawing.Size(761, 346);
            this.DoctorGrid.TabIndex = 55;
            this.DoctorGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 60);
            this.label4.TabIndex = 54;
            this.label4.Text = "Doctor Schedule";
            // 
            // doctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 618);
            this.Controls.Add(this.DoctorGrid);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctorSchedule";
            this.Text = "doctorSchedule";
            this.Load += new System.EventHandler(this.doctorSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DoctorGrid;
        private System.Windows.Forms.Label label4;
    }
}