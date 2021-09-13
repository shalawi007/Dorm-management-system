
using System;

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
            this.lblRoomnumb = new System.Windows.Forms.Label();
            this.lblBlocktransfer = new System.Windows.Forms.Label();
            this.txtRoomno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdoBlockB = new System.Windows.Forms.RadioButton();
            this.rdoBlockA = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoomnumb
            // 
            this.lblRoomnumb.AutoSize = true;
            this.lblRoomnumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblRoomnumb.Location = new System.Drawing.Point(40, 79);
            this.lblRoomnumb.Name = "lblRoomnumb";
            this.lblRoomnumb.Size = new System.Drawing.Size(108, 15);
            this.lblRoomnumb.TabIndex = 1;
            this.lblRoomnumb.Text = "Current Room no. :";
            // 
            // lblBlocktransfer
            // 
            this.lblBlocktransfer.AutoSize = true;
            this.lblBlocktransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblBlocktransfer.Location = new System.Drawing.Point(373, 62);
            this.lblBlocktransfer.Name = "lblBlocktransfer";
            this.lblBlocktransfer.Size = new System.Drawing.Size(147, 15);
            this.lblBlocktransfer.TabIndex = 2;
            this.lblBlocktransfer.Text = "Select block to transfer to :";
            // 
            // txtRoomno
            // 
            this.txtRoomno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtRoomno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomno.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRoomno.Location = new System.Drawing.Point(181, 77);
            this.txtRoomno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomno.Name = "txtRoomno";
            this.txtRoomno.Size = new System.Drawing.Size(110, 23);
            this.txtRoomno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Change Accomodation Room Request";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSubmit.Location = new System.Drawing.Point(259, 190);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 27);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdoBlockB
            // 
            this.rdoBlockB.AutoSize = true;
            this.rdoBlockB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.rdoBlockB.Location = new System.Drawing.Point(373, 104);
            this.rdoBlockB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBlockB.Name = "rdoBlockB";
            this.rdoBlockB.Size = new System.Drawing.Size(64, 19);
            this.rdoBlockB.TabIndex = 10;
            this.rdoBlockB.TabStop = true;
            this.rdoBlockB.Text = "Block B";
            this.rdoBlockB.UseVisualStyleBackColor = true;
            // 
            // rdoBlockA
            // 
            this.rdoBlockA.AutoSize = true;
            this.rdoBlockA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.rdoBlockA.Location = new System.Drawing.Point(373, 81);
            this.rdoBlockA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBlockA.Name = "rdoBlockA";
            this.rdoBlockA.Size = new System.Drawing.Size(65, 19);
            this.rdoBlockA.TabIndex = 9;
            this.rdoBlockA.TabStop = true;
            this.rdoBlockA.Text = "Block A";
            this.rdoBlockA.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(597, -1);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Change_Room_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 242);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdoBlockB);
            this.Controls.Add(this.rdoBlockA);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomno);
            this.Controls.Add(this.lblBlocktransfer);
            this.Controls.Add(this.lblRoomnumb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Change_Room_Request";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Room Request";
            this.Load += new System.EventHandler(this.Change_Room_Request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBlockA_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblRoomnumb;
        private System.Windows.Forms.Label lblBlocktransfer;
        private System.Windows.Forms.TextBox txtRoomno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoBlockB;
        private System.Windows.Forms.RadioButton rdoBlockA;
        private System.Windows.Forms.Button button2;
    }
}