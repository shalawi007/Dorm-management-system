
namespace Dorm_managment_system
{
    partial class Warden_Menu
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
            this.lblwarden = new System.Windows.Forms.Label();
            this.btnssignacc = new System.Windows.Forms.Button();
            this.btnwarfeed = new System.Windows.Forms.Button();
            this.btnwarroomreq = new System.Windows.Forms.Button();
            this.btnaccreport = new System.Windows.Forms.Button();
            this.btnwartermacc = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // lblwarden
            // 
            this.lblwarden.AutoSize = true;
            this.lblwarden.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblwarden.Location = new System.Drawing.Point(35, 24);
            this.lblwarden.Name = "lblwarden";
            this.lblwarden.Size = new System.Drawing.Size(236, 38);
            this.lblwarden.TabIndex = 0;
            this.lblwarden.Text = "Welcome Warden";
            // 
            // btnssignacc
            // 
            this.btnssignacc.Location = new System.Drawing.Point(53, 164);
            this.btnssignacc.Name = "btnssignacc";
            this.btnssignacc.Size = new System.Drawing.Size(202, 29);
            this.btnssignacc.TabIndex = 1;
            this.btnssignacc.Text = "Assign Accomodation";
            this.btnssignacc.UseVisualStyleBackColor = true;
            this.btnssignacc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnwarfeed
            // 
            this.btnwarfeed.Location = new System.Drawing.Point(53, 241);
            this.btnwarfeed.Name = "btnwarfeed";
            this.btnwarfeed.Size = new System.Drawing.Size(202, 29);
            this.btnwarfeed.TabIndex = 2;
            this.btnwarfeed.Text = "Review Feedback";
            this.btnwarfeed.UseVisualStyleBackColor = true;
            // 
            // btnwarroomreq
            // 
            this.btnwarroomreq.Location = new System.Drawing.Point(405, 164);
            this.btnwarroomreq.Name = "btnwarroomreq";
            this.btnwarroomreq.Size = new System.Drawing.Size(199, 29);
            this.btnwarroomreq.TabIndex = 3;
            this.btnwarroomreq.Text = "Change room requests";
            this.btnwarroomreq.UseVisualStyleBackColor = true;
            // 
            // btnaccreport
            // 
            this.btnaccreport.Location = new System.Drawing.Point(53, 318);
            this.btnaccreport.Name = "btnaccreport";
            this.btnaccreport.Size = new System.Drawing.Size(202, 29);
            this.btnaccreport.TabIndex = 4;
            this.btnaccreport.Text = "Generate Report";
            this.btnaccreport.UseVisualStyleBackColor = true;
            // 
            // btnwartermacc
            // 
            this.btnwartermacc.Location = new System.Drawing.Point(405, 241);
            this.btnwartermacc.Name = "btnwartermacc";
            this.btnwartermacc.Size = new System.Drawing.Size(199, 29);
            this.btnwartermacc.TabIndex = 5;
            this.btnwartermacc.Text = "Terminate requests";
            this.btnwartermacc.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 450);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // Warden_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnwartermacc);
            this.Controls.Add(this.btnaccreport);
            this.Controls.Add(this.btnwarroomreq);
            this.Controls.Add(this.btnwarfeed);
            this.Controls.Add(this.btnssignacc);
            this.Controls.Add(this.lblwarden);
            this.Name = "Warden_Menu";
            this.Text = "Warden_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwarden;
        private System.Windows.Forms.Button btnssignacc;
        private System.Windows.Forms.Button btnwarfeed;
        private System.Windows.Forms.Button btnwarroomreq;
        private System.Windows.Forms.Button btnaccreport;
        private System.Windows.Forms.Button btnwartermacc;
        private System.Windows.Forms.Splitter splitter1;
    }
}