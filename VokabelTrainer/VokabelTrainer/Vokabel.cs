using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabelTrainer
{
    class Vok
    {
        public string topic;
        public string Deutsch { get; set; }
        public string Fremdsprache { get; set; }
        public Vok (string topic, string Deutsch, string Fremdsprache)
        {
            this.topic = topic;
            this.Deutsch = Deutsch;
            this.Fremdsprache = Fremdsprache;
        }
    }
}
