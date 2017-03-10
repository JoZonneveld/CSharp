using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Truck(150.00, 13);

            bool loop = true;

            while (loop)
            {
                car.Move();
                if (car.Tank <= 0)
                {
                    loop = false;
                    car.Move();
                }
            }

            car.LoadFuel();

            Console.ReadKey();
        }
    }
}
