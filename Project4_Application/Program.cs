using System;
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
            Console.WriteLine(Library.NumberLib.Divisors(12));
            Console.WriteLine();

            Console.WriteLine(Library.NumberLib.Factorization(15));
            Console.WriteLine();

            Console.WriteLine(Library.NumberLib.PrimeDivisors(15));
            Console.WriteLine();

            Console.WriteLine(Library.NumberLib.NOD(12, 10));
            Console.WriteLine();

            Console.WriteLine(Library.NumberLib.NOK(35, 15));
            Console.WriteLine();

            Console.WriteLine(Library.NumberLib.Problem(1, 100000, 9));
            Console.WriteLine();
        }
    }
}
