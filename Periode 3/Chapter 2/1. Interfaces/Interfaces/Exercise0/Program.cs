using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Cat();
            animal1.SaySomething();

            Animal animal2 = new Dog();
            animal2.SaySomething();

            Animal animal3 = new Cow();
            animal3.SaySomething();

            Console.ReadKey();
        }
    }
}
