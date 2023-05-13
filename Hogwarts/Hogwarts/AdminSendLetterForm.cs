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
            Student.studentlist[0].Letter[2] = "play";
        }
    }
}
