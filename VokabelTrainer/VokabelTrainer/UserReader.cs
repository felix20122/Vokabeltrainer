using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabelTrainer
{
    class UserReader
    {
        public List<User> import(string DateipfadUser)
        {
            //Der Import aus der CSV Datei in drei Listen wird gestartet            
            List<User> list = new List<User>();
            string Error = "";

            try
            {
                using (var reader = new StreamReader(DateipfadUser))
                {
                    try
                    {
                        reader.ReadLine(); //Überspringt die erste Zeile
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');
                            List<String> richtig = new List<String>();
                            var tempArr = values[2].Split('-');
                            for(int i = 0; i < tempArr.Length; i++)
                            {
                                richtig.Add(tempArr[i]);
                            }
                            User user = new User(Int32.Parse(values[0]), values[1], richtig);

                            list.Add(user);
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
            return list;
        }
    }
}
