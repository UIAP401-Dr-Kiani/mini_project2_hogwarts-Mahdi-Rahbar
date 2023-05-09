using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class Master : AllowedPersons
    {
        public static List<Master> masterlist = new List<Master>();
        public bool SynchronicTeaching { get; set; }
        public static void SetTeacherList()
        {
            foreach (Human item in humanslist)
            {
                if (item.Role == "teacher")
                {
                    masterlist.Add(new Master { Name = item.Name, Family = item.Family, Username = item.Username, Password = item.Password, E_Role = Roles.Teacher });
                }
            }
        }
    }
}
