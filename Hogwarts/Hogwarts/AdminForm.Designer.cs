
namespace Hogwarts
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.send_letter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send_letter
            // 
            this.send_letter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.send_letter.ForeColor = System.Drawing.Color.White;
            this.send_letter.Location = new System.Drawing.Point(928, 172);
            this.send_letter.Name = "send_letter";
            this.send_letter.Size = new System.Drawing.Size(145, 62);
            this.send_letter.TabIndex = 0;
            this.send_letter.Text = "Send Letter";
            this.send_letter.UseVisualStyleBackColor = false;
            this.send_letter.Click += new System.EventHandler(this.send_letter_Click);
            this.send_letter.MouseEnter += new System.EventHandler(this.send_letter_MouseEnter);
            this.send_letter.MouseLeave += new System.EventHandler(this.send_letter_MouseLeave);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.send_letter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button send_letter;
    }
}