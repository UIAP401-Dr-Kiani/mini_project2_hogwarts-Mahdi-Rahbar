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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
            SetSynchronicTeaching();
            GetMasterId();
            btn_selectunit.Font = new Font("SelectUnit", 12);
            btn_selectunit.Location = new Point(618, 142);

        }
        private void SetFormSize()
        {
            this.Size = new Size(1280, 720);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void SetSynchronicTeaching()
        {
            Random randomCondition = new Random();
            int randomNumber;
            foreach (Master item in Master.masterlist)
            {
                randomNumber = randomCondition.Next(0, 2);
                if (randomNumber == 0)
                {
                    item.SynchronicTeaching = false;
                }
                if (randomNumber == 1)
                {
                    item.SynchronicTeaching = true;
                }
            }
        }
        private void GetMasterId()
        {
            AllowedPersons.IMaster = 0;
            foreach (Master item in Master.masterlist)
            {
                if (item.Username == AllowedPersons.Entered)
                {
                    break;
                }
                else
                {
                    AllowedPersons.IMaster += 1;
                }
            }
        }

        private void btn_selectunit_MouseEnter(object sender, EventArgs e)
        {
            btn_selectunit.BackColor = Color.FromArgb(14, 10, 78);
        }

        private void btn_selectunit_MouseLeave(object sender, EventArgs e)
        {
            btn_selectunit.BackColor = Color.FromArgb(14, 63, 78);
        }

        private void btn_selectunit_Click(object sender, EventArgs e)
        {
            MasterSelectUnitForm selectUnitForm = new MasterSelectUnitForm();
            selectUnitForm.ShowDialog();
        }
    }
}
