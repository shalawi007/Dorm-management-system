
namespace Dorm_managment_system
{
    partial class Accomodation_Request
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
            this.rdoBlockA = new System.Windows.Forms.RadioButton();
            this.rdoBlockB = new System.Windows.Forms.RadioButton();
            this.lstFacilities = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblStartstay = new System.Windows.Forms.Label();
            this.lblEndstay = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(630, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Block :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdoBlockA
            // 
            this.rdoBlockA.AutoSize = true;
            this.rdoBlockA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.rdoBlockA.Location = new System.Drawing.Point(630, 80);
            this.rdoBlockA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBlockA.Name = "rdoBlockA";
            this.rdoBlockA.Size = new System.Drawing.Size(65, 19);
            this.rdoBlockA.TabIndex = 1;
            this.rdoBlockA.TabStop = true;
            this.rdoBlockA.Text = "Block A";
            this.rdoBlockA.UseVisualStyleBackColor = true;
            this.rdoBlockA.CheckedChanged += new System.EventHandler(this.rdoBlockA_CheckedChanged);
            // 
            // rdoBlockB
            // 
            this.rdoBlockB.AutoSize = true;
            this.rdoBlockB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.rdoBlockB.Location = new System.Drawing.Point(630, 103);
            this.rdoBlockB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBlockB.Name = "rdoBlockB";
            this.rdoBlockB.Size = new System.Drawing.Size(64, 19);
            this.rdoBlockB.TabIndex = 2;
            this.rdoBlockB.TabStop = true;
            this.rdoBlockB.Text = "Block B";
            this.rdoBlockB.UseVisualStyleBackColor = true;
            this.rdoBlockB.CheckedChanged += new System.EventHandler(this.rdoBlockB_CheckedChanged);
            // 
            // lstFacilities
            // 
            this.lstFacilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.lstFacilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFacilities.ForeColor = System.Drawing.SystemColors.Window;
            this.lstFacilities.FormattingEnabled = true;
            this.lstFacilities.ItemHeight = 15;
            this.lstFacilities.Location = new System.Drawing.Point(631, 164);
            this.lstFacilities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstFacilities.Name = "lstFacilities";
            this.lstFacilities.Size = new System.Drawing.Size(131, 122);
            this.lstFacilities.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(33, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Accomodation Request";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblName.Location = new System.Drawing.Point(40, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Full Name :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblStudentID.Location = new System.Drawing.Point(40, 89);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(68, 15);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "Student ID :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblEmail.Location = new System.Drawing.Point(40, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email address :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblContact.Location = new System.Drawing.Point(40, 157);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(75, 15);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact no. :";
            // 
            // lblStartstay
            // 
            this.lblStartstay.AutoSize = true;
            this.lblStartstay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblStartstay.Location = new System.Drawing.Point(292, 55);
            this.lblStartstay.Name = "lblStartstay";
            this.lblStartstay.Size = new System.Drawing.Size(118, 15);
            this.lblStartstay.TabIndex = 10;
            this.lblStartstay.Text = "Starting date of stay :";
            // 
            // lblEndstay
            // 
            this.lblEndstay.AutoSize = true;
            this.lblEndstay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblEndstay.Location = new System.Drawing.Point(296, 95);
            this.lblEndstay.Name = "lblEndstay";
            this.lblEndstay.Size = new System.Drawing.Size(114, 15);
            this.lblEndstay.TabIndex = 11;
            this.lblEndstay.Text = "Ending date of stay :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(154, 53);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 23);
            this.txtName.TabIndex = 13;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStudentID.Location = new System.Drawing.Point(154, 87);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(110, 23);
            this.txtStudentID.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(154, 121);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(110, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContact.Location = new System.Drawing.Point(154, 154);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(110, 23);
            this.txtContact.TabIndex = 16;
            // 
            // btnFacilities
            // 
            this.btnFacilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacilities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFacilities.Location = new System.Drawing.Point(631, 134);
            this.btnFacilities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Size = new System.Drawing.Size(130, 22);
            this.btnFacilities.TabIndex = 20;
            this.btnFacilities.Text = "View Facilities";
            this.btnFacilities.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSubmit.Location = new System.Drawing.Point(360, 285);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 30);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit ";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(416, 53);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 23);
            this.StartDatePicker.TabIndex = 22;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(416, 89);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 23);
            this.EndDatePicker.TabIndex = 23;
            // 
            // Accomodation_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(808, 338);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnFacilities);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEndstay);
            this.Controls.Add(this.lblStartstay);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstFacilities);
            this.Controls.Add(this.rdoBlockB);
            this.Controls.Add(this.rdoBlockA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Accomodation_Request";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accomodation Request";
            this.Load += new System.EventHandler(this.Accomodation_Request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoBlockA;
        private System.Windows.Forms.RadioButton rdoBlockB;
        private System.Windows.Forms.ListBox lstFacilities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblStartstay;
        private System.Windows.Forms.Label lblEndstay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
    }
}