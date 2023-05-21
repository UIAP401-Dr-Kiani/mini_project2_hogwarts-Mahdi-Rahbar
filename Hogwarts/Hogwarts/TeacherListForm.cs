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
    public partial class TeacherListForm : Form
    {
        public TeacherListForm()
        {
            InitializeComponent();
        }

        private void TeacherListForm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
            foreach (Master item in Master.masterlist)
            {
                dgv_teacherList.Rows.Add("", item.Name, item.Family, item.Type);
            }
        }

        private void dgv_teacherList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_teacherList.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
        private void SetFormLocation()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
