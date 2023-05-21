
namespace Hogwarts
{
    partial class StudentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentListForm));
            this.dgv_studentList = new System.Windows.Forms.DataGridView();
            this.c_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_studentList
            // 
            this.dgv_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_number,
            this.c_name,
            this.c_family,
            this.c_type});
            this.dgv_studentList.Location = new System.Drawing.Point(12, 12);
            this.dgv_studentList.Name = "dgv_studentList";
            this.dgv_studentList.RowHeadersWidth = 51;
            this.dgv_studentList.RowTemplate.Height = 24;
            this.dgv_studentList.Size = new System.Drawing.Size(758, 429);
            this.dgv_studentList.TabIndex = 0;
            this.dgv_studentList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_studentList_CellFormatting);
            // 
            // c_number
            // 
            this.c_number.HeaderText = "";
            this.c_number.MinimumWidth = 6;
            this.c_number.Name = "c_number";
            this.c_number.Width = 80;
            // 
            // c_name
            // 
            this.c_name.HeaderText = "Name";
            this.c_name.MinimumWidth = 6;
            this.c_name.Name = "c_name";
            this.c_name.Width = 212;
            // 
            // c_family
            // 
            this.c_family.HeaderText = "Family";
            this.c_family.MinimumWidth = 6;
            this.c_family.Name = "c_family";
            this.c_family.Width = 212;
            // 
            // c_type
            // 
            this.c_type.HeaderText = "Type";
            this.c_type.MinimumWidth = 6;
            this.c_type.Name = "c_type";
            this.c_type.Width = 201;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.dgv_studentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentListForm";
            this.ShowInTaskbar = false;
            this.Text = "StudentListForm";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_studentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_family;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_type;
    }
}