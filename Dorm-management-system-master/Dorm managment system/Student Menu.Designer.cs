
namespace Dorm_managment_system
{
    partial class Student_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Menu));
            this.btnbookacc = new System.Windows.Forms.Button();
            this.btnstufeed = new System.Windows.Forms.Button();
            this.btnstuaccreq = new System.Windows.Forms.Button();
            this.btnstutermacc = new System.Windows.Forms.Button();
            this.lblstu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbookacc
            // 
            resources.ApplyResources(this.btnbookacc, "btnbookacc");
            this.btnbookacc.Name = "btnbookacc";
            this.btnbookacc.UseVisualStyleBackColor = true;
            this.btnbookacc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstufeed
            // 
            resources.ApplyResources(this.btnstufeed, "btnstufeed");
            this.btnstufeed.Name = "btnstufeed";
            this.btnstufeed.UseVisualStyleBackColor = true;
            this.btnstufeed.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnstuaccreq
            // 
            resources.ApplyResources(this.btnstuaccreq, "btnstuaccreq");
            this.btnstuaccreq.Name = "btnstuaccreq";
            this.btnstuaccreq.UseVisualStyleBackColor = true;
            // 
            // btnstutermacc
            // 
            resources.ApplyResources(this.btnstutermacc, "btnstutermacc");
            this.btnstutermacc.Name = "btnstutermacc";
            this.btnstutermacc.UseVisualStyleBackColor = true;
            // 
            // lblstu
            // 
            resources.ApplyResources(this.lblstu, "lblstu");
            this.lblstu.Name = "lblstu";
            // 
            // Student_Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblstu);
            this.Controls.Add(this.btnstutermacc);
            this.Controls.Add(this.btnstuaccreq);
            this.Controls.Add(this.btnstufeed);
            this.Controls.Add(this.btnbookacc);
            this.Name = "Student_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbookacc;
        private System.Windows.Forms.Button btnstufeed;
        private System.Windows.Forms.Button btnstuaccreq;
        private System.Windows.Forms.Button btnstutermacc;
        private System.Windows.Forms.Label lblstu;
    }
}