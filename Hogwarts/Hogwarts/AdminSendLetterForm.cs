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
    public partial class AdminSendLetterForm : Form
    {
        bool not_found = true;
        public AdminSendLetterForm()
        {
            InitializeComponent();
        }

        private void AdminSendLetterForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
            SetLocationButtonsTexbox();
        }
        private void SetFormSize()
        {
            this.Size = new Size(700, 400);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void SetLocationButtonsTexbox()
        {
            L_letter_text.Font = new Font("LetterText", 14);
            L_letter_text.Location = new Point(284, 27);
            letter_text.Font = new Font("LetterText", 12);
            letter_text.Location = new Point(150, 75);
            L_username.Font = new Font("LetterText", 14);
            L_username.Location = new Point(284, 190);
            username.Font = new Font("LetterText", 12);
            username.Location = new Point(250, 235);
            send.Font = new Font("LetterText", 12);
            send.Location = new Point(290, 280);
        }
        private void send_MouseEnter(object sender, EventArgs e)
        {
            send.BackColor = Color.FromArgb(243, 171, 31);
        }

        private void send_MouseLeave(object sender, EventArgs e)
        {
            send.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void send_Click(object sender, EventArgs e)
        {
            SendLetter();
        }
        private void SendLetter()
        {
            if (letter_text.Text == "")
            {
                MessageBox.Show("The Letter text field is empty!");
            }
            else
            {
                if (username.Text == "")
                {
                    foreach (Student item in Student.studentlist)
                    {
                        item.Letters[item.n_letters] = letter_text.Text;
                        item.n_letters += 1;
                        item.Letter_Times[item.n_letter_times] = DateTime.Now;
                        item.n_letter_times += 1;
                    }
                        MessageBox.Show("The Letter sent!");
                        not_found = false;
                        letter_text.Text = "";
                        username.Text = "";
                        return;
                }
                foreach (Student item in Student.studentlist)
                {
                    if (username.Text == item.Username)
                    {

                        item.Letters[item.n_letters] = letter_text.Text;
                        item.n_letters += 1;
                        item.Letter_Times[item.n_letter_times] = DateTime.Now;
                        item.n_letter_times += 1;
                        MessageBox.Show("The Letter sent!");
                        not_found = false;
                        letter_text.Text = "";
                        username.Text = "";
                        break;
                    }
                }
            }
            if (not_found == true && letter_text.Text != "")
            {
                MessageBox.Show("Username not found!");
            }
        }
    }
}
