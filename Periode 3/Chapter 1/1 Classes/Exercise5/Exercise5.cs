using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            var interval = new Interval(1,10);

            Console.WriteLine(interval.Sum());

            Console.WriteLine(interval.Product());

            Console.WriteLine(interval.Begin);

            Console.WriteLine(interval.End);

            Console.ReadKey();
        }
    }
}
