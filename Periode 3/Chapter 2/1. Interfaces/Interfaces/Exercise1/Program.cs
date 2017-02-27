using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person test = new Customer();

            Console.WriteLine(test.Name);
            Console.WriteLine(test.Surname);
            Console.WriteLine(test.Age);

            test.Birthday();
            test.Eat();
            test.Sleep();
            
            Console.WriteLine(test.Age);

            Console.ReadKey();
        }
    }
}
