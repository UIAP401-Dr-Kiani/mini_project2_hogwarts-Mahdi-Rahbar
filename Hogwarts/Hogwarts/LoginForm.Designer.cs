
namespace Hogwarts
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.username = new System.Windows.Forms.TextBox();
            this.L_username = new System.Windows.Forms.Label();
            this.L_password = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(127, 95);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(167, 40);
            this.username.TabIndex = 0;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.ForeColor = System.Drawing.Color.White;
            this.L_username.Location = new System.Drawing.Point(173, 60);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(73, 17);
            this.L_username.TabIndex = 1;
            this.L_username.Text = "Username";
            this.L_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_password
            // 
            this.L_password.AutoSize = true;
            this.L_password.ForeColor = System.Drawing.Color.White;
            this.L_password.Location = new System.Drawing.Point(173, 159);
            this.L_password.Name = "L_password";
            this.L_password.Size = new System.Drawing.Size(69, 17);
            this.L_password.TabIndex = 2;
            this.L_password.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(127, 197);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(167, 40);
            this.Password.TabIndex = 3;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.login.Location = new System.Drawing.Point(141, 269);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(138, 49);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseEnter += new System.EventHandler(this.login_MouseEnter);
            this.login.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.L_password);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label L_username;
        private System.Windows.Forms.Label L_password;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button login;
    }
}