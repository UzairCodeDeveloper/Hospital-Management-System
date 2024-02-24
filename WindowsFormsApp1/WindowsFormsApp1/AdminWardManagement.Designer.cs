namespace WindowsFormsApp1
{
    partial class AdminWardManagement
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
            this.label3 = new System.Windows.Forms.Label();
            this.Wardcapacity = new System.Windows.Forms.TextBox();
            this.Wardincharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Wardname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchRecord = new System.Windows.Forms.Button();
            this.WardSearchInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.UpdateRecord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wardId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Capicity";
            // 
            // Wardcapacity
            // 
            this.Wardcapacity.Location = new System.Drawing.Point(586, 289);
            this.Wardcapacity.Name = "Wardcapacity";
            this.Wardcapacity.Size = new System.Drawing.Size(224, 26);
            this.Wardcapacity.TabIndex = 76;
            // 
            // Wardincharge
            // 
            this.Wardincharge.Location = new System.Drawing.Point(586, 350);
            this.Wardincharge.Name = "Wardincharge";
            this.Wardincharge.Size = new System.Drawing.Size(224, 26);
            this.Wardincharge.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Ward Incharge";
            // 
            // Wardname
            // 
            this.Wardname.Location = new System.Drawing.Point(141, 350);
            this.Wardname.Name = "Wardname";
            this.Wardname.Size = new System.Drawing.Size(224, 26);
            this.Wardname.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Ward Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 60);
            this.label1.TabIndex = 72;
            this.label1.Text = "Ward Management";
            // 
            // SearchRecord
            // 
            this.SearchRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchRecord.ForeColor = System.Drawing.Color.White;
            this.SearchRecord.Location = new System.Drawing.Point(558, 150);
            this.SearchRecord.Name = "SearchRecord";
            this.SearchRecord.Size = new System.Drawing.Size(121, 47);
            this.SearchRecord.TabIndex = 82;
            this.SearchRecord.Text = "Search";
            this.SearchRecord.UseVisualStyleBackColor = false;
            this.SearchRecord.Click += new System.EventHandler(this.SearchRecord_Click);
            // 
            // WardSearchInput
            // 
            this.WardSearchInput.Location = new System.Drawing.Point(339, 160);
            this.WardSearchInput.Name = "WardSearchInput";
            this.WardSearchInput.Size = new System.Drawing.Size(195, 26);
            this.WardSearchInput.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Ward ID";
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.Red;
            this.DeleteRecord.ForeColor = System.Drawing.Color.White;
            this.DeleteRecord.Location = new System.Drawing.Point(521, 518);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(158, 68);
            this.DeleteRecord.TabIndex = 83;
            this.DeleteRecord.Text = "Delete";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateRecord.ForeColor = System.Drawing.Color.White;
            this.UpdateRecord.Location = new System.Drawing.Point(240, 518);
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(183, 68);
            this.UpdateRecord.TabIndex = 84;
            this.UpdateRecord.Text = "Update";
            this.UpdateRecord.UseVisualStyleBackColor = false;
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Ward ID";
            // 
            // wardId
            // 
            this.wardId.Location = new System.Drawing.Point(141, 286);
            this.wardId.Name = "wardId";
            this.wardId.Size = new System.Drawing.Size(224, 26);
            this.wardId.TabIndex = 77;
            // 
            // AdminWardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 691);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.UpdateRecord);
            this.Controls.Add(this.SearchRecord);
            this.Controls.Add(this.WardSearchInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wardcapacity);
            this.Controls.Add(this.wardId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Wardincharge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Wardname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AdminWardManagement";
            this.Text = "AdminWardManagement";
            this.Load += new System.EventHandler(this.AdminWardManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Wardcapacity;
        private System.Windows.Forms.TextBox Wardincharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Wardname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchRecord;
        private System.Windows.Forms.TextBox WardSearchInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Button UpdateRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wardId;
    }
}