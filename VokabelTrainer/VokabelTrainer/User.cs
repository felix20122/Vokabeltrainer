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
            this.ID = ID;
            this.Name = name;
            this.richtig = richtig;
        }
        //Methoden
        public void istRichtig(string deutsch, bool correct)
        {
            //Ist die Variable schonmal gemacht worden?
            if (check(deutsch))
            {
                //Richtige Antwort
                if (correct)
                {
                    for (int i = 0; i < richtig.Count; i++)
                    {
                        if (richtig[i].Split(':')[0].Equals(deutsch))
                        {
                            richtig[i] = richtig[i].Split(':')[0] + ":" + richtig[i].Split(':')[1];//+1
                        }
                    }
                        
                }
                //Falsche Antwort
                else
                {
                    for (int i = 0; i < richtig.Count; i++)
                        if (richtig[i].Split(':')[0].Equals(deutsch))
                            richtig[i] = richtig[i].Split(':')[0] + ":" + richtig[i].Split(':')[1];//-1
                }
                
            }
            else
            {
                if(correct) richtig.Add(deutsch + ":" + 1);
                else richtig.Add(deutsch + ":" + -1);

            }
        }
        bool check(string deutsch)
        {
            foreach(String i in richtig)
                if (i.Split(':')[0].Equals(deutsch)) return true;
            return false;
        }
    }
}
