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
        public SelectingRole()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            SetFormSize();
        }
        private void SetFormSize()
        {
            this.Size = new Size(1280, 720);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AllowedPersons book = new AllowedPersons();
            //List<Human> test = book.LoadJson();
            //MessageBox.Show(Convert.ToString(test[0].E_Type));
        }
    }
}
