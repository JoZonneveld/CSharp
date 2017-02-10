using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Interval
    {
        private int Begin;
        private int End;

        public Interval(int Begin , int End )
        {
            this.Begin = Begin;
            this.End = End;
        }

        public int Sum()
        {
            int output = 0;
            for (int i = this.Begin; i <= this.End; i++)
            {
                output = output + i;
            }
            return output;
        }
    }

    class Exercise5
    {
        static void Main(string[] args)
        {
            var interval = new Interval(1,3);

            Console.WriteLine(interval.Sum());

            Console.ReadKey();

        }
    }
}
