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

            Customer test = new Customer();
            

            Console.WriteLine(test.Name);
            Console.WriteLine(test.Surname);
            Console.WriteLine(test.Age);

            ((Person) test).Birthday();
            ((Person) test).Eat();
            ((Person) test).Sleep();

            test.Buy();
            
            Console.WriteLine(test.Age);

            Console.ReadKey();
        }
    }
}
