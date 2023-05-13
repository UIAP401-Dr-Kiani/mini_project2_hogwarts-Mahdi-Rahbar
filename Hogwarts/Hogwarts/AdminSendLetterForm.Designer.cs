
namespace Hogwarts
{
    partial class AdminSendLetterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSendLetterForm));
            this.L_letter_text = new System.Windows.Forms.Label();
            this.letter_text = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.L_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_letter_text
            // 
            this.L_letter_text.AutoSize = true;
            this.L_letter_text.ForeColor = System.Drawing.Color.White;
            this.L_letter_text.Location = new System.Drawing.Point(302, 27);
            this.L_letter_text.Name = "L_letter_text";
            this.L_letter_text.Size = new System.Drawing.Size(76, 17);
            this.L_letter_text.TabIndex = 0;
            this.L_letter_text.Text = "Letter Text";
            // 
            // letter_text
            // 
            this.letter_text.Location = new System.Drawing.Point(89, 65);
            this.letter_text.Multiline = true;
            this.letter_text.Name = "letter_text";
            this.letter_text.Size = new System.Drawing.Size(500, 120);
            this.letter_text.TabIndex = 1;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.send.Location = new System.Drawing.Point(282, 292);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(116, 40);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            this.send.MouseEnter += new System.EventHandler(this.send_MouseEnter);
            this.send.MouseLeave += new System.EventHandler(this.send_MouseLeave);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(231, 241);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(220, 32);
            this.username.TabIndex = 3;
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.ForeColor = System.Drawing.Color.White;
            this.L_username.Location = new System.Drawing.Point(301, 204);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(73, 17);
            this.L_username.TabIndex = 4;
            this.L_username.Text = "Username";
            // 
            // AdminSendLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.username);
            this.Controls.Add(this.send);
            this.Controls.Add(this.letter_text);
            this.Controls.Add(this.L_letter_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminSendLetterForm";
            this.ShowInTaskbar = false;
            this.Text = "AdminSendLetterForm";
            this.Load += new System.EventHandler(this.AdminSendLetterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_letter_text;
        private System.Windows.Forms.TextBox letter_text;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label L_username;
    }
}