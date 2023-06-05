
namespace Hogwarts
{
    partial class MasterSelectUnitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterSelectUnitForm));
            this.listOfCoursesOffered = new System.Windows.Forms.CheckedListBox();
            this.l_listOfCoursesOffered = new System.Windows.Forms.Label();
            this.listOfCoursesSelected = new System.Windows.Forms.ListBox();
            this.l_listOfCoursesSelected = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfCoursesOffered
            // 
            this.listOfCoursesOffered.BackColor = System.Drawing.Color.Teal;
            this.listOfCoursesOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listOfCoursesOffered.FormattingEnabled = true;
            this.listOfCoursesOffered.Items.AddRange(new object[] {
            "Physics 1 | 8 - 10 | monday & wednesday | 3",
            "Magic Sicence 1 | 10 - 12 | tuesday & thursday | 3",
            "Math 1 | 14 - 16 | monday & wednesday | 3",
            "Magic Science 2 | 10 - 12 | tuesday & thursday | 3",
            "Chemistry 1 | 16 - 18 | monday & wednesday | 3",
            "English 1 | 14 - 16 | tuesday & thursday | 2",
            "Physics 2  | 8 - 10 | monday & wednesday | 3",
            "Sport | 16 - 18 | friday | 1"});
            this.listOfCoursesOffered.Location = new System.Drawing.Point(234, 93);
            this.listOfCoursesOffered.Name = "listOfCoursesOffered";
            this.listOfCoursesOffered.Size = new System.Drawing.Size(530, 204);
            this.listOfCoursesOffered.TabIndex = 0;
            // 
            // l_listOfCoursesOffered
            // 
            this.l_listOfCoursesOffered.AutoSize = true;
            this.l_listOfCoursesOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_listOfCoursesOffered.ForeColor = System.Drawing.Color.White;
            this.l_listOfCoursesOffered.Location = new System.Drawing.Point(372, 49);
            this.l_listOfCoursesOffered.Name = "l_listOfCoursesOffered";
            this.l_listOfCoursesOffered.Size = new System.Drawing.Size(217, 25);
            this.l_listOfCoursesOffered.TabIndex = 1;
            this.l_listOfCoursesOffered.Text = "List Of Courses Offered";
            // 
            // listOfCoursesSelected
            // 
            this.listOfCoursesSelected.BackColor = System.Drawing.Color.Silver;
            this.listOfCoursesSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listOfCoursesSelected.FormattingEnabled = true;
            this.listOfCoursesSelected.ItemHeight = 25;
            this.listOfCoursesSelected.Location = new System.Drawing.Point(234, 396);
            this.listOfCoursesSelected.Name = "listOfCoursesSelected";
            this.listOfCoursesSelected.Size = new System.Drawing.Size(530, 104);
            this.listOfCoursesSelected.TabIndex = 2;
            // 
            // l_listOfCoursesSelected
            // 
            this.l_listOfCoursesSelected.AutoSize = true;
            this.l_listOfCoursesSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_listOfCoursesSelected.ForeColor = System.Drawing.Color.White;
            this.l_listOfCoursesSelected.Location = new System.Drawing.Point(372, 333);
            this.l_listOfCoursesSelected.Name = "l_listOfCoursesSelected";
            this.l_listOfCoursesSelected.Size = new System.Drawing.Size(229, 25);
            this.l_listOfCoursesSelected.TabIndex = 3;
            this.l_listOfCoursesSelected.Text = "List Of Courses Selected";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_save.Location = new System.Drawing.Point(827, 171);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 57);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_clear.Location = new System.Drawing.Point(827, 419);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 57);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.MouseEnter += new System.EventHandler(this.btn_clear_MouseEnter);
            this.btn_clear.MouseLeave += new System.EventHandler(this.btn_clear_MouseLeave);
            // 
            // MasterSelectUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.l_listOfCoursesSelected);
            this.Controls.Add(this.listOfCoursesSelected);
            this.Controls.Add(this.l_listOfCoursesOffered);
            this.Controls.Add(this.listOfCoursesOffered);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MasterSelectUnitForm";
            this.ShowInTaskbar = false;
            this.Text = "MasterSelectUnitForm";
            this.Load += new System.EventHandler(this.MasterSelectUnitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listOfCoursesOffered;
        private System.Windows.Forms.Label l_listOfCoursesOffered;
        private System.Windows.Forms.ListBox listOfCoursesSelected;
        private System.Windows.Forms.Label l_listOfCoursesSelected;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
    }
}