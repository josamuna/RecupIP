using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace RecupIP
{
    public class Utilities
    {
        public Utilities()
        {
        }

        //Instance de la classe Utilities
        private static Utilities _instance;

        public static Utilities Instance
        {
            get 
            {
                if (_instance == null)
                    _instance = new Utilities();
                return _instance;
            }
        }

        public List<string> GeneratePoint(string[] chaine)
        {
            List<string> lstValues = new List<string>();

            foreach (string str in chaine)
            {
                StringBuilder build = new StringBuilder();

                string[] tb1 = str.Split('.');
                if (tb1.Length > 4)
                    continue;
                else if (tb1.Length == 4)
                {
                    string[] tb2 = tb1[0].Split(' ');
                    build.Append(tb2[1]);//First Octet
                    build.Append(".");
                    build.Append(tb1[1]);//Second Octet
                    build.Append(".");
                    build.Append(tb1[2]);//Third Octet
                    build.Append(".");
                    string[] tb3 = tb1[3].Split(' ');
                    build.Append(tb3[0]);//Fourth Octet

                    //Ajout de la valeur dans la liste
                    lstValues.Add(build.ToString());
                }
            }

            return SortElement(lstValues);
        }

        public List<string> GenerateCarret(string[] chaine)
        {
            List<string> lstValues = new List<string>();

            foreach (string str in chaine)
            {
                StringBuilder build = new StringBuilder();

                string[] tb1 = str.Split('|');

                lstValues.Add(build.Append(tb1[0]).ToString());
            }

            return SortElement(lstValues);
        }

        private List<string> SortElement(List<string> lstTarget)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (lstTarget.Count > 0)
            {
                for (int i = 0; i < lstTarget.Count; i++)
                {
                    for (int j = i + 1; j < lstTarget.Count; j++)
                    {
                        if (lstTarget[i].CompareTo(lstTarget[j]) < 0)//val[1] > val[j]
                        {
                            string tmp = lstTarget[i];
                            lstTarget[i] = lstTarget[j];
                            lstTarget[j] = tmp;
                        }
                    }
                }
            }
            else
                throw new Exception("Il n'y a rien a trier !!");
            sw.Stop();
            Console.WriteLine("Temp ecoule = {0}",sw.ElapsedMilliseconds/1000);
            return lstTarget;
        }

        public StringBuilder FormatString(List<string> lstValues, string chaine)
        {
            StringBuilder strValuesReturn = new StringBuilder();

            strValuesReturn.Append("ip firewall address-list \n");

            foreach (string str in lstValues)
                strValuesReturn.Append(string.Format(chaine + "\n", str));
            return strValuesReturn;
        }
    }
}
