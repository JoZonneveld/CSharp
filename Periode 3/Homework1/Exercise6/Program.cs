﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] List = new int[5] { 1, 2, 3, 4, 5 };

            var Lijst = new IntArrayOpperations(List);

            Console.WriteLine(Lijst.Sum());
            Console.WriteLine(Lijst.Product());
            Console.ReadKey();
        }
    }
}
