
namespace Hogwarts
{
    partial class Received_Letters_Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Received_Letters_Student_Form));
            this.L_sender = new System.Windows.Forms.Label();
            this.TBX_sender = new System.Windows.Forms.TextBox();
            this.L_letter_text = new System.Windows.Forms.Label();
            this.TBX_letter_text = new System.Windows.Forms.TextBox();
            this.L_time = new System.Windows.Forms.Label();
            this.TBX_time = new System.Windows.Forms.TextBox();
            this.BTN_next = new System.Windows.Forms.Button();
            this.BTN_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_sender
            // 
            this.L_sender.AutoSize = true;
            this.L_sender.ForeColor = System.Drawing.Color.White;
            this.L_sender.Location = new System.Drawing.Point(91, 30);
            this.L_sender.Name = "L_sender";
            this.L_sender.Size = new System.Drawing.Size(54, 17);
            this.L_sender.TabIndex = 0;
            this.L_sender.Text = "Sender";
            // 
            // TBX_sender
            // 
            this.TBX_sender.HideSelection = false;
            this.TBX_sender.Location = new System.Drawing.Point(66, 63);
            this.TBX_sender.Multiline = true;
            this.TBX_sender.Name = "TBX_sender";
            this.TBX_sender.ReadOnly = true;
            this.TBX_sender.Size = new System.Drawing.Size(100, 29);
            this.TBX_sender.TabIndex = 1;
            this.TBX_sender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_letter_text
            // 
            this.L_letter_text.AutoSize = true;
            this.L_letter_text.ForeColor = System.Drawing.Color.White;
            this.L_letter_text.Location = new System.Drawing.Point(350, 30);
            this.L_letter_text.Name = "L_letter_text";
            this.L_letter_text.Size = new System.Drawing.Size(76, 17);
            this.L_letter_text.TabIndex = 2;
            this.L_letter_text.Text = "Letter Text";
            // 
            // TBX_letter_text
            // 
            this.TBX_letter_text.Location = new System.Drawing.Point(239, 63);
            this.TBX_letter_text.Multiline = true;
            this.TBX_letter_text.Name = "TBX_letter_text";
            this.TBX_letter_text.ReadOnly = true;
            this.TBX_letter_text.Size = new System.Drawing.Size(295, 137);
            this.TBX_letter_text.TabIndex = 3;
            // 
            // L_time
            // 
            this.L_time.AutoSize = true;
            this.L_time.ForeColor = System.Drawing.Color.White;
            this.L_time.Location = new System.Drawing.Point(643, 30);
            this.L_time.Name = "L_time";
            this.L_time.Size = new System.Drawing.Size(39, 17);
            this.L_time.TabIndex = 4;
            this.L_time.Text = "Time";
            // 
            // TBX_time
            // 
            this.TBX_time.Location = new System.Drawing.Point(610, 63);
            this.TBX_time.Multiline = true;
            this.TBX_time.Name = "TBX_time";
            this.TBX_time.ReadOnly = true;
            this.TBX_time.Size = new System.Drawing.Size(100, 29);
            this.TBX_time.TabIndex = 5;
            this.TBX_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_next
            // 
            this.BTN_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTN_next.Location = new System.Drawing.Point(610, 153);
            this.BTN_next.Name = "BTN_next";
            this.BTN_next.Size = new System.Drawing.Size(100, 47);
            this.BTN_next.TabIndex = 6;
            this.BTN_next.Text = "Next";
            this.BTN_next.UseVisualStyleBackColor = false;
            this.BTN_next.MouseEnter += new System.EventHandler(this.BTN_next_MouseEnter);
            this.BTN_next.MouseLeave += new System.EventHandler(this.BTN_next_MouseLeave);
            // 
            // BTN_back
            // 
            this.BTN_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTN_back.Location = new System.Drawing.Point(66, 153);
            this.BTN_back.Name = "BTN_back";
            this.BTN_back.Size = new System.Drawing.Size(100, 47);
            this.BTN_back.TabIndex = 7;
            this.BTN_back.Text = "Back";
            this.BTN_back.UseVisualStyleBackColor = false;
            this.BTN_back.MouseEnter += new System.EventHandler(this.BTN_back_MouseEnter);
            this.BTN_back.MouseLeave += new System.EventHandler(this.BTN_back_MouseLeave);
            // 
            // Received_Letters_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(782, 253);
            this.Controls.Add(this.BTN_back);
            this.Controls.Add(this.BTN_next);
            this.Controls.Add(this.TBX_time);
            this.Controls.Add(this.L_time);
            this.Controls.Add(this.TBX_letter_text);
            this.Controls.Add(this.L_letter_text);
            this.Controls.Add(this.TBX_sender);
            this.Controls.Add(this.L_sender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Received_Letters_Student_Form";
            this.ShowInTaskbar = false;
            this.Text = "Received_Letters_Student_Form";
            this.Load += new System.EventHandler(this.Received_Letters_Student_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_sender;
        private System.Windows.Forms.TextBox TBX_sender;
        private System.Windows.Forms.Label L_letter_text;
        private System.Windows.Forms.TextBox TBX_letter_text;
        private System.Windows.Forms.Label L_time;
        private System.Windows.Forms.TextBox TBX_time;
        private System.Windows.Forms.Button BTN_next;
        private System.Windows.Forms.Button BTN_back;
    }
}