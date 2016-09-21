using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace W3Day3Shakespeare
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose which section to test.");
            while (true)
            { 

            switch (Menu())
                {
                    case 1:
                        PrintFirstLine();
                        break;

                    case 2:
                        PrintEntireFile();
                        break;

                    case 3:
                        CapitalizeVowels();
                        break;

                }
            }
        }

        public static void PrintFirstLine()
        {
            StreamReader reader = new StreamReader(("..\\..\\..\\Shakespeare.txt"));
            string line = reader.ReadLine();
            reader.Close();
            Console.WriteLine(line);
        }
        public static void PrintEntireFile()
        {
            StreamReader reader = new StreamReader(("..\\..\\..\\Shakespeare.txt"));
            string line = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(line);
        }
        public static void CapitalizeVowels()
        {
            StreamReader reader = new StreamReader(("..\\..\\..\\Shakespeare.txt"));
            string line = reader.ReadToEnd();
            reader.Close();

            // Replace each lower case vowel.
            line = (line.Replace("a", "A"));
            line = (line.Replace("e", "E"));
            line = (line.Replace("i", "I"));
            line = (line.Replace("o", "O"));
            line = (line.Replace("u", "U"));

            Console.WriteLine(line);
        }
        public static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1.\tRead and print the first line from the file only.");
            Console.WriteLine("2.\tRead and print the entire text file.");
            Console.WriteLine("3.\tRead and print the entire text file and capitalize all lowercase vowels.");
            Console.WriteLine("4.\tQuit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 4)
            {
                System.Environment.Exit(0);
            }
            return choice;
        }

    }
}
