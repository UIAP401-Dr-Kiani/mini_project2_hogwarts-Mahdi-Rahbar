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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
            SetButtonLocation();
        }
        private void SetFormSize()
        {
            this.Size = new Size(1280, 720);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void SetButtonLocation()
        {
            send_letter.Font = new Font("SendLetter", 12);
            send_letter.Location = new Point(928, 155);
            btn_teacherList.Font = new Font("btnTeacherlist", 12);
            btn_teacherList.Location = new Point(928, 220);
            btn_studentList.Font = new Font("btnStudentlist", 12);
            btn_studentList.Location = new Point(928, 285);
        }
        private void send_letter_MouseEnter(object sender, EventArgs e)
        {
            send_letter.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void send_letter_MouseLeave(object sender, EventArgs e)
        {
            send_letter.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void send_letter_Click(object sender, EventArgs e)
        {
            AdminSendLetterForm send_letter_form = new AdminSendLetterForm();
            send_letter_form.ShowDialog();
        }

        private void btn_teacherList_MouseEnter(object sender, EventArgs e)
        {
            btn_teacherList.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void btn_teacherList_MouseLeave(object sender, EventArgs e)
        {
            btn_teacherList.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void btn_studentList_MouseEnter(object sender, EventArgs e)
        {
            btn_studentList.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void btn_studentList_MouseLeave(object sender, EventArgs e)
        {
            btn_studentList.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void btn_teacherList_Click(object sender, EventArgs e)
        {
            TeacherListForm teacherListFrm = new TeacherListForm();
            teacherListFrm.ShowDialog();
        }

        private void btn_studentList_Click(object sender, EventArgs e)
        {
            StudentListForm studentListFrm = new StudentListForm();
            studentListFrm.ShowDialog();
        }
    }
}
