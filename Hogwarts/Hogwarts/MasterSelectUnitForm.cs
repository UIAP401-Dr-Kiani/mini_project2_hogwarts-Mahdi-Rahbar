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
    public partial class MasterSelectUnitForm : Form
    {
        public MasterSelectUnitForm()
        {
            InitializeComponent();
        }

        private void MasterSelectUnitForm_Load(object sender, EventArgs e)
        {
            SetFormLocation();

        }
        private void SetFormLocation()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (listOfCoursesOffered.CheckedItems.Count == 0)
            {
                MessageBox.Show("Sorry ! you did not select any items !");
                return;
            }
            if (CheckAllowedUnits() == false)
            {
                MessageBox.Show("Sorry ! the total number of units must be less than 9 !");
                return;
            }
            if(InterferenceTime() == false)
            {
                MessageBox.Show("Sorry ! the courses you have chosen have time overlaps !");
                return;
            }
            PrintCoursesSelected();
        }
        private bool CheckAllowedUnits()
        {
            int allowedUnits = 0;
            int nItems = listOfCoursesOffered.CheckedItems.Count;
            string checkedItem;
            for (int i = 0; i < nItems; i++)
            {
                checkedItem = listOfCoursesOffered.CheckedItems[i].ToString();
                string[] split = checkedItem.Split('|');
                if (split[3] == " 3")
                {
                    allowedUnits += 3;
                }
                else if (split[3] == " 2")
                {
                    allowedUnits += 2;
                }
                else if (split[3] == " 1")
                {
                    allowedUnits += 1;
                }
                if (allowedUnits > 9)
                {
                    return false;
                }
            }
            return true;
        }
        private bool InterferenceTime()
        {
            int nItems = listOfCoursesOffered.CheckedItems.Count;
            string checkedItem;
            string day;
            string time;
            for (int j = 0; j < nItems; j++)
            {
                checkedItem = listOfCoursesOffered.CheckedItems[j].ToString();
                string[] split = checkedItem.Split('|');
                time = split[1];
                day = split[2];
                for (int i = 1 + j; i < nItems; i++)
                {
                    checkedItem = listOfCoursesOffered.CheckedItems[i].ToString();
                    string[] split2 = checkedItem.Split('|');
                    if (split2[2] == day && split2[1] == time && Master.masterlist[AllowedPersons.IMaster].SynchronicTeaching == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void PrintCoursesSelected()
        {
            listOfCoursesSelected.Items.Clear();
            int count = listOfCoursesOffered.CheckedItems.Count;
            for (int i = 0; i < count; i++)
            {
                listOfCoursesSelected.Items.Add(listOfCoursesOffered.CheckedItems[i]);
            }
        }

        private void RemoveSelectedListbox()
        {
            listOfCoursesSelected.Items.Clear();
        }

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            btn_save.BackColor = Color.FromArgb(243, 171, 31);
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            btn_save.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void btn_clear_MouseEnter(object sender, EventArgs e)
        {
            btn_clear.BackColor = Color.FromArgb(243, 171, 31);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            RemoveSelectedListbox();
        }

        private void btn_clear_MouseLeave(object sender, EventArgs e)
        {
            btn_clear.BackColor = Color.FromArgb(255, 192, 128);
        }
    }
}
