using System;
using Library;
using System.Numerics;

namespace Tests
{
    internal class Program
    {
        static string incorrectMethods;
        static int count;
        static void Main()
        {
            string sw;
            
            do
            {
                Console.Clear();
                count = 0;
                Console.Write($"ТЕСТИРОВАНИЕ РАБОТЫ ПРОЕКТА 4 \"Числа\"" +
                    "\nВыберите метод для тестирования:" +
                    "\n\n1. Нахождение всех делителей заданного числа." +
                    "\n2. Факторизация." +
                    "\n3. Нахождение всех простых чисел в заданном диапазоне." +
                    "\n4. Нахождение НОД." +
                    "\n5. Нахождение НОК." +
                    "\n6. Факторизация больших чисел." +
                    "\n7. Вывод по одному максимальному собственному делителю чисел с указанным кол-вом делителей в указанном интервале." +
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
                        BigIntFactorizationTest();
                        break;
                    case "7":
                        ProblemTest();
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
            int count1 = 0;

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
                count1 += Checking(ansLib, ansCorr);
            }
            Results("Dividers\n", count1);
        }

        static void FactorizationTest()
        {
            string initialNumber;
            string ansCorr;
            string ansLib;
            int count1 = 0;

            Console.WriteLine("\nФакторизация");

            var primeFactorsArr = new string[20][];
            primeFactorsArr[0] = new string[] { "2", "2^1" };
            primeFactorsArr[1] = new string[] { "3", "3^1" };
            primeFactorsArr[2] = new string[] { "12", "2^2 * 3^1" };
            primeFactorsArr[3] = new string[] { "22", "2^1 * 11^1" };
            primeFactorsArr[4] = new string[] { "65", "5^1 * 13^1" };
            primeFactorsArr[5] = new string[] { "99", "3^2 * 11^1" };
            primeFactorsArr[6] = new string[] { "145", "5^1 * 29^1" };
            primeFactorsArr[7] = new string[] { "460", "2^2 * 5^1 * 23^1" };
            primeFactorsArr[8] = new string[] { "687", "3^1 * 229^1" };
            primeFactorsArr[9] = new string[] { "5400", "2^3 * 3^3 * 5^2" };
            primeFactorsArr[10] = new string[] { "6583", "29^1 * 227^1" };
            primeFactorsArr[11] = new string[] { "9999", "3^2 * 11^1 * 101^1" };
            primeFactorsArr[12] = new string[] { "786301", "17^1 * 23^1 * 2011^1" };
            primeFactorsArr[13] = new string[] { "1000000", "2^6 * 5^6" };
            primeFactorsArr[14] = new string[] { "1002566", "2^1 * 137^1 * 3659^1" };
            primeFactorsArr[15] = new string[] { "7630001", "19^1 * 313^1 * 1283^1" };
            primeFactorsArr[16] = new string[] { "9630702", "2^1 * 3^2 * 227^1 * 2357^1" };
            primeFactorsArr[17] = new string[] { "54900475", "5^2 * 7^1 * 313717^1" };
            primeFactorsArr[18] = new string[] { "887111477", "7^1 * 126730211^1" };
            primeFactorsArr[19] = new string[] { "1662583120", "2^4 * 5^1 * 11^1 * 107^1 * 17657^1" };

            foreach (var test in primeFactorsArr)
            {
                initialNumber = test[0];
                ansCorr = test[1];
                ansLib = NumberLib.Factorization(int.Parse(initialNumber));

                Console.WriteLine($"\nЗаданное число: {initialNumber}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count1 += Checking(ansLib, ansCorr);
            }
            Results("Factorization\n", count1);
        }
        static void PrimeDivisorsTest()
        {
            string initialNumber;
            string ansCorr;
            string ansLib;
            int count1 = 0;

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
                count1 += Checking(ansLib, ansCorr);
            }
            Results("PrimeDivisors\n", count1);
        }
        static void NODTest()
        {
            string initialNumber1;
            string initialNumber2;
            string ansCorr;
            string ansLib;
            int count1 = 0;

            Console.WriteLine("\nНахождение НОД");
            var NODArr = new string[20][];
            NODArr[0] = new string[] { "1", "8", "1" };
            NODArr[1] = new string[] { "2", "2", "2" };
            NODArr[2] = new string[] { "7", "5", "1" };
            NODArr[3] = new string[] { "13", "26", "13" };
            NODArr[4] = new string[] { "11", "12", "1" };
            NODArr[5] = new string[] { "36", "42", "6" };
            NODArr[6] = new string[] { "7", "77", "7" };
            NODArr[7] = new string[] { "130", "443", "1" };
            NODArr[8] = new string[] { "255", "10", "5" };
            NODArr[9] = new string[] { "810", "633", "3" };
            NODArr[10] = new string[] { "1024", "1024", "1024" };
            NODArr[11] = new string[] { "2013", "3000", "3" };
            NODArr[12] = new string[] { "8018", "466", "2" };
            NODArr[13] = new string[] { "9000", "60000", "3000" };
            NODArr[14] = new string[] { "23566", "14500", "2" };
            NODArr[15] = new string[] { "100107", "6666", "3" };
            NODArr[16] = new string[] { "239987", "789332", "1" };
            NODArr[17] = new string[] { "1000000", "6000000", "1000000" };
            NODArr[18] = new string[] { "987654", "4567890", "6" };
            NODArr[19] = new string[] { "2100000", "333333", "21" };

            foreach (var test in NODArr)
            {
                initialNumber1 = test[0];
                initialNumber2 = test[1];
                ansCorr = test[2];
                ansLib = Convert.ToString(NumberLib.NOD(int.Parse(initialNumber1), int.Parse(initialNumber2)));

                Console.WriteLine($"\nЗаданные числа: {initialNumber1}\t{initialNumber2}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count1 += Checking(ansLib, ansCorr);
            }
            Results("NOD\n", count1);
        }
        static void NOKTest()
        {
            string initialNumber1;
            string initialNumber2;
            string ansCorr;
            string ansLib; 
            int count1 = 0;

            Console.WriteLine("\nНахождение НОK");
            var NOKArr = new string[20][]; 
            NOKArr[0] = new string[] { "1", "8", "8" };
            NOKArr[1] = new string[] { "2", "2", "2" };
            NOKArr[2] = new string[] { "7", "5", "35" };
            NOKArr[3] = new string[] { "13", "26", "26" };
            NOKArr[4] = new string[] { "11", "12", "132" };
            NOKArr[5] = new string[] { "36", "42", "252" };
            NOKArr[6] = new string[] { "7", "77", "77" };
            NOKArr[7] = new string[] { "130", "443", "57590" };
            NOKArr[8] = new string[] { "255", "10", "510" };
            NOKArr[9] = new string[] { "810", "633", "170910" };
            NOKArr[10] = new string[] { "1024", "1024", "1024" };
            NOKArr[11] = new string[] { "2013", "3000", "2013000" };
            NOKArr[12] = new string[] { "8018", "466", "1868194" };
            NOKArr[13] = new string[] { "9000", "60000", "180000" };
            NOKArr[14] = new string[] { "23566", "14500", "170853500" };
            NOKArr[15] = new string[] { "100107", "6666", "222437754" };
            NOKArr[16] = new string[] { "2399", "7893", "18935307" };
            NOKArr[17] = new string[] { "10000", "60000", "60000" };
            NOKArr[18] = new string[] { "98765", "4568", "451158520" };
            NOKArr[19] = new string[] { "21000", "3333", "23331000" };

            foreach (var test in NOKArr)
            {
                initialNumber1 = test[0];
                initialNumber2 = test[1];
                ansCorr = test[2];
                ansLib = Convert.ToString(NumberLib.NOK(int.Parse(initialNumber1), int.Parse(initialNumber2)));

                Console.WriteLine($"\nЗаданные числа: {initialNumber1}\t{initialNumber2}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count1 += Checking(ansLib, ansCorr);
            }
            Results("NOK\n", count1);
        }

        static void BigIntFactorizationTest()
        {
            string initialNumber;
            string ansCorr;
            string ansLib;
            int count1 = 0;

            Console.WriteLine("\nФакторизация больших чисел");

            var primeFactorsArr = new string[20][];
            primeFactorsArr[0] = new string[] { "123456789123456789", "3^2 * 7^1 * 11^1 * 13^1 * 19^1 * 3607^1 * 3803^1 * 52579^1" };
            primeFactorsArr[1] = new string[] { "35687864325168786", "2^1 * 3^1 * 19^1 * 53^1 * 199^1 * 2381^1 * 12466007^1" };
            primeFactorsArr[2] = new string[] { "55555555555555555555", "5^1 * 11^1 * 41^1 * 101^1 * 271^1 * 3541^1 * 9091^1 * 27961^1" };
            primeFactorsArr[3] = new string[] { "62626262616860", "2^2 * 5^1 * 43^2 * 167^1 * 3019^1 * 3359^1" };
            primeFactorsArr[4] = new string[] { "333333333333", "3^2 * 7^1 * 11^1 * 13^1 * 37^1 * 101^1 * 9901^1" };
            primeFactorsArr[5] = new string[] { "10000000000000", "2^13 * 5^13" };
            primeFactorsArr[6] = new string[] { "302030402004", "2^2 * 3^2 * 59^1 * 71^1 * 257^1 * 7793^1" };
            primeFactorsArr[7] = new string[] { "555555555500", "2^2 * 5^3 * 11^1 * 41^1 * 271^1 * 9091^1" };
            primeFactorsArr[8] = new string[] { "666666666666", "2^1 * 3^2 * 7^1 * 11^1 * 13^1 * 37^1 * 101^1 * 9901^1" };
            primeFactorsArr[9] = new string[] { "3300220085685", "3^1 * 5^1 * 64627^1 * 3404377^1" };
            primeFactorsArr[10] = new string[] { "658300129986", "2^1 * 3^1 * 17^1 * 23^1 * 89^1 * 421^1 * 7489^1" };
            primeFactorsArr[11] = new string[] { "999999999999001235", "5^1 * 13^1 * 17^1 * 29^1 * 43^1 * 1277^1 * 5381^1 * 105613^1" };
            primeFactorsArr[12] = new string[] { "7863012222256563125", "5^4 * 13^1 * 29^1 * 1777^1 * 75503^1 * 248723^1" };
            primeFactorsArr[13] = new string[] { "454545454454523012", "2^2 * 3^1 * 7^1 * 37^1 * 4057^1 * 123289^1 * 292393^1" };
            primeFactorsArr[14] = new string[] { "10025669898975", "3^1 * 5^2 * 17^1 * 35597^1 * 220897^1" };
            primeFactorsArr[15] = new string[] { "7630001852319", "3^3 * 7^1 * 11^1 * 61^1 * 131^1 * 459271^1" };
            primeFactorsArr[16] = new string[] { "9630702123487", "1175297^1 * 8194271^1" };
            primeFactorsArr[17] = new string[] { "549004758852", "2^2 * 3^1 * 11^2 * 19^1 * 23^1 * 41^1 * 47^1 * 449^1" };
            primeFactorsArr[18] = new string[] { "8871114770023", "11^1 * 227^1 * 35531^1 * 99989^1" };
            primeFactorsArr[19] = new string[] { "1662583120447", "37^1 * 73^1 * 1327^1 * 463861^1" };

            foreach (var test in primeFactorsArr)
            {
                initialNumber = test[0];
                ansCorr = test[1];
                ansLib = NumberLib.BigIntFactorization(BigInteger.Parse(initialNumber));

                Console.WriteLine($"\nЗаданное число: {initialNumber}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count1 += Checking(ansLib, ansCorr);
            }
            Results("BigIntFactorization\n", count1);
        }

        static void ProblemTest()
        {
            string start;
            string end;
            string amountOfDividers;
            string ansCorr;
            string ansLib;
            int count1 = 0;

            Console.WriteLine("\nВывод по одному максимальному собственному делителю чисел с указанным кол-вом делителей в указанном интервале.");

            var maxDivsArr = new string[20][];
            maxDivsArr[0] = new string[] { "0", "8", "2", "1 1 1 1 " };
            maxDivsArr[1] = new string[] { "12", "30", "4", "7 5 7 11 13 9 " };
            maxDivsArr[2] = new string[] { "20", "41", "8", "12 15 20 " };
            maxDivsArr[3] = new string[] { "28", "48", "2", "1 1 1 1 1 1 " };
            maxDivsArr[4] = new string[] { "72", "104", "12", "36 42 45 48 " };
            maxDivsArr[5] = new string[] { "97", "100", "6", "49 33 " };
            maxDivsArr[6] = new string[] { "112", "150", "10", "56 " };
            maxDivsArr[7] = new string[] { "120", "130", "4", "61 41 25 43 " };
            maxDivsArr[8] = new string[] { "301", "396", "16", "156 165 189 192 195 " };
            maxDivsArr[9] = new string[] { "400", "455", "15", "200 " };
            maxDivsArr[10] = new string[] { "1", "3", "5", "Таких чисел нет" };
            maxDivsArr[11] = new string[] { "462", "520", "16", "231 255 260 " };
            maxDivsArr[12] = new string[] { "501", "537", "4", "167 251 101 73 257 103 47 173 263 31 41 107 179 " };
            maxDivsArr[13] = new string[] { "543", "600", "12", "272 275 279 282 286 290 195 " };
            maxDivsArr[14] = new string[] { "600", "700", "24", "300 315 330 336 " };
            maxDivsArr[15] = new string[] { "676", "696", "2", "1 1 1 " };
            maxDivsArr[16] = new string[] { "710", "748", "8", "355 356 143 365 247 371 " };
            maxDivsArr[17] = new string[] { "750", "800", "10", "376 " };
            maxDivsArr[18] = new string[] { "801", "900", "20", "405 408 440 " };
            maxDivsArr[19] = new string[] { "901", "1000", "24", "462 468 495 " };

            foreach (var test in maxDivsArr)
            {
                start = test[0];
                end = test[1];
                amountOfDividers = test[2];
                ansCorr = test[3];
                ansLib = NumberLib.Problem(int.Parse(start), int.Parse(end), int.Parse(amountOfDividers));

                Console.WriteLine($"\nНачало интервала: {start}");
                Console.WriteLine($"Конец интервала: {end}");
                Console.WriteLine($"Заданное число делителей: {amountOfDividers}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count1 += Checking(ansLib, ansCorr);
            }
            Results("Problem\n", count1);
        }

        static void FullTest()
        {
            incorrectMethods = "";

            Console.WriteLine("\nТестирование всех методов библиотеки NumberLib"); 

            DividersTest();
            FactorizationTest();
            PrimeDivisorsTest();
            NODTest();
            NOKTest();
            BigIntFactorizationTest();
            ProblemTest();

            if (incorrectMethods == "")
                Console.WriteLine("\nВсе методы работают корректно.");
            else
                Console.WriteLine($"\n{count} тест(ов) были провалены.\nСледующие методы работают некорректно:\n" + incorrectMethods);
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
        static void Results(string method, int currCount)
        {
            if (currCount == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВсе тесты завершены успешно.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{20 - currCount} тест(ов) были провалены.");
                count += 20 - currCount;
                incorrectMethods += method;
            }
            Console.ResetColor();
        }
    }
}
