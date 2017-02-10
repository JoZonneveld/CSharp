using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Excercises
    {
        public static int Sum(int number1, int number2)
        {
            int output = 0;
            for (int i = number1; i <= number2; i++)
            {
                output = output + i;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw eerste nummer in: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voer uw tweede nummer in: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Het resultaat: " + Sum(number1, number2));
            Console.ReadKey();
        }
    }
}

