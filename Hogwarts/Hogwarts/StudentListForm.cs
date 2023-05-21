using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogwarts
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
            foreach (Student item in Student.studentlist)
            {
                dgv_studentList.Rows.Add("", item.Name, item.Family, item.Type);
            }
        }
        private void SetFormLocation()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void dgv_studentList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_studentList.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
    }
}
