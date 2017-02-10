using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een diameter in: ");
            int d = int.Parse(Console.ReadLine());

            string output;
            int OneThird = d / 3;
            int TwoThrird = (d / 3) * 2;
            int Middle = d / 2;

            for (int x = 0; x < d; x++)
            {
                output = "";
                for (int y = 0; y < d; y++)
                {
                    if (x == 0 || x == (d - 1) || y == 0 || y == (d - 1)) // outlining
                    {
                        output = output + "*";
                    }
                    else if (x == OneThird && y == OneThird || x == OneThird && y == TwoThrird) // eyes
                    {
                        output = output + "0";
                    }
                    else if (x == Middle && y == Middle)
                    {
                        output = output + "7";
                    }
                    else if (y >= OneThird && y <= TwoThrird && x == TwoThrird)
                    {
                        if (y == OneThird)
                        {
                            output = output + "\\";
                        }
                        else if (y == TwoThrird)
                        {
                            output = output + "/";
                        }
                        else
                        {
                            output = output + "_";
                        }
                    }
                    else
                    {
                        output = output + " ";
                    }
                }
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    }
}
