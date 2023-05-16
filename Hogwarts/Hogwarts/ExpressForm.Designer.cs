
namespace Hogwarts
{
    partial class ExpressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpressForm));
            this.gotohogwarts = new System.Windows.Forms.Button();
            this.received_letters = new System.Windows.Forms.Button();
            this.take_ticket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gotohogwarts
            // 
            this.gotohogwarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.gotohogwarts.ForeColor = System.Drawing.Color.White;
            this.gotohogwarts.Location = new System.Drawing.Point(105, 192);
            this.gotohogwarts.Name = "gotohogwarts";
            this.gotohogwarts.Size = new System.Drawing.Size(122, 64);
            this.gotohogwarts.TabIndex = 0;
            this.gotohogwarts.Text = "Go To Hogwarts";
            this.gotohogwarts.UseVisualStyleBackColor = false;
            this.gotohogwarts.MouseEnter += new System.EventHandler(this.gotohogwarts_MouseEnter);
            this.gotohogwarts.MouseLeave += new System.EventHandler(this.gotohogwarts_MouseLeave);
            // 
            // received_letters
            // 
            this.received_letters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.received_letters.ForeColor = System.Drawing.Color.White;
            this.received_letters.Location = new System.Drawing.Point(105, 277);
            this.received_letters.Name = "received_letters";
            this.received_letters.Size = new System.Drawing.Size(122, 63);
            this.received_letters.TabIndex = 1;
            this.received_letters.Text = "Received Letters";
            this.received_letters.UseVisualStyleBackColor = false;
            this.received_letters.Click += new System.EventHandler(this.received_letters_Click);
            this.received_letters.MouseEnter += new System.EventHandler(this.received_letters_MouseEnter);
            this.received_letters.MouseLeave += new System.EventHandler(this.received_letters_MouseLeave);
            // 
            // take_ticket
            // 
            this.take_ticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.take_ticket.ForeColor = System.Drawing.Color.White;
            this.take_ticket.Location = new System.Drawing.Point(105, 358);
            this.take_ticket.Name = "take_ticket";
            this.take_ticket.Size = new System.Drawing.Size(122, 62);
            this.take_ticket.TabIndex = 2;
            this.take_ticket.Text = "Take Ticket";
            this.take_ticket.UseVisualStyleBackColor = false;
            this.take_ticket.MouseEnter += new System.EventHandler(this.take_ticket_MouseEnter);
            this.take_ticket.MouseLeave += new System.EventHandler(this.take_ticket_MouseLeave);
            // 
            // ExpressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.take_ticket);
            this.Controls.Add(this.received_letters);
            this.Controls.Add(this.gotohogwarts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExpressForm";
            this.Text = "ExpressForm";
            this.Load += new System.EventHandler(this.ExpressForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gotohogwarts;
        private System.Windows.Forms.Button received_letters;
        private System.Windows.Forms.Button take_ticket;
    }
}