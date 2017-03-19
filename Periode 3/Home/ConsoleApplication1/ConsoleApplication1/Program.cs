using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void print(string output)
        {
            Console.WriteLine(output);
        }

        static void end()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            print("Voer een datum in: Voorbeeld(23-04-1996)");
            string input = Console.ReadLine();
            print(input);

            Char split = '-';
            String[] substrings = input.Split(split);
            print("Dag: " + substrings[0]);
            print("Maand: " + substrings[1]);
            print("Jaar: " + substrings[2]);

            end();
        }
    }
}
