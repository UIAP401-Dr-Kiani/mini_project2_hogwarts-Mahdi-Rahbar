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
    public partial class ExpressForm : Form
    {
        DateTime ticket_time;
        DateTime nowTime;
        DateTime earlierTime;
        public ExpressForm()
        {
            InitializeComponent();
        }

        private void ExpressForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
            SetButtonsLocation();
            GetStudentId();
        }
        private void SetFormSize()
        {
            this.Size = new Size(1280, 720);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void SetButtonsLocation()
        {
            gotohogwarts.Font = new Font("gotohogwarts", 10);
            gotohogwarts.Location = new Point(113, 192);
            received_letters.Font = new Font("recivedletters", 10);
            received_letters.Location = new Point(113, 265);
            take_ticket.Font = new Font("taketicket", 10);
            take_ticket.Location = new Point(113, 338);
        }
        private void GetStudentId()
        {
            AllowedPersons.IStudent = 0;
            foreach (Student item in Student.studentlist)
            {
                if (item.Username == AllowedPersons.Entered)
                {
                    break;
                }
                else
                {
                    AllowedPersons.IStudent += 1;
                }
            }
        }
        private void TakeTicket()
        {
            Student ticket = new Student();
            int cabin_number;
            int seat_number;
            Random random_cabin_number = new Random();
            Random random_seat_number = new Random();
            cabin_number = random_cabin_number.Next(1, 9);
            seat_number = random_seat_number.Next(1, 5);
            ticket_time = DateTime.Now.AddMinutes(1);
            ticket.Ticket = "Cabin number: " + cabin_number.ToString() + "  Seat number: " + seat_number.ToString() + "  Departure time: " + ticket_time.ToString("HH:mm:ss");
            MessageBox.Show(ticket.Ticket);
        }
        private void gotohogwarts_MouseEnter(object sender, EventArgs e)
        {
            gotohogwarts.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void gotohogwarts_MouseLeave(object sender, EventArgs e)
        {
            gotohogwarts.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void received_letters_MouseEnter(object sender, EventArgs e)
        {
            received_letters.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void received_letters_MouseLeave(object sender, EventArgs e)
        {
            received_letters.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void take_ticket_MouseEnter(object sender, EventArgs e)
        {
            take_ticket.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void take_ticket_MouseLeave(object sender, EventArgs e)
        {
            take_ticket.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void received_letters_Click(object sender, EventArgs e)
        {
            if (Student.studentlist[AllowedPersons.IStudent].Letters[0] == null)
            {
                MessageBox.Show("There is no Letter!");
            }
            else if (Student.studentlist[AllowedPersons.IStudent].Letters[0] != null)
            {
                Received_Letters_Student_Form received_form = new Received_Letters_Student_Form();
                received_form.ShowDialog();

            }
        }

        private void gotohogwarts_Click(object sender, EventArgs e)
        {
            nowTime = DateTime.Now;
            if (Student.studentlist[AllowedPersons.IStudent].Letters[0] == null)
            {
                MessageBox.Show("You have not been invited to Hogwarts yet!");
            }
            else if (Student.studentlist[AllowedPersons.IStudent].Letters[0] != null && (DateTime.Compare(nowTime, ticket_time)) > 0)
            {
                MessageBox.Show("Please take a ticket!");
            }
            else if (Student.studentlist[AllowedPersons.IStudent].Letters[0] != null && (DateTime.Compare(nowTime, earlierTime)) < 0)
            {
                MessageBox.Show("The Express has not arrived yet!");
            }
            else if (Student.studentlist[AllowedPersons.IStudent].Letters[0] != null && (DateTime.Compare(nowTime, earlierTime)) > 0 && (DateTime.Compare(nowTime, ticket_time)) < 0 )
            {
                MessageBox.Show("fuck you");
            }
        }
        private void take_ticket_Click(object sender, EventArgs e)
        {
            if (Student.studentlist[AllowedPersons.IStudent].Letters[0] == null)
            {
                MessageBox.Show("You have not been invited to Hogwarts yet!");
            }
            else if (Student.studentlist[AllowedPersons.IStudent].Letters[0] != null)
            {
                TakeTicket();
                earlierTime = ticket_time.AddSeconds(-10);
            }
        }
    }
}
