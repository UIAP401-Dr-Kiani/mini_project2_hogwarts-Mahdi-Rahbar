
namespace Hogwarts
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.btn_selectunit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_selectunit
            // 
            this.btn_selectunit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.btn_selectunit.Location = new System.Drawing.Point(618, 142);
            this.btn_selectunit.Name = "btn_selectunit";
            this.btn_selectunit.Size = new System.Drawing.Size(157, 63);
            this.btn_selectunit.TabIndex = 0;
            this.btn_selectunit.Text = "Select Unit";
            this.btn_selectunit.UseVisualStyleBackColor = false;
            this.btn_selectunit.Click += new System.EventHandler(this.btn_selectunit_Click);
            this.btn_selectunit.MouseEnter += new System.EventHandler(this.btn_selectunit_MouseEnter);
            this.btn_selectunit.MouseLeave += new System.EventHandler(this.btn_selectunit_MouseLeave);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btn_selectunit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selectunit;
    }
}