﻿namespace WindowsFormsApp1
{
    partial class AddMedicine
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
            this.AddREcord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costInput = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.DiseaseType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DiseaseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Edtp
            // 
            this.Edtp.Location = new System.Drawing.Point(573, 256);
            this.Edtp.Name = "Edtp";
            this.Edtp.Size = new System.Drawing.Size(229, 26);
            this.Edtp.TabIndex = 60;
            // 
            // AddREcord
            // 
            this.AddREcord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.AddREcord.ForeColor = System.Drawing.Color.White;
            this.AddREcord.Location = new System.Drawing.Point(298, 450);
            this.AddREcord.Name = "AddREcord";
            this.AddREcord.Size = new System.Drawing.Size(264, 68);
            this.AddREcord.TabIndex = 59;
            this.AddREcord.Text = "Add Record";
            this.AddREcord.UseVisualStyleBackColor = false;
            this.AddREcord.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Expire Date";
            // 
            // MCompany
            // 
            this.MCompany.Location = new System.Drawing.Point(573, 192);
            this.MCompany.Name = "MCompany";
            this.MCompany.Size = new System.Drawing.Size(224, 26);
            this.MCompany.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Company Name";
            // 
            // MContact
            // 
            this.MContact.Location = new System.Drawing.Point(159, 256);
            this.MContact.Name = "MContact";
            this.MContact.Size = new System.Drawing.Size(224, 26);
            this.MContact.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Contact No";
            // 
            // MName
            // 
            this.MName.Location = new System.Drawing.Point(159, 124);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(224, 26);
            this.MName.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 60);
            this.label1.TabIndex = 49;
            this.label1.Text = "Add Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cost";
            // 
            // costInput
            // 
            this.costInput.Location = new System.Drawing.Point(159, 322);
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(224, 26);
            this.costInput.TabIndex = 55;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(433, 130);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(113, 20);
            this.lable2.TabIndex = 61;
            this.lable2.Text = "Disease Name";
            // 
            // DiseaseType
            // 
            this.DiseaseType.Location = new System.Drawing.Point(159, 192);
            this.DiseaseType.Name = "DiseaseType";
            this.DiseaseType.Size = new System.Drawing.Size(224, 26);
            this.DiseaseType.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Disease Type";
            // 
            // DiseaseName
            // 
            this.DiseaseName.Location = new System.Drawing.Point(573, 124);
            this.DiseaseName.Name = "DiseaseName";
            this.DiseaseName.Size = new System.Drawing.Size(224, 26);
            this.DiseaseName.TabIndex = 65;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 674);
            this.Controls.Add(this.DiseaseName);
            this.Controls.Add(this.DiseaseType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.Edtp);
            this.Controls.Add(this.AddREcord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Edtp;
        private System.Windows.Forms.Button AddREcord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costInput;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox DiseaseType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DiseaseName;
    }
}