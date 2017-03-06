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

            Person customer = new Customer();

            Person student = new Student();

            Person teacher = new Teacher();

            student.Eat();
            customer.Sleep();

            ((Customer)customer).Buy();
            ((Student)student).Struggle();
            ((Teacher)teacher).Nag();

            Console.ReadKey();
        }
    }
}
