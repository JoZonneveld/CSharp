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
        static void print(string output) //method
        {
            Console.WriteLine(output);
        }

        static void end()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            print("Voer een datum in: Voorbeeld(23-04-1996)"); // console.writeline
            string input = Console.ReadLine(); // maakt een nieuwe string aan
            print(input); // check

            Char split = '-'; // maakt een char aan
            String[] substrings = input.Split(split); //hier split hij de string 
            print("Dag: " + substrings[0]); // print de dag
            print("Maand: " + substrings[1]); // print de maand
            print("Jaar: " + substrings[2]);

            end();
        }
    }
}
