using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace Library
{
    public class NumberLib
    {
        /// <summary>
        /// Функция определяет является ли число простым
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>True, если число простое / False, если непростое</returns>
        private static bool IsPrime(int N)
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
        /// Функция возвращает строку со всеми делителями числа N, записанными через пробел
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Строка делителей</returns>
        public static string Divisors(int N)
        {
            //Результирующая строка, в которую будем записывать числа
            string line = "";

            //Перебрав все элементы списка, прибавляем их к строке
            foreach (int elem in _Divisors(N))
                line += elem.ToString() + " ";
            return line;
        }

        /// <summary>
        /// Функция возвращает список всех делителей числа N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Список делителей</returns>
        private static List<int> _Divisors(int N)
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
        /// Функция возвращает строку, состоящую из простых чисел на которые
        /// можно разделить число N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Строка чисел</returns>
        public static string Factorization(int N)
        {
            //Результирующая строка, в которую будем записывать числа
            string line = "";
            int counter = 1;

            //Формируем форматированную строку вида 2^2 * 3^1 (12)
            List<int> fact = _Factorization(N);
            for (int i = 1; i < fact.Count; i++)
            {
                //Если предыдущее число было равно следующему, то счётчик увеличивается
                if (fact[i - 1] == fact[i])
                    counter++;
                //В ином случае добавляем в выходную строку информацию и сбрасываем счётчик
                else
                {
                    line += fact[i - 1].ToString() + "^" + counter.ToString() + " * ";
                    counter = 1;
                }
            }
            //Добавляем к строке последнюю группу множителей
            line += fact[fact.Count - 1].ToString() + "^" + counter.ToString();
            return line;
        }

        /// <summary>
        /// Функция возвращает список простых чисел, на которые можно разложить число N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Список чисел</returns>
        private static List<int> _Factorization(int N)
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
        /// Тот же метод факторизации, но сделанный для больших целых чисел (BigInteger)
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Строка чисел</returns>
        public static string BigIntFactorization(BigInteger N)
        {
            //Результирующая строка, в которую будем записывать числа
            string line = "";
            int counter = 1;

            //Формируем форматированную строку вида 2^2 * 3^1 (12)
            List<BigInteger> fact = _BigIntFactorization(N);
            for (int i = 1; i < fact.Count; i++)
            {
                //Если предыдущее число было равно следующему, то счётчик увеличивается
                if (fact[i - 1] == fact[i])
                    counter++;
                //В ином случае добавляем в выходную строку информацию и сбрасываем счётчик
                else
                {
                    line += fact[i - 1].ToString() + "^" + counter.ToString() + " * ";
                    counter = 1;
                }
            }
            //Добавляем к строке последнюю группу множителей
            line += fact[fact.Count - 1].ToString() + "^" + counter.ToString();
            return line;
        }

        /// <summary>
        /// Тот же метод факторизации, но сделанный для больших целых чисел (BigInteger)
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Список чисел</returns>
        private static List<BigInteger> _BigIntFactorization(BigInteger N)
        {
            //Список, в который мы будем добавлять простые числа, составляющие N
            List<BigInteger> listOfPrimes = new List<BigInteger>();

            //2 - наименьшее простое число => начинаем цикл с i = 2
            for (BigInteger i = 2; i < N + 1; i++)
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
        /// Функция возвращает строку со всеми простыми числами 
        /// в диапазоне от 2 до N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Строка простых чисел</returns>
        public static string PrimeDivisors(int N)
        {
            //Результирующая строка, в которую будем записывать числа
            string line = "";

            //Перебрав все элементы списка, прибавляем их к строке
            foreach (int elem in _PrimeDivisors(N))
                line += elem.ToString() + " ";
            return line;
        }

        /// <summary>
        /// Функция возвращает список простых чисел в диапазоне от 2 до N
        /// </summary>
        /// <param name="N">Входное число</param>
        /// <returns>Список простых чисел</returns>
        private static List<int> _PrimeDivisors(int N)
        {
            //Список, в который мы будем добавлять простые числа
            List<int> primeDivisors = new List<int>();

            for (int i = 2; i < N + 1; i++)
            {
                //Если число простое, то добавляем его в список
                if (IsPrime(i))
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

        /// <summary>
        /// Функция возвращает строку с максимальными делителями чисел в заданном
        /// интервале не считая самих чисел, количество которых равно условию
        /// </summary>
        /// <param name="start">Начальная граница интервала</param>
        /// <param name="end">Конечная граница интервала</param>
        /// <param name="condition">Условие</param>
        /// <returns>Строка делителй</returns>
        public static string Problem(int start, int end, int condition) 
        {
            string line = "";

            foreach (int elem in _Problem(start, end, condition))
                line += elem.ToString() + " ";

            return line;
        }

        /// <summary>
        /// Задача: В заданном интервале найти все числа, у которых количество
        ///делителей равно условию.Вывести максимальные делители не считая самого числа.
        /// </summary>
        /// <param name="start">Начальная граница интервала</param>
        /// <param name="end">Конечная граница интервала</param>
        /// <param name="condition">Условие</param>
        /// <returns>Список делителей</returns>
        private static List<int> _Problem(int start, int end, int condition) 
        {
            List<int> numbers = new List<int>();

            //Проходим по всему интервалу, включая end
            for (int i = start; i < end + 1; i++)
            {
                List<int> div = _Divisors(i);

                //Если количество делителей равно условию, то добавляем наибольший в список
                if (div.Count == condition)
                    numbers.Add(div[div.Count - 2]);
            }
            return numbers;
        }
    }
}
