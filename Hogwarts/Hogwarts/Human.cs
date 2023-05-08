using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
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
        public Roles E_Role { get; set; }
        public string Type { get; set; }
        public string Role { get; set; }
        public static List<Human> humanslist = new List<Human>();
        public static void LoadJson()
        {
            using (StreamReader file = new StreamReader(@"E:\Daneshgah\Advanced Programming\2\Hogwarts Project\mini_project2_hogwarts-Mahdi-Rahbar\Files\JSON_DATA.json"))
            {
                string json = file.ReadToEnd();
                humanslist = JsonConvert.DeserializeObject<List<Human>>(json);
                foreach (Human item in humanslist)
                {
                    if (item.Type == "Half blood")
                        item.E_Type = Race.Halfblood;
                    else if (item.Type == "Pure blood")
                        item.E_Type = Race.Pureblood;
                    else if (item.Type == "Muggle blood")
                        item.E_Type = Race.Muggleblood;
                    else if (item.Role == "teacher")
                        item.E_Role = Roles.Teacher;
                    else if (item.Role == "student")
                        item.E_Role = Roles.Student;
                }
            }
        }
    }
}

