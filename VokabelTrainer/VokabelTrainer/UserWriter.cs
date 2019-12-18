using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabelTrainer
{
    class UserWriter
    {
        public UserWriter(string userPfad, List<User> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UserID;Name;Richtige Vokabeln; Erfahrungspunkte;");
            foreach (User user in list)
            {
                String temp = "";
                foreach (String s in user.richtig)
                {
                    temp += s + "-";
                }
                sb.AppendLine(String.Format("{0};{1};{2};", user.ID, user.Name, temp));
            }
            File.WriteAllText(userPfad, sb.ToString());
        }
        
    }
}
