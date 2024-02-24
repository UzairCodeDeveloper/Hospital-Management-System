namespace WindowsFormsApp1
{
    partial class fom
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridviewDoctor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Doctor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update/Delete Doctor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Records :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridviewDoctor
            // 
            this.dataGridviewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewDoctor.Location = new System.Drawing.Point(25, 313);
            this.dataGridviewDoctor.Name = "dataGridviewDoctor";
            this.dataGridviewDoctor.RowHeadersWidth = 62;
            this.dataGridviewDoctor.RowTemplate.Height = 28;
            this.dataGridviewDoctor.Size = new System.Drawing.Size(787, 347);
            this.dataGridviewDoctor.TabIndex = 3;
            this.dataGridviewDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridviewDoctor_CellContentClick);
            // 
            // fom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 730);
            this.Controls.Add(this.dataGridviewDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fom";
            this.Text = "DoctorsRecord";
            this.Load += new System.EventHandler(this.DoctorsRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridviewDoctor;
    }
}