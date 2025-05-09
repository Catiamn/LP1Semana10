using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input_path = args[0];
            string input_string;
            bool input_loop = true;
            using StreamWriter sw = new StreamWriter(input_path);

            while(input_loop == true)
            {
                input_string = Console.ReadLine();
                if(input_string == "")
                {
                    input_loop = false;
                }
                else
                {
                    sw.WriteLine(input_string);
                }
            }
        }
    }
}