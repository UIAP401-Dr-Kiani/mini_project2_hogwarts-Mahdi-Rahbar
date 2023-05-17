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
    public partial class Received_Letters_Student_Form : Form
    {
        public Received_Letters_Student_Form()
        {
            InitializeComponent();
        }

        private void Received_Letters_Student_Form_Load(object sender, EventArgs e)
        {
            DateTime fuck = DateTime.Now;
            TBX_sender.Text = fuck.ToString("HH:mm:ss");
            SetLocationUI();
            SetFormSize();
            SetLetterFeatures();
        }
        private void SetFormSize()
        {
            this.Size = new Size(800, 300);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void SetLocationUI()
        {
            BTN_next.Font = new Font("BTN_next", 12);
            BTN_next.Location = new Point(605, 130);
            BTN_back.Font = new Font("BTN_back", 12);
            BTN_back.Location = new Point(100, 130);
            TBX_sender.Font = new Font("TBX_sender", 12);
            TBX_sender.Location = new Point(100, 62);
            TBX_letter_text.Font = new Font("TBX_letter_text", 12);
            TBX_letter_text.Location = new Point(280, 63);
            TBX_time.Font = new Font("TBX_time", 12);
            TBX_time.Location = new Point(603, 62);
            L_letter_text.Font = new Font("L_letter_text", 12);
            L_letter_text.Location = new Point(350, 30);
            L_sender.Font = new Font("L_Sender", 12);
            L_sender.Location = new Point(106, 30);
            L_time.Font = new Font("L_time", 12);
            L_time.Location = new Point(620, 30);
        }
        private void SetLetterFeatures()
        {
            TBX_letter_text.Text = Student.studentlist[AllowedPersons.IStudent].Letters[0];
        }
        private void BTN_next_MouseEnter(object sender, EventArgs e)
        {
            BTN_next.BackColor = Color.FromArgb(243, 171, 31);
        }

        private void BTN_next_MouseLeave(object sender, EventArgs e)
        {
            BTN_next.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void BTN_back_MouseEnter(object sender, EventArgs e)
        {
            BTN_back.BackColor = Color.FromArgb(243, 171, 31);
        }

        private void BTN_back_MouseLeave(object sender, EventArgs e)
        {
            BTN_back.BackColor = Color.FromArgb(255, 192, 128);
        }
    }
}
