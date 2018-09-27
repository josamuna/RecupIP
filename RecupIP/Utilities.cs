using System;
using System.Collections.Generic;
using System.Text;

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

        public string[] GeneratePoint(string[] chaine)
        {
            List<string> lstValues = new List<string>();
            int i = 0;

            foreach (string str in chaine)
            {
                StringBuilder build = new StringBuilder();

                if (!string.IsNullOrEmpty(str))
                {
                    string[] tb1 = str.Split('.');
                    if (tb1.Length > 4)
                    {
                        lstValues[i] = null;
                        i++;
                        continue;
                    }

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
                else
                    continue;
            }

            return SortElement(lstValues.ToArray());
        }

        public string[] GenerateCarret(string[] chaine)
        {
            string[] lstValues = new string[chaine.Length];
            int i = 0;

            foreach (string str in chaine)
            {
                StringBuilder build = new StringBuilder();

                if (!string.IsNullOrEmpty(str))
                {
                    string[] tb1 = str.Split('|');
                    build.Append(tb1[0]).ToString();

                    lstValues[i] = build.ToString();

                    i++;
                }
                else
                    continue;
            }

            return SortElement(lstValues);
        }

        //public string[] SortElement(string[] lstTarget)
        //{
        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();

        //    if (lstTarget.Length > 0)
        //    {
        //        for (int i = 0; i < lstTarget.Length; i++)
        //        {
        //            for (int j = i + 1; j < lstTarget.Length; j++)
        //            {
        //                if (lstTarget[i].CompareTo(lstTarget[j]) > 0)//val[1] > val[j]
        //                {
        //                    string tmp = lstTarget[i];
        //                    lstTarget[i] = lstTarget[j];
        //                    lstTarget[j] = tmp;
        //                }
        //            }
        //        }
        //    }
        //    else
        //        throw new Exception("Il n'y a rien a trier !!");
        //    sw.Stop();
        //    Console.WriteLine("Temp ecoule = {0}",sw.ElapsedMilliseconds/1000);
        //    return lstTarget;
        //}

        //Array.ForEach(tb, x => Console.WriteLine(x));

        private string[] SortElement(string[] lstTarget)
        {
            Array.Sort(lstTarget, CompareStringLength);

            //Array.Sort(lstTarget.ToArray(), StringComparer.InvariantCulture);
            return lstTarget;
        }

        private int CompareStringLength(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // Si x est null et y est null, alors ils sont egaux
                    return 0;
                }
                else
                {
                    // Si x est null and y ne l'est pas, alors y est plus grand que x
                    return -1;
                }
            }
            else
            {
                // Si x n'est pas null...
                if (y == null)
                // ...et y est null, alors x est plus grand
                {
                    return 1;
                }
                else
                {
                    // ...Si x et y sont non null, alors on compare leur longueur
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        // Si les deux string n'ont pas la meme taille, alors le plus long est le plus grand.
                        return retval;
                    }
                    else
                    {
                        // Si les deus string ont la meme taille, alors les compares.
                        return x.CompareTo(y);
                    }
                }
            }
        }

        public StringBuilder FormatStringList(List<string> lstValues, string chaine)
        {
            StringBuilder strValuesReturn = new StringBuilder();
            int index = 0;

            strValuesReturn.Append("ip firewall address-list \n");

            foreach (string str in lstValues)
            {
                if(index == lstValues.Count - 1)
                    strValuesReturn.Append(string.Format(chaine, str));
                else
                    strValuesReturn.Append(string.Format(chaine + "\n", str));

                index++;
            }
                
            return strValuesReturn;
        }

        public StringBuilder FormatStringTableau(string[] lstValues, string chaine)
        {
            StringBuilder strValuesReturn = new StringBuilder();
            int index = 0;

            strValuesReturn.Append("ip firewall address-list \n");

            foreach (string str in lstValues)
            {
                if (index == lstValues.Length - 1)
                    strValuesReturn.Append(string.Format(chaine, str));
                else
                    strValuesReturn.Append(string.Format(chaine + "\n", str));
                index++;
            }

            return strValuesReturn;
        }

        public string[] SearchDoublons(string[] lstItems, List<string> lstFillItems)
        {
            if (lstItems.Length == 0)
                throw new Exception("Veuillez specifier une source des données non vide svp !!!");

            foreach(string str in lstItems)
            {
                if (!lstFillItems.Exists(value => value.Equals(str)))
                    lstFillItems.Add(str);
                else
                    continue;
            }
            return lstFillItems.ToArray();
        }

        public StringBuilder AddCarretToSave(List<string> lstValues)
        {
            StringBuilder strValuesReturn = new StringBuilder();

            if (lstValues.Count == 0)
                throw new Exception("Veuillez specifier une source des données non vide svp !!!");

            int i = 0;

            foreach (string str in lstValues)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    if(i == lstValues.Count - 1)
                        strValuesReturn.Append(str + "|FRV|139026|Tor 0.3.3.6|");
                    else
                        strValuesReturn.Append(str + "|FRV|139026|Tor 0.3.3.6|\n");

                    i++;
                }
                else
                {
                    i++;
                    continue;
                }
            }

            return strValuesReturn;
        }
    }
}
