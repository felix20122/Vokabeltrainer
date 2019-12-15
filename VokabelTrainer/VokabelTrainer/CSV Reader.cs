using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VokabelTrainer
{
    class csv_Import
    {
        string Dateipfad;
        public string Error = "";
        public List<Topic> import()
        {
            //Der Import aus der CSV Datei in drei Listen wird gestartet            
            List<Vok> list = new List<Vok>();

            try
            {
                using (var reader = new StreamReader(Dateipfad))
                {
                    try
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');
                            Vok vok = new Vok(values[0], values[1], values[2]);
                            list.Add(vok);
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Error = Error + "Es gab Probleme mit dem Format der CSV Datei, überprüfe diese und probiere es noch einmal";
                    }
                }
            }
            catch
            {
                Error = Error + "Es besteht ein Problem mit dem Dateipfad, welchen du angegeben hast";
            }

            //Hier fängt das Sortieren der Themen an
            int topicsCount = 0;
            List<Topic> topics = new List<Topic>(); // intsalierung von einem String Array in einer Liste in einer Liste. Der Gedanke dahinter ist, dass in der Liste die Verschiedenen Themen gespeichert werden und der Inhalt der Themen über einen Mehrdimensolaen Array angesprochen werden kann.
            for (int i = 1; i < list.Count; i++)
            {
                if (!topics.Any(test => test.Name == list[i].topic)) // Aus List alle listen raussuchen und dann prüfen ob das erste Feld der Arrays übereinstimmt
                {
                    Topic topic = new Topic(list[i].topic, topicsCount);
                    topic.In.Add(list[i]);
                    topics.Add(topic);
                    topicsCount++;
                }
                else
                {
                    foreach (Topic topic in topics)
                    {
                        if (topic.Name == list[i].topic)
                        {
                            topic.In.Add(list[i]);
                        }
                    }
                }
            }

            return topics;
        }




        public csv_Import(string Dateipfad)
        {
            this.Dateipfad = Dateipfad;
        }
    }
}
