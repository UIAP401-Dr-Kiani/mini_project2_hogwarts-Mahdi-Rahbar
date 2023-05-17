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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
            SetButtonAndTexboxLocation();
        }
        private void CheckAdminInformation()
        {
            AdminForm admin_form = new AdminForm();
            if (username.Text == Admin.GetIns().Username && Password.Text == Admin.GetIns().Password)
            {
                this.Hide();
                admin_form.ShowDialog();
                this.Close();
            }
            else if (username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill in the empty field or fields.");
            }
            else
                MessageBox.Show("Not found!");
        }
        private void CheckMasterInformation()
        {
            bool notfound_message = false;
            MasterForm master_form = new MasterForm();
            if (username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill in the empty field or fields.");
            }
            foreach (Master item in Master.masterlist)
            {
                if (username.Text == item.Username && Password.Text == item.Password)
                {
                    this.Hide();
                    master_form.ShowDialog();
                    this.Close();
                    notfound_message = true;
                    break;
                }
            }
            if (notfound_message == false && username.Text != "" && Password.Text != "")
            {
                MessageBox.Show("Not found!");
            }
        }
        private void CheckStudentInformation()
        {
            bool notfound_message = false;
            ExpressForm express_form = new ExpressForm();
            if (username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill in the empty field or fields.");
            }
            foreach (Student item in Student.studentlist)
            {
                if (username.Text == item.Username && Password.Text == item.Password)
                {
                    AllowedPersons.Entered = username.Text;
                    this.Hide();
                    express_form.ShowDialog();
                    this.Close();
                    notfound_message = true;
                    break;
                }
            }
            if (notfound_message == false && username.Text != "" && Password.Text != "")
            {
                MessageBox.Show("Not found!");
            }
        }
        private void SetButtonAndTexboxLocation()
        {
            username.Font = new Font("username", 12);
            username.Location = new Point(150, 113);
            L_username.Font = new Font("L_username", 12);
            L_username.Location = new Point(168, 75);
            Password.Font = new Font("Password", 18);
            Password.Location = new Point(150, 200);
            L_password.Font = new Font("L_Password", 12);
            L_password.Location = new Point(174, 165);
            login.Font = new Font("Login button", 12);
            login.Location = new Point(160, 260);
        }
        private void SetFormSize()
        {
            this.Size = new Size(450, 400);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_MouseEnter(object sender, EventArgs e)
        {
            login.BackColor = Color.FromArgb(243, 171, 31);
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (SelectingRole.ButtonSelected == "admin")
            {
                CheckAdminInformation();
            }
            else if (SelectingRole.ButtonSelected == "master")
            {
                CheckMasterInformation();
            }
            else if (SelectingRole.ButtonSelected == "student")
            {
                CheckStudentInformation();
            }
        }
    }
}
