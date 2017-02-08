using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Excercise1
    { 
        static void Main(string[] args)
        {
            string result = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result = result + "*";
                }
                result = result + "\n";                
            }
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
