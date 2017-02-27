using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big would you like your smiley to be?");
            int size = Convert.ToInt32(Console.ReadLine());

            string result = "";

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (x == 0 || x == (size - 1) || y == 0 || y == (size - 1))
                    {
                        result += "*";
                    }
                    else
                    {
                        result += " ";
                    }
                }
                result += "\n";
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
