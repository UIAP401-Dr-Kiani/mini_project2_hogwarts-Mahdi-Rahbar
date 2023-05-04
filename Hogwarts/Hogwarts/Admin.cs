using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class Admin:AllowedPersons
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Admin()
        {
            UserName = "admin";
            Password = "admin";
        }
    }
}
