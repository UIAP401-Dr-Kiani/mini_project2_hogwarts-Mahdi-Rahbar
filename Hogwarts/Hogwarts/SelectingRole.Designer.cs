
namespace Hogwarts
{
    partial class SelectingRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectingRole));
            this.admin = new System.Windows.Forms.Button();
            this.notice = new System.Windows.Forms.Label();
            this.master = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(1024, 321);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(122, 55);
            this.admin.TabIndex = 0;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            this.admin.MouseEnter += new System.EventHandler(this.admin_MouseEnter);
            this.admin.MouseLeave += new System.EventHandler(this.admin_MouseLeave);
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.BackColor = System.Drawing.Color.Transparent;
            this.notice.ForeColor = System.Drawing.Color.Red;
            this.notice.Location = new System.Drawing.Point(1013, 280);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(156, 17);
            this.notice.TabIndex = 1;
            this.notice.Text = "Please select your role.";
            // 
            // master
            // 
            this.master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.master.ForeColor = System.Drawing.Color.White;
            this.master.Location = new System.Drawing.Point(1024, 391);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(122, 55);
            this.master.TabIndex = 2;
            this.master.Text = "Master";
            this.master.UseVisualStyleBackColor = false;
            this.master.MouseEnter += new System.EventHandler(this.master_MouseEnter);
            this.master.MouseLeave += new System.EventHandler(this.master_MouseLeave);
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.student.ForeColor = System.Drawing.Color.White;
            this.student.Location = new System.Drawing.Point(1024, 461);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(122, 55);
            this.student.TabIndex = 3;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = false;
            this.student.MouseEnter += new System.EventHandler(this.student_MouseEnter);
            this.student.MouseLeave += new System.EventHandler(this.student_MouseLeave);
            // 
            // SelectingRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.student);
            this.Controls.Add(this.master);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectingRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecting Role";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Button master;
        private System.Windows.Forms.Button student;
    }
}

