using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node test = new Node(1, new Node(2, new Node(3, new Empty())));

            Console.WriteLine(test.Value);
            /*while (test.IsEmpty == false)
            {
                Console.WriteLine(test.Value);
            }*/

            Console.ReadKey();
        }
    }
}
