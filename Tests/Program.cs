using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library;

namespace Tests
{
    internal class Program
    {
        static string incorrectMethods;
        static void Main()
        {
            string sw;
            do
            {
                Console.Clear();
                Console.Write($"ТЕСТИРОВАНИЕ РАБОТЫ ПРОЕКТА 4 \"Числа\"" +
                    "\nВыберите метод для тестирования:" +
                    "\n\n1. Нахождение всех делителей заданного числа." +
                    "\n2. Факторизация." +
                    "\n3. Нахождение всех простых чисел в заданном диапазоне." +
                    "\n4. Нахождение НОД." +
                    "\n5. Нахождение НОК." +
                    "\n6. Нахождение НОД и НОК." +
                    "\n7. Нахождение НОД и НОК." +
                    "\n8. Тестирование всех методов." +
                    "\n9. Выход из меню тестирования." +
                    "\n\nВведите номер действия (1 .. 9): ");
                sw = Console.ReadLine();
                switch (sw)
                {
                    case "1":
                        DividersTest();
                        break;
                    case "2":
                        FactorizationTest();
                        break;
                    case "3":
                        PrimeDivisorsTest();
                        break;
                    case "4":
                        NODTest();
                        break;
                    case "5":
                        NOKTest();
                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":
                        FullTest();
                        break;
                    case "9":
                        Console.WriteLine("ВЫХОД ИЗ МЕНЮ ТЕСТИРОВАНИЯ.");
                        Console.WriteLine("\nНажмите любую клавишу для выхода из программы . . .");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("\nУпс! Такого пункта нет в меню.");
                        break;
                }
                Console.Write($"\nНажмите любую клавишу, чтобы перейти к меню выбора методов для тестирования. . .");
                Console.ReadKey();
            }
            while (true);
        }
        static void DividersTest()
        {
            string initialNumber;
            string ansCorr;
            string ansLib;
            int count = 0;

            Console.WriteLine("\nНахождение всех делителей заданного числа");

            var dividersArr = new string[20][];
            dividersArr[0] = new string[] { "1", "1 " };
            dividersArr[1] = new string[] { "5", "1 5 " };
            dividersArr[2] = new string[] { "6", "1 2 3 6 " };
            dividersArr[3] = new string[] { "12", "1 2 3 4 6 12 " };
            dividersArr[4] = new string[] { "19", "1 19 " };
            dividersArr[5] = new string[] { "44", "1 2 4 11 22 44 " };
            dividersArr[6] = new string[] { "112", "1 2 4 7 8 14 16 28 56 112 " };
            dividersArr[7] = new string[] { "200", "1 2 4 5 8 10 20 25 40 50 100 200 " };
            dividersArr[8] = new string[] { "323", "1 17 19 323 " };
            dividersArr[9] = new string[] { "531", "1 3 9 59 177 531 " };
            dividersArr[10] = new string[] { "711", "1 3 9 79 237 711 " };
            dividersArr[11] = new string[] { "866", "1 2 433 866 " };
            dividersArr[12] = new string[] { "1020", "1 2 3 4 5 6 10 12 15 17 20 30 34 51 60 68 85 102 170 204 255 340 510 1020 " };
            dividersArr[13] = new string[] { "1059", "1 3 353 1059 " };
            dividersArr[14] = new string[] { "2345", "1 5 7 35 67 335 469 2345 " };
            dividersArr[15] = new string[] { "7777", "1 7 11 77 101 707 1111 7777 " };
            dividersArr[16] = new string[] { "58962", "1 2 3 6 31 62 93 186 317 634 951 1902 9827 19654 29481 58962 " };
            dividersArr[17] = new string[] { "200599", "1 7 28657 200599 " };
            dividersArr[18] = new string[] { "1000000", "1 2 4 5 8 10 16 20 25 32 40 50 64 80 100 125 160 200 250 320 400 500 625 800 1000 1250 1600 2000 2500 3125 4000 5000 6250 8000 10000 12500 15625 20000 25000 31250 40000 50000 62500 100000 125000 200000 250000 500000 1000000 " };
            dividersArr[19] = new string[] { "6904033", "1 6904033 " };

            foreach (var test in dividersArr)
            {
                initialNumber = test[0];
                ansCorr = test[1];
                ansLib = NumberLib.Divisors(int.Parse(initialNumber));

                Console.WriteLine($"\nЗаданное число: {initialNumber}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count += Checking(ansLib, ansCorr);
            }
            if (count == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВсе тесты завершены успешно.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОдин или несколько тестов были провалены.");
                incorrectMethods += "Dividers\n";
            }
            Console.ResetColor();

        }
        static void FactorizationTest()
        {
            string initialNumber;
            string ansCorr;
            string ansLib;
            int count = 0;

            Console.WriteLine("\nФакторизация");

            var primeFactorsArr = new string[20][];
            primeFactorsArr[0] = new string[] { "2", "2 " };
            primeFactorsArr[1] = new string[] { "3", "3 " };
            primeFactorsArr[2] = new string[] { "12", "2 2 3 " };
            primeFactorsArr[3] = new string[] { "22", "2 11 " };
            primeFactorsArr[4] = new string[] { "65", "5 13 " };
            primeFactorsArr[5] = new string[] { "99", "3 3 11 " };
            primeFactorsArr[6] = new string[] { "145", "5 29 " };
            primeFactorsArr[7] = new string[] { "460", "2 2 5 23 " };
            primeFactorsArr[8] = new string[] { "687", "3 229 " };
            primeFactorsArr[9] = new string[] { "5400", "2 2 2 3 3 3 5 5 " };
            primeFactorsArr[10] = new string[] { "6583", "29 227 " };
            primeFactorsArr[11] = new string[] { "9999", "3 3 11 101 " };
            primeFactorsArr[12] = new string[] { "786301", "17 23 2011 " };
            primeFactorsArr[13] = new string[] { "1000000", "2 2 2 2 2 2 5 5 5 5 5 5 " };
            primeFactorsArr[14] = new string[] { "1002566", "2 137 3659 " };
            primeFactorsArr[15] = new string[] { "7630001", "19 313 1283 " };
            primeFactorsArr[16] = new string[] { "9630702", "2 3 3 227 2357 " };
            primeFactorsArr[17] = new string[] { "54900475", "5 5 7 313717 " };
            primeFactorsArr[18] = new string[] { "887111477", "7 126730211 " };
            primeFactorsArr[19] = new string[] { "1662583120", "2 2 2 2 5 11 107 17657 " };

            foreach (var test in primeFactorsArr)
            {
                initialNumber = test[0];
                ansCorr = test[1];
                ansLib = NumberLib.Factorization(int.Parse(initialNumber));

                Console.WriteLine($"\nЗаданное число: {initialNumber}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count += Checking(ansLib, ansCorr);
            }
            if (count == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВсе тесты завершены успешно.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОдин или несколько тестов были провалены.");
                incorrectMethods += "Factorization\n";
            }
            Console.ResetColor();
        }
        static void PrimeDivisorsTest()
        {
            string initialNumber;
            string ansCorr;
            string ansLib;
            int count = 0;

            Console.WriteLine("\nНахождение всех простых чисел в заданном диапазоне");
            
            var primesArr = new string[20][];
            primesArr[0] = new string[] { "3", "2 3 " };
            primesArr[1] = new string[] { "10", "2 3 5 7 " };
            primesArr[2] = new string[] { "12", "2 3 5 7 11 " };
            primesArr[3] = new string[] { "20", "2 3 5 7 11 13 17 19 " };
            primesArr[4] = new string[] { "27", "2 3 5 7 11 13 17 19 23 " };
            primesArr[5] = new string[] { "30", "2 3 5 7 11 13 17 19 23 29 " };
            primesArr[6] = new string[] { "44", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 " };
            primesArr[7] = new string[] { "65", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 " };
            primesArr[8] = new string[] { "71", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 " };
            primesArr[9] = new string[] { "80", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 " };
            primesArr[10] = new string[] { "100", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 " };
            primesArr[11] = new string[] { "121", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 " };
            primesArr[12] = new string[] { "150", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 " };
            primesArr[13] = new string[] { "180", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 " };
            primesArr[14] = new string[] { "300", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199 211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 " };
            primesArr[15] = new string[] { "390", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199 211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 307 311 313 317 331 337 347 349 353 359 367 373 379 383 389 " };
            primesArr[16] = new string[] { "460", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199 211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 307 311 313 317 331 337 347 349 353 359 367 373 379 383 389 397 401 409 419 421 431 433 439 443 449 457 " };
            primesArr[17] = new string[] { "700", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199 211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 307 311 313 317 331 337 347 349 353 359 367 373 379 383 389 397 401 409 419 421 431 433 439 443 449 457 461 463 467 479 487 491 499 503 509 521 523 541 547 557 563 569 571 577 587 593 599 601 607 613 617 619 631 641 643 647 653 659 661 673 677 683 691 " };
            primesArr[18] = new string[] { "5421", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199 211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 307 311 313 317 331 337 347 349 353 359 367 373 379 383 389 397 401 409 419 421 431 433 439 443 449 457 461 463 467 479 487 491 499 503 509 521 523 541 547 557 563 569 571 577 587 593 599 601 607 613 617 619 631 641 643 647 653 659 661 673 677 683 691 701 709 719 727 733 739 743 751 757 761 769 773 787 797 809 811 821 823 827 829 839 853 857 859 863 877 881 883 887 907 911 919 929 937 941 947 953 967 971 977 983 991 997 1009 1013 1019 1021 1031 1033 1039 1049 1051 1061 1063 1069 1087 1091 1093 1097 1103 1109 1117 1123 1129 1151 1153 1163 1171 1181 1187 1193 1201 1213 1217 1223 1229 1231 1237 1249 1259 1277 1279 1283 1289 1291 1297 1301 1303 1307 1319 1321 1327 1361 1367 1373 1381 1399 1409 1423 1427 1429 1433 1439 1447 1451 1453 1459 1471 1481 1483 1487 1489 1493 1499 1511 1523 1531 1543 1549 1553 1559 1567 1571 1579 1583 1597 1601 1607 1609 1613 1619 1621 1627 1637 1657 1663 1667 1669 1693 1697 1699 1709 1721 1723 1733 1741 1747 1753 1759 1777 1783 1787 1789 1801 1811 1823 1831 1847 1861 1867 1871 1873 1877 1879 1889 1901 1907 1913 1931 1933 1949 1951 1973 1979 1987 1993 1997 1999 2003 2011 2017 2027 2029 2039 2053 2063 2069 2081 2083 2087 2089 2099 2111 2113 2129 2131 2137 2141 2143 2153 2161 2179 2203 2207 2213 2221 2237 2239 2243 2251 2267 2269 2273 2281 2287 2293 2297 2309 2311 2333 2339 2341 2347 2351 2357 2371 2377 2381 2383 2389 2393 2399 2411 2417 2423 2437 2441 2447 2459 2467 2473 2477 2503 2521 2531 2539 2543 2549 2551 2557 2579 2591 2593 2609 2617 2621 2633 2647 2657 2659 2663 2671 2677 2683 2687 2689 2693 2699 2707 2711 2713 2719 2729 2731 2741 2749 2753 2767 2777 2789 2791 2797 2801 2803 2819 2833 2837 2843 2851 2857 2861 2879 2887 2897 2903 2909 2917 2927 2939 2953 2957 2963 2969 2971 2999 3001 3011 3019 3023 3037 3041 3049 3061 3067 3079 3083 3089 3109 3119 3121 3137 3163 3167 3169 3181 3187 3191 3203 3209 3217 3221 3229 3251 3253 3257 3259 3271 3299 3301 3307 3313 3319 3323 3329 3331 3343 3347 3359 3361 3371 3373 3389 3391 3407 3413 3433 3449 3457 3461 3463 3467 3469 3491 3499 3511 3517 3527 3529 3533 3539 3541 3547 3557 3559 3571 3581 3583 3593 3607 3613 3617 3623 3631 3637 3643 3659 3671 3673 3677 3691 3697 3701 3709 3719 3727 3733 3739 3761 3767 3769 3779 3793 3797 3803 3821 3823 3833 3847 3851 3853 3863 3877 3881 3889 3907 3911 3917 3919 3923 3929 3931 3943 3947 3967 3989 4001 4003 4007 4013 4019 4021 4027 4049 4051 4057 4073 4079 4091 4093 4099 4111 4127 4129 4133 4139 4153 4157 4159 4177 4201 4211 4217 4219 4229 4231 4241 4243 4253 4259 4261 4271 4273 4283 4289 4297 4327 4337 4339 4349 4357 4363 4373 4391 4397 4409 4421 4423 4441 4447 4451 4457 4463 4481 4483 4493 4507 4513 4517 4519 4523 4547 4549 4561 4567 4583 4591 4597 4603 4621 4637 4639 4643 4649 4651 4657 4663 4673 4679 4691 4703 4721 4723 4729 4733 4751 4759 4783 4787 4789 4793 4799 4801 4813 4817 4831 4861 4871 4877 4889 4903 4909 4919 4931 4933 4937 4943 4951 4957 4967 4969 4973 4987 4993 4999 5003 5009 5011 5021 5023 5039 5051 5059 5077 5081 5087 5099 5101 5107 5113 5119 5147 5153 5167 5171 5179 5189 5197 5209 5227 5231 5233 5237 5261 5273 5279 5281 5297 5303 5309 5323 5333 5347 5351 5381 5387 5393 5399 5407 5413 5417 5419 " };
            primesArr[19] = new string[] { "6583", "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199 211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 307 311 313 317 331 337 347 349 353 359 367 373 379 383 389 397 401 409 419 421 431 433 439 443 449 457 461 463 467 479 487 491 499 503 509 521 523 541 547 557 563 569 571 577 587 593 599 601 607 613 617 619 631 641 643 647 653 659 661 673 677 683 691 701 709 719 727 733 739 743 751 757 761 769 773 787 797 809 811 821 823 827 829 839 853 857 859 863 877 881 883 887 907 911 919 929 937 941 947 953 967 971 977 983 991 997 1009 1013 1019 1021 1031 1033 1039 1049 1051 1061 1063 1069 1087 1091 1093 1097 1103 1109 1117 1123 1129 1151 1153 1163 1171 1181 1187 1193 1201 1213 1217 1223 1229 1231 1237 1249 1259 1277 1279 1283 1289 1291 1297 1301 1303 1307 1319 1321 1327 1361 1367 1373 1381 1399 1409 1423 1427 1429 1433 1439 1447 1451 1453 1459 1471 1481 1483 1487 1489 1493 1499 1511 1523 1531 1543 1549 1553 1559 1567 1571 1579 1583 1597 1601 1607 1609 1613 1619 1621 1627 1637 1657 1663 1667 1669 1693 1697 1699 1709 1721 1723 1733 1741 1747 1753 1759 1777 1783 1787 1789 1801 1811 1823 1831 1847 1861 1867 1871 1873 1877 1879 1889 1901 1907 1913 1931 1933 1949 1951 1973 1979 1987 1993 1997 1999 2003 2011 2017 2027 2029 2039 2053 2063 2069 2081 2083 2087 2089 2099 2111 2113 2129 2131 2137 2141 2143 2153 2161 2179 2203 2207 2213 2221 2237 2239 2243 2251 2267 2269 2273 2281 2287 2293 2297 2309 2311 2333 2339 2341 2347 2351 2357 2371 2377 2381 2383 2389 2393 2399 2411 2417 2423 2437 2441 2447 2459 2467 2473 2477 2503 2521 2531 2539 2543 2549 2551 2557 2579 2591 2593 2609 2617 2621 2633 2647 2657 2659 2663 2671 2677 2683 2687 2689 2693 2699 2707 2711 2713 2719 2729 2731 2741 2749 2753 2767 2777 2789 2791 2797 2801 2803 2819 2833 2837 2843 2851 2857 2861 2879 2887 2897 2903 2909 2917 2927 2939 2953 2957 2963 2969 2971 2999 3001 3011 3019 3023 3037 3041 3049 3061 3067 3079 3083 3089 3109 3119 3121 3137 3163 3167 3169 3181 3187 3191 3203 3209 3217 3221 3229 3251 3253 3257 3259 3271 3299 3301 3307 3313 3319 3323 3329 3331 3343 3347 3359 3361 3371 3373 3389 3391 3407 3413 3433 3449 3457 3461 3463 3467 3469 3491 3499 3511 3517 3527 3529 3533 3539 3541 3547 3557 3559 3571 3581 3583 3593 3607 3613 3617 3623 3631 3637 3643 3659 3671 3673 3677 3691 3697 3701 3709 3719 3727 3733 3739 3761 3767 3769 3779 3793 3797 3803 3821 3823 3833 3847 3851 3853 3863 3877 3881 3889 3907 3911 3917 3919 3923 3929 3931 3943 3947 3967 3989 4001 4003 4007 4013 4019 4021 4027 4049 4051 4057 4073 4079 4091 4093 4099 4111 4127 4129 4133 4139 4153 4157 4159 4177 4201 4211 4217 4219 4229 4231 4241 4243 4253 4259 4261 4271 4273 4283 4289 4297 4327 4337 4339 4349 4357 4363 4373 4391 4397 4409 4421 4423 4441 4447 4451 4457 4463 4481 4483 4493 4507 4513 4517 4519 4523 4547 4549 4561 4567 4583 4591 4597 4603 4621 4637 4639 4643 4649 4651 4657 4663 4673 4679 4691 4703 4721 4723 4729 4733 4751 4759 4783 4787 4789 4793 4799 4801 4813 4817 4831 4861 4871 4877 4889 4903 4909 4919 4931 4933 4937 4943 4951 4957 4967 4969 4973 4987 4993 4999 5003 5009 5011 5021 5023 5039 5051 5059 5077 5081 5087 5099 5101 5107 5113 5119 5147 5153 5167 5171 5179 5189 5197 5209 5227 5231 5233 5237 5261 5273 5279 5281 5297 5303 5309 5323 5333 5347 5351 5381 5387 5393 5399 5407 5413 5417 5419 5431 5437 5441 5443 5449 5471 5477 5479 5483 5501 5503 5507 5519 5521 5527 5531 5557 5563 5569 5573 5581 5591 5623 5639 5641 5647 5651 5653 5657 5659 5669 5683 5689 5693 5701 5711 5717 5737 5741 5743 5749 5779 5783 5791 5801 5807 5813 5821 5827 5839 5843 5849 5851 5857 5861 5867 5869 5879 5881 5897 5903 5923 5927 5939 5953 5981 5987 6007 6011 6029 6037 6043 6047 6053 6067 6073 6079 6089 6091 6101 6113 6121 6131 6133 6143 6151 6163 6173 6197 6199 6203 6211 6217 6221 6229 6247 6257 6263 6269 6271 6277 6287 6299 6301 6311 6317 6323 6329 6337 6343 6353 6359 6361 6367 6373 6379 6389 6397 6421 6427 6449 6451 6469 6473 6481 6491 6521 6529 6547 6551 6553 6563 6569 6571 6577 6581 " };


            foreach (var test in primesArr)
            {
                initialNumber = test[0];
                ansCorr = test[1];
                ansLib = NumberLib.PrimeDivisors(int.Parse(initialNumber));

                Console.WriteLine($"\nЗаданное число: {initialNumber}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count += Checking(ansLib, ansCorr);
            }
            if (count == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВсе тесты завершены успешно.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОдин или несколько тестов были провалены.");
                incorrectMethods += "PrimeDivisors\n";
            }
            Console.ResetColor();
        }
        static void NODTest()
        {
            string initialNumber1;
            string initialNumber2;
            string ansCorr;
            string ansLib;
            int count = 0;

            Console.WriteLine("\nНахождение НОД");
            var NODArr = new string[20][];
            NODArr[0] =
            NODArr[1] =
            NODArr[2] =
            NODArr[3] =
            NODArr[4] =
            NODArr[5] =
            NODArr[6] =
            NODArr[7] =
            NODArr[8] =
            NODArr[9] =
            NODArr[10] =
            NODArr[11] =
            NODArr[12] =
            NODArr[13] =
            NODArr[14] =
            NODArr[15] =
            NODArr[16] =
            NODArr[17] =
            NODArr[18] =
            NODArr[19] = new string[] { "0", "0", " " };

            foreach (var test in NODArr)
            {
                initialNumber1 = test[0];
                initialNumber2 = test[1];
                ansCorr = test[2];
                ansLib = Convert.ToString(NumberLib.NOD(int.Parse(initialNumber1), int.Parse(initialNumber2)));

                Console.WriteLine($"\nЗаданные числа: {initialNumber1}\t{initialNumber2}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count += Checking(ansLib, ansCorr);
            }
            if (count == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВсе тесты завершены успешно.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОдин или несколько тестов были провалены.");
                incorrectMethods += "NOD\n";
            }
            Console.ResetColor();
        }
        static void NOKTest()
        {
            string initialNumber1;
            string initialNumber2;
            string ansCorr;
            string ansLib;
            int count = 0;

            Console.WriteLine("\nНахождение НОД");
            var NOKArr = new string[20][];
            NOKArr[0] =
            NOKArr[1] =
            NOKArr[2] =
            NOKArr[3] =
            NOKArr[4] =
            NOKArr[5] =
            NOKArr[6] =
            NOKArr[7] =
            NOKArr[8] =
            NOKArr[9] =
            NOKArr[10] =
            NOKArr[11] =
            NOKArr[12] =
            NOKArr[13] =
            NOKArr[14] =
            NOKArr[15] =
            NOKArr[16] =
            NOKArr[17] =
            NOKArr[18] =
            NOKArr[19] = new string[] { "0", "0", " " };

            foreach (var test in NOKArr)
            {
                initialNumber1 = test[0];
                initialNumber2 = test[1];
                ansCorr = test[2];
                ansLib = Convert.ToString(NumberLib.NOK(int.Parse(initialNumber1), int.Parse(initialNumber2)));

                Console.WriteLine($"\nЗаданные числа: {initialNumber1}\t{initialNumber2}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count += Checking(ansLib, ansCorr);
            }
            if (count == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВсе тесты завершены успешно.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОдин или несколько тестов были провалены.");
                incorrectMethods += "NOK\n";
            }
            Console.ResetColor();
        }
        static void FullTest()
        {
            incorrectMethods = "";

            Console.WriteLine("\nТестирование всех методов библиотеки NumberLib"); 

            DividersTest();
            FactorizationTest();
            PrimeDivisorsTest();
            //NODTest();
            //NOKTest();




            if (incorrectMethods == "")
                Console.WriteLine("\nВсе методы работают корректно.");
            else
                Console.WriteLine("\nСледующие методы работают некорректно:\n" + incorrectMethods);
        }
        static int Checking(string s1, string s2)
        {
            if (s1 == s2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
                Console.ResetColor();
                return 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!");
                Console.ResetColor();
                return 0;
            }
        }
    }
}
