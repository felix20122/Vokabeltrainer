using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabelTrainer
{
    class Topic
    {
        public string Name;
        public int ThemenID;
        public List<Vok> In = new List<Vok>();
        public Topic(string Name, int ThemenID)
        {
            this.Name = Name;
            this.ThemenID = ThemenID;
        }
        public Vok Zufall()
        {
            Random rnd = new Random();
            return In[rnd.Next(0, In.Count() - 1)]; // Gibt eine zufällige Vokabel zurück
        }
        
    }
}
