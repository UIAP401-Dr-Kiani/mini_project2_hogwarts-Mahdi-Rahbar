using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class Student : AllowedPersons
    {
        public int Course { get; set; }
        public int Term { get; set; }
        public int DormNumber { get; set; }
        public string Ticket { get; set; }
        public static List<Student> studentlist = new List<Student>();
        public static void SetStudentList()
        {
            foreach (Human item in humanslist)
            {
                if (item.Role == "student")
                {
                    studentlist.Add(new Student { Name = item.Name, Family = item.Family, Username = item.Username, Password = item.Password, E_Role = Roles.Student });
                }
            }
        }
    }
}
