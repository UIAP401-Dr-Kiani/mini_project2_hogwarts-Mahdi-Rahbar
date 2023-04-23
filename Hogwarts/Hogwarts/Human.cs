using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public enum Race
    {
        Halfblood,
        Pureblood,
        Muggleblood
    };
    class Human
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Father { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Race E_Type { get; set; }
        public string Type { get; set; }
        public string Role { get; set; }
    }
}

