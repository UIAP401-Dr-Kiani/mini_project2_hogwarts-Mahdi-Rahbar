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
    public partial class SelectingRole : Form
    {
        public static string ButtonSelected { get; set; }
        public SelectingRole()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            SetButtonsLocation();
            SetFormSize();
        }
        private void SetFormSize()
        {
            this.Size = new Size(1280, 720);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void SetButtonsLocation()
        {
            admin.Font = new Font("Admin", 12);
            admin.Location = new Point(1024, 321);
            notice.Location = new Point(970, 280);
            notice.Font = new Font("Notice", 14);
            master.Font = new Font("Master", 12);
            master.Location = new Point(1024, 391);
            student.Font = new Font("Master", 12);
            student.Location = new Point(1024, 461);
        }
        private void admin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            ButtonSelected = "admin";
            login.ShowDialog();
        }
        private void admin_MouseEnter(object sender, EventArgs e)
        {
            admin.BackColor = Color.FromArgb(14, 10, 78);
        }
        private void admin_MouseLeave(object sender, EventArgs e)
        {
            admin.BackColor = Color.FromArgb(14, 63, 78);
        }
        private void master_MouseEnter(object sender, EventArgs e)
        {
            master.BackColor = Color.FromArgb(14, 10, 78);
        }
        private void master_MouseLeave(object sender, EventArgs e)
        {
            master.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void student_MouseEnter(object sender, EventArgs e)
        {
            student.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void student_MouseLeave(object sender, EventArgs e)
        {
            student.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void master_Click(object sender, EventArgs e)
        {
            ButtonSelected = "master";
        }

        private void student_Click(object sender, EventArgs e)
        {
            ButtonSelected = "student";
        }
    }
}
