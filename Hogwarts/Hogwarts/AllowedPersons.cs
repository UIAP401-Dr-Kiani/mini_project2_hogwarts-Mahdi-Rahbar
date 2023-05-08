using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hogwarts
{
    public enum Animal
    {
        Rat,
        Cat,
        Owl
    };
    public enum Roles
    {
        Teacher,
        Student
    };
    class AllowedPersons : Human
    {
        public String RoomNumber { get; set; }
        public String SchoolTable { get; set; }
        public Animal Pet { get; set; }
        public Team Group { get; set; }
        public bool HaveSuitcase { get; set; }
        public string[] Letter { get; set; }
    }
}
