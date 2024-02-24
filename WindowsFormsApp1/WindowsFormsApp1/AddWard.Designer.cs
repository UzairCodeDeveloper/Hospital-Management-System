namespace WindowsFormsApp1
{
    partial class AddWard
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
            this.AddREcord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Wardincharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Wardname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Wardcapacity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddREcord
            // 
            this.AddREcord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.AddREcord.ForeColor = System.Drawing.Color.White;
            this.AddREcord.Location = new System.Drawing.Point(293, 335);
            this.AddREcord.Name = "AddREcord";
            this.AddREcord.Size = new System.Drawing.Size(264, 68);
            this.AddREcord.TabIndex = 71;
            this.AddREcord.Text = "Add Record";
            this.AddREcord.UseVisualStyleBackColor = false;
            this.AddREcord.Click += new System.EventHandler(this.AddREcord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Capicity";
            // 
            // Wardincharge
            // 
            this.Wardincharge.Location = new System.Drawing.Point(165, 221);
            this.Wardincharge.Name = "Wardincharge";
            this.Wardincharge.Size = new System.Drawing.Size(224, 26);
            this.Wardincharge.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ward Incharge";
            // 
            // Wardname
            // 
            this.Wardname.Location = new System.Drawing.Point(165, 159);
            this.Wardname.Name = "Wardname";
            this.Wardname.Size = new System.Drawing.Size(224, 26);
            this.Wardname.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Ward Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 60);
            this.label1.TabIndex = 61;
            this.label1.Text = "Add Ward";
            // 
            // Wardcapacity
            // 
            this.Wardcapacity.Location = new System.Drawing.Point(562, 153);
            this.Wardcapacity.Name = "Wardcapacity";
            this.Wardcapacity.Size = new System.Drawing.Size(224, 26);
            this.Wardcapacity.TabIndex = 68;
            // 
            // AddWard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 674);
            this.Controls.Add(this.AddREcord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wardcapacity);
            this.Controls.Add(this.Wardincharge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Wardname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AddWard";
            this.Text = "AddWard";
            this.Load += new System.EventHandler(this.AddWard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddREcord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Wardincharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Wardname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Wardcapacity;
    }
}