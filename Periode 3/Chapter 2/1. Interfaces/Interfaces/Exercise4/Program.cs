using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Wait test = new Wait(10);
            test.Update(10);
            Console.WriteLine("test");
            Console.ReadKey();
        }
    }
}
