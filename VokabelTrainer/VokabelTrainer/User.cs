using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabelTrainer
{
    class User
    {
        //Variablen
        public int ID { get; set; }
        public string Name { get; set; }
        public int exp { get; set; }  //Erfahrung und Punkte von einem User
        public List<String> richtig = new List<string>();

        //Konstruktor
        public User(int ID, String name, List<String> richtig)
        {
            ID = this.ID;
            name = this.Name;
            this.richtig = richtig;
        }
        //Methoden
        public void add(string englisch)
        {
            if (check(englisch))
            {
                for (int i = 0; i < richtig.Count; i++)
                    if (richtig[i].Split(':')[0].Equals(englisch))
                        richtig[i] = richtig[i].Split(':')[0] + richtig[i].Split(':')[1] + 1;
            }
            else
            {
                richtig.Add(englisch + ":"+1);
            }
        }
        bool check(string englisch)
        {
            foreach(String i in richtig)
                if (i.Split(':')[0].Equals(englisch)) return true;
            return false;
        }

    }
}
