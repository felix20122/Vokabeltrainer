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
        String userPfad;
        public UserWriter(string userPfad)
        {
            this.userPfad = userPfad;
        }
        public void export(List<User> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UserID,Name;Richtige Vokabeln, Erfahrungspunkte,");
            foreach (User user in list)
            {
                String temp = "";
                for(int i = 0; i < user.richtig.Count; i++)
                {
                    if (!(i == user.richtig.Count - 1)) temp = temp + user.richtig[i] + "-";
                    else temp = temp + user.richtig[i];

                }
                sb.AppendLine(String.Format("{0},{1},{2},", user.ID, user.Name, temp));
            }

            File.WriteAllText(userPfad, sb.ToString());
        }
        
    }
}
