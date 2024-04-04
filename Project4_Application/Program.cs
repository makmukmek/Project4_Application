using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Project4_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int elem in Library.NumberLib.Divisors(12))
                Console.WriteLine(elem);

            Console.WriteLine();

            foreach (int elem in Library.NumberLib.Factorization(12))
                Console.WriteLine(elem);

            Console.WriteLine();

            foreach (int elem in Library.NumberLib.PrimeDivisors(30))
                Console.WriteLine(elem);

            Console.WriteLine();

            Console.WriteLine(Library.NumberLib.NOD(12, 10));

            Console.WriteLine();

            Console.WriteLine(Library.NumberLib.NOK(35, 15));
        }
    }
}
