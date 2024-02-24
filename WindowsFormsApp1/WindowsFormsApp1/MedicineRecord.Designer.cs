namespace WindowsFormsApp1
{
    partial class MedicineRecord
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMedicine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update/Delete Medicine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medicine";
            // 
            // dataGridViewMedicine
            // 
            this.dataGridViewMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicine.Location = new System.Drawing.Point(24, 304);
            this.dataGridViewMedicine.Name = "dataGridViewMedicine";
            this.dataGridViewMedicine.RowHeadersWidth = 62;
            this.dataGridViewMedicine.RowTemplate.Height = 28;
            this.dataGridViewMedicine.Size = new System.Drawing.Size(787, 347);
            this.dataGridViewMedicine.TabIndex = 7;
            this.dataGridViewMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicine_CellContentClick);
            // 
            // MedicineRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 674);
            this.Controls.Add(this.dataGridViewMedicine);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineRecord";
            this.Text = "MedicineRecord";
            this.Load += new System.EventHandler(this.MedicineRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMedicine;
    }
}