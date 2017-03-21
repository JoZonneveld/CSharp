using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Op = "";
            Console.WriteLine("voer een eerste getal in: ");
            int x = Int32.Parse(Console.ReadLine());
            while (Op != "*" && Op != "/" && Op != "+" && Op != "-")
            {
                Console.WriteLine("voer een operator in: (/,*,-,+) ");
                Op = Console.ReadLine();
            }
            Console.WriteLine("Voer een 2e getal in: ");
            int y = Int32.Parse(Console.ReadLine());



            //Console.WriteLine(x + Op + y + "=");

            if (Op == "/")
            {
                int output = x / y;
                Console.WriteLine(x+Op+y + "="+ output);
            }
            else if (Op == "*")
            {
                int output = x * y;
                Console.WriteLine(x + Op + y + "=" + output);
            }
            else if (Op == "+")
            {
                int output = x + y;
                Console.WriteLine(x + Op + y + "=" + output);
            }
            else if (Op == "-")
            {
                int output = x - y;
                Console.WriteLine(x + Op + y + "=" + output);
            }
            else
            {
                Console.WriteLine("ERROOOORRRR");
            }
            Console.ReadKey();
        }
    }
}
