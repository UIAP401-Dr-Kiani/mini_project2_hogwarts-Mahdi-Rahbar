using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace Hogwarts
{
    class AllowedPersons : Human
    {
        public List<Human> LoadJson()
        {
            using (StreamReader file = new StreamReader(@"E:\Daneshgah\Advanced Programming\2\Hogwarts Project\mini_project2_hogwarts-Mahdi-Rahbar\Files\JSON_DATA.json"))
            {
                string json = file.ReadToEnd();
                List<Human> humans = JsonConvert.DeserializeObject<List<Human>>(json);
                return humans;
            }
        }
    }
}
