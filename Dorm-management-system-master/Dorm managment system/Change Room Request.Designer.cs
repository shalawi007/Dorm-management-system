﻿
namespace Dorm_managment_system
{
    partial class Change_Room_Request
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblRoomnumb = new System.Windows.Forms.Label();
            this.lblBlocktransfer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBlockA = new System.Windows.Forms.Button();
            this.btnBlockB = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(51, 86);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(86, 20);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID :";
            // 
            // lblRoomnumb
            // 
            this.lblRoomnumb.AutoSize = true;
            this.lblRoomnumb.Location = new System.Drawing.Point(51, 135);
            this.lblRoomnumb.Name = "lblRoomnumb";
            this.lblRoomnumb.Size = new System.Drawing.Size(132, 20);
            this.lblRoomnumb.TabIndex = 1;
            this.lblRoomnumb.Text = "Current Room no. :";
            // 
            // lblBlocktransfer
            // 
            this.lblBlocktransfer.AutoSize = true;
            this.lblBlocktransfer.Location = new System.Drawing.Point(426, 86);
            this.lblBlocktransfer.Name = "lblBlocktransfer";
            this.lblBlocktransfer.Size = new System.Drawing.Size(186, 20);
            this.lblBlocktransfer.TabIndex = 2;
            this.lblBlocktransfer.Text = "Select block to transfer to :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Change Accomodation Room Request";
            // 
            // btnBlockA
            // 
            this.btnBlockA.Location = new System.Drawing.Point(426, 130);
            this.btnBlockA.Name = "btnBlockA";
            this.btnBlockA.Size = new System.Drawing.Size(94, 29);
            this.btnBlockA.TabIndex = 6;
            this.btnBlockA.Text = "Block A";
            this.btnBlockA.UseVisualStyleBackColor = true;
            this.btnBlockA.Click += new System.EventHandler(this.btnBlockA_Click);
            // 
            // btnBlockB
            // 
            this.btnBlockB.Location = new System.Drawing.Point(567, 130);
            this.btnBlockB.Name = "btnBlockB";
            this.btnBlockB.Size = new System.Drawing.Size(94, 29);
            this.btnBlockB.TabIndex = 7;
            this.btnBlockB.Text = "Block B";
            this.btnBlockB.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(296, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 36);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Change_Room_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 323);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBlockB);
            this.Controls.Add(this.btnBlockA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBlocktransfer);
            this.Controls.Add(this.lblRoomnumb);
            this.Controls.Add(this.lblStudentID);
            this.MaximizeBox = false;
            this.Name = "Change_Room_Request";
            this.ShowIcon = false;
            this.Text = "Change Room Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblRoomnumb;
        private System.Windows.Forms.Label lblBlocktransfer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBlockA;
        private System.Windows.Forms.Button btnBlockB;
        private System.Windows.Forms.Button btnSubmit;
    }
}