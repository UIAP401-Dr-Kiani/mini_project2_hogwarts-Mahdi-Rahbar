using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    enum Type
    {
        Hufflepuff,
        Gryffindor,
        Ravenclaw,
        Slytherin
    };
    class Team
    {
        public Type TeamType { get; set; }
        public int Point { get; set; }
        public List<AllowedPersons> team_members = new List<AllowedPersons>();
        public List<AllowedPersons> quidditch_members = new List<AllowedPersons>();
    }
}
