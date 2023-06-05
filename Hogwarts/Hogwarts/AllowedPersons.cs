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
        public int RoomNumber { get; set; }
        public static List<Lesson> tableschool = new List<Lesson>();
        public Animal Pet { get; set; }
        public Team Group { get; set; }
        public bool HaveSuitcase { get; set; }
        public string[] Letters = new string[100];
        public DateTime[] Letter_Times = new DateTime[100];
        public static string Entered;
        public static int IStudent = 0;
        public static int IMaster = 0;
        public int n_letters = 0;
        public int n_letter_times = 0;
    }
}
