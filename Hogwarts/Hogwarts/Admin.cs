using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class Admin : AllowedPersons
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        private static Admin admin_ins;
        private Admin()
        {
            Username = "admin";
            Password = "admin";
        }
        public static Admin GetIns()
        {
            if (admin_ins == null)
            {
                admin_ins = new Admin();
            }
            return admin_ins;
        }
    }
}
