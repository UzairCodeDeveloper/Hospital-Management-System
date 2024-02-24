namespace WindowsFormsApp1
{
    partial class AppointmentStatus
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
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentGrid
            // 
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Location = new System.Drawing.Point(28, 239);
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.RowHeadersWidth = 62;
            this.AppointmentGrid.RowTemplate.Height = 28;
            this.AppointmentGrid.Size = new System.Drawing.Size(761, 346);
            this.AppointmentGrid.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 60);
            this.label4.TabIndex = 56;
            this.label4.Text = "Appointment Status";
            // 
            // AppointmentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 618);
            this.Controls.Add(this.AppointmentGrid);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentStatus";
            this.Text = "AppointmentStatus";
            this.Load += new System.EventHandler(this.AppointmentStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.Label label4;
    }
}