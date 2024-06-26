﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Numerics;

namespace Project4_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Делители:");
            Console.WriteLine(Library.NumberLib.Divisors(12));
            Console.WriteLine();

            Console.WriteLine("Факторизация:");
            Console.WriteLine(Library.NumberLib.Factorization(98340922));
            Console.WriteLine();

            Console.WriteLine("Факторизация BigInteger:");
            Console.WriteLine(Library.NumberLib.BigIntFactorization(563453241435));
            Console.WriteLine();

            Console.WriteLine("Простые делители:");
            Console.WriteLine(Library.NumberLib.PrimeDivisors(15));
            Console.WriteLine();

            Console.WriteLine("НОД:");
            Console.WriteLine(Library.NumberLib.NOD(1, 1));
            Console.WriteLine();

            Console.WriteLine("НОК:");
            Console.WriteLine(Library.NumberLib.NOK(35, 15));
            Console.WriteLine();

            Console.WriteLine("Задача:");
            Console.WriteLine(Library.NumberLib.Problem(1, 1000, 9));
            Console.WriteLine();
        }
    }
}
