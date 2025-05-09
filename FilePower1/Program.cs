using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input_path = args[0];
            string input_string;
            bool input_loop = true;
            Queue<string> string_queue = new Queue<string>();

            while(input_loop == true)
            {
                input_string = Console.ReadLine();

                if(input_string == "")
                {
                    input_loop = false;
                }
                else
                {
                    string_queue.Enqueue(input_string);
                }
            }
            File.WriteAllLines(input_path, string_queue);
        }
    }
}
