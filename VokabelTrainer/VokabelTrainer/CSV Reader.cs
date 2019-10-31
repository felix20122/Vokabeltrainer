using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VokabelTrainer
{
    class CSV_Reader
    {
        public void import(string Dateipfad)
        {
            //Der Import aus der CSV Datei in drei Listen wird gestartet
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            List<string> listC = new List<string>();
            using (var reader = new StreamReader(Dateipfad))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                    listC.Add(values[2]);
                }
            }
            //Die Länge von der Liste A wird gespeichert, da bei einem Mehrdimensonalen Array alle Spalten gezählt werden und somit kein Zugriff bei einer For Schleife auf Array.Count gibt
            int arrayLaenge = listA.Count;
            //Der Array wird anhand der Länge von Liste A Instalisert und der Anzahl der Spalten
            string[,] array = new string[arrayLaenge, 3];
            //Die Listen werden in den Array eingelesen
            for (int e = 0; e < arrayLaenge; e++)
            {
                array[e, 0] = listA[e];
                array[e, 1] = listB[e];
                array[e, 2] = listC[e];
            }
            //Es wird ein Inhaltsverzeichnis erstellt, mit welchem sich die Vokabelen in Verschiedenen Themen sortieren lässt
            List<int> Nomen = new List<int>();
            List<int> Verben = new List<int>();
            List<int> Sonstige = new List<int>();

            for (int e = 1; e < arrayLaenge; e++)
            {
                switch (array[e, 0])
                {
                    case "Nomen":
                        Nomen.Add(e);
                        break;
                    case "Verben":
                        Verben.Add(e);
                        break;
                    default:
                        Sonstige.Add(e);
                        break;
                }
            }
            //Zugriff über das Inhaltverzeichnis: array[Nomen[e],1] array[Nomen[e], 2]
        }
    }
}
