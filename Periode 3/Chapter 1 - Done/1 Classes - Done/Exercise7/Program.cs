using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            while (true)
            {
                if (counter.cnt > 50)
                {
                    counter.Reset();
                }

                Console.WriteLine(counter.ToString());
                counter.Tick();
            }
            Console.ReadKey();
        }
    }
}
