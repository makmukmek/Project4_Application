using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class NumberLib
    {
        /// <summary>
        /// Функция определяет является ли число простым
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>True, если число простое / False, если непростое</returns>
        private static bool isPrime(int N)
        {
            //2 - наименьшее простое число => начинаем цикл с i = 2.
            //По алгоритму "Решето Эратосфена" мы можем проитерировать цикл
            //до квадратного корня из N.
            for (int i = 2; i < Math.Sqrt(N) + 1; i++)
            {
                //Если N делится на что-то кроме себя и единицы, то N не простое
                if (N % i == 0 && N != 2)
                    return false;
            }
            return true;

        }

        /// <summary>
        /// Функция возвращает список всех делителей числа N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Список делителей</returns>
        public static List<int> Divisors(int N)
        {
            //Список, в который мы будем добавлять делители числа N
            List<int> divisors = new List<int>();

            for (int i = 1; i < N + 1; i++)
            {
                //Если число N делится на меньшее, то добавляем последнее в список
                if (N % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }

        /// <summary>
        /// Функция возвращает список простых чисел, на которые можно разложить число N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Список чисел</returns>
        public static List<int> Factorization(int N) 
        {
            //Список, в который мы будем добавлять простые числа, составляющие N
            List<int> listOfPrimes = new List<int>();

            //2 - наименьшее простое число => начинаем цикл с i = 2
            for (int i = 2; i < N + 1; i++)
            {
                //Добавляем все одинаковые простые числа в список
                while (N % i == 0 && N != 1)
                {
                    listOfPrimes.Add(i);
                    N /= i;
                }
            }
            return listOfPrimes;
        }

        /// <summary>
        /// Функция возвращает список простых делителей в диапазоне от 2 до N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Список простых делителей</returns>
        public static List<int> PrimeDivisors(int N)
        {
            //Список, в который мы будем добавлять простые числа
            List<int> primeDivisors = new List<int>();

            for (int i = 2; i < N + 1; i++)
            {
                //Если число простое, то добавляем его в список
                if (isPrime(i))
                {
                    primeDivisors.Add(i);
                }
            }
            return primeDivisors;
        }

        /// <summary>
        /// Функция находит наименьший общий делитель чисел N и M
        /// </summary>
        /// <param name="N">Первое число</param>
        /// <param name="M">Второе число</param>
        /// <returns>Наименьший общий делитель</returns>
        public static int NOD(int N, int M)
        {
            //Возвращаем НОД чисел N и M
            if (N % M == 0) return M;
            if (M % N == 0) return N;

            //В этом методе используется алгоритм Евклида.
            //Вычитаем меньшее из большего, пока они не станут равны.
            if (N > M)
                //Если какое-то число больше другого, то можно сразу
                //вычесть меньшее из большего несколько раз.
                return NOD(N % M, M);
            return NOD(N, M % N);

        }

        /// <summary>
        /// Функция находит наибольшее общее кратное чисел N и M
        /// </summary>
        /// <param name="N">Первое число</param>
        /// <param name="M">Второе число</param>
        /// <returns>Наибольшее общее кратное</returns>
        public static int NOK(int N, int M)
        {
            //НОК равен произведению чисел N и M, разделённому на из НОД
            return (N * M) / NOD(N, M);
        }
    }
}
