namespace WindowsFormsApp1
{
    partial class AdminMedManagement
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
            this.Edtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchRecord = new System.Windows.Forms.Button();
            this.MedInputSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.UpdateRecord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MContact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Edtp
            // 
            this.Edtp.Location = new System.Drawing.Point(576, 238);
            this.Edtp.Name = "Edtp";
            this.Edtp.Size = new System.Drawing.Size(229, 26);
            this.Edtp.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Expire Date";
            // 
            // MCompany
            // 
            this.MCompany.Location = new System.Drawing.Point(581, 311);
            this.MCompany.Name = "MCompany";
            this.MCompany.Size = new System.Drawing.Size(224, 26);
            this.MCompany.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Company Name";
            // 
            // costInput
            // 
            this.costInput.Location = new System.Drawing.Point(581, 381);
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(224, 26);
            this.costInput.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Cost";
            // 
            // MName
            // 
            this.MName.Location = new System.Drawing.Point(145, 311);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(224, 26);
            this.MName.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "MED NAME";
            // 
            // MId
            // 
            this.MId.Location = new System.Drawing.Point(145, 246);
            this.MId.Name = "MId";
            this.MId.Size = new System.Drawing.Size(224, 26);
            this.MId.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "MED ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 60);
            this.label1.TabIndex = 61;
            this.label1.Text = "Medicine Management";
            // 
            // SearchRecord
            // 
            this.SearchRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchRecord.ForeColor = System.Drawing.Color.White;
            this.SearchRecord.Location = new System.Drawing.Point(539, 115);
            this.SearchRecord.Name = "SearchRecord";
            this.SearchRecord.Size = new System.Drawing.Size(121, 47);
            this.SearchRecord.TabIndex = 78;
            this.SearchRecord.Text = "Search";
            this.SearchRecord.UseVisualStyleBackColor = false;
            this.SearchRecord.Click += new System.EventHandler(this.SearchRecord_Click);
            // 
            // MedInputSearch
            // 
            this.MedInputSearch.Location = new System.Drawing.Point(320, 125);
            this.MedInputSearch.Name = "MedInputSearch";
            this.MedInputSearch.Size = new System.Drawing.Size(195, 26);
            this.MedInputSearch.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 76;
            this.label12.Text = "Med ID";
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.Red;
            this.DeleteRecord.ForeColor = System.Drawing.Color.White;
            this.DeleteRecord.Location = new System.Drawing.Point(461, 525);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(158, 68);
            this.DeleteRecord.TabIndex = 79;
            this.DeleteRecord.Text = "Delete";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateRecord.ForeColor = System.Drawing.Color.White;
            this.UpdateRecord.Location = new System.Drawing.Point(180, 525);
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(183, 68);
            this.UpdateRecord.TabIndex = 80;
            this.UpdateRecord.Text = "Update";
            this.UpdateRecord.UseVisualStyleBackColor = false;
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Contact No";
            // 
            // MContact
            // 
            this.MContact.Location = new System.Drawing.Point(145, 378);
            this.MContact.Name = "MContact";
            this.MContact.Size = new System.Drawing.Size(224, 26);
            this.MContact.TabIndex = 68;
            // 
            // AdminMedManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 674);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.UpdateRecord);
            this.Controls.Add(this.SearchRecord);
            this.Controls.Add(this.MedInputSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Edtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MContact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AdminMedManagement";
            this.Text = "AdminMedManagement";
            this.Load += new System.EventHandler(this.AdminMedManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Edtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchRecord;
        private System.Windows.Forms.TextBox MedInputSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Button UpdateRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MContact;
    }
}