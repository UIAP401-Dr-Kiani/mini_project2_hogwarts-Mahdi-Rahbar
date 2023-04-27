using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace Hogwarts
{
    enum Animal
    {
        Rat,
        Cat,
        Owl
    };
    enum Role
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
        public Role E_Role { get; set; }
        public string[] Letter { get; set; }
        public List<Human> LoadJson()
        {
            using (StreamReader file = new StreamReader(@"E:\Daneshgah\Advanced Programming\2\Hogwarts Project\mini_project2_hogwarts-Mahdi-Rahbar\Files\JSON_DATA.json"))
            {
                string json = file.ReadToEnd();
                List<Human> humans = JsonConvert.DeserializeObject<List<Human>>(json);
                foreach (Human item in humans)
                {
                    if (item.Type == "Half blood")
                        item.E_Type = Race.Halfblood;
                    else if (item.Type == "Pure blood")
                        item.E_Type = Race.Pureblood;
                    else if (item.Type == "Muggle blood")
                        item.E_Type = Race.Muggleblood;
                }
                return humans;
            }
        }
    }
}
