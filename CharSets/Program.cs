using System;
using System.IO;
using System.Collections.Generic;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<char> lst = new List<char>();
            foreach (string arg in args)
            {
                try
                {
                    string fileContent = File.ReadAllText(arg);
                    foreach (char c in fileContent)
                    {
                        if (!char.IsWhiteSpace(c) && !lst.Contains(c))
                        {
                            lst.Add(c);
                        }
                    }
                }
                catch
                {
                    break;
                }
            }

            lst.Sort();
            foreach (char c in lst)
            {
                Console.WriteLine(c); 
            }
        }
    }
}
