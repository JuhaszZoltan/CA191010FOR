using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191010FOR
{
    class Program
    {
        static void Main()
        {
            #region 2/7. feladat
            //for(int i = 0; i <= 30; i++)
            //{
            //    Console.WriteLine("{0, 2} * {0, 2} = {1, 3}", i, i * i);
            //}
            #endregion
            #region 2/8. feladat
            //for (int i = 0; i < 30; i++)
            //{
            //    Console.WriteLine("2^{0, -2} = {1, 9}", i, Math.Pow(2, i));
            //}
            #endregion
            #region 2/9. feladat
            //for(int i = 1; i < 100; i += 2) /*i = i + 2*/
            //{
            //    Console.Write("{0, 2} ", i);
            //    if ((i + 1) % 20 == 0) Console.Write("\n");
            //}
            #endregion
            #region 2/10. feladat
            //for(int i = 99; i >= 1; i-= 2)
            //{
            //    if ((i + 1) % 20 == 0) Console.Write("\n");
            //    Console.Write("{0, 2} ", i);
            //}
            #endregion
            #region 2/11. feladat
            //for(int i = 0; i < 50; i++)
            //{
            //    Console.Write("{0, 3} ", i * 7 + 10);
            //    if((i + 1) % 10 == 0) Console.Write("\n");
            //}
            //Console.WriteLine("\n---------------------------------------");
            //for(int i = 10; i < 360; i += 7)
            //{
            //    if ((i - 10) % 70 == 0) Console.Write("\n");
            //    Console.Write("{0, 3} ", i);
            //}
            #endregion
            #region 2/12. feladat
            //Console.Write("szts első tagja: ");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.Write("differenciál: ");
            //int d = int.Parse(Console.ReadLine());

            //for(int i = 0; i < 20; i++)
            //{
            //    Console.Write("{0, 3} ", a1 + i * d);
            //    if ((i + 1) % 10 == 0) Console.Write("\n");
            //}
            #endregion
            #region 2/13. feladat
            //Console.Write("aˇ1: ");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.Write("aˇ2: ");
            //int a2 = int.Parse(Console.ReadLine());

            //int d = a2 - a1;

            //Console.WriteLine("-------------------");

            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.Write($"{a1 - i * d} ");
            //}
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write($"{a1}\n{a2} ");
            //Console.ForegroundColor = ConsoleColor.Gray;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"{a2 + i * d} ");
            //}
            //Console.Write("\n\n");
            #endregion
            #region 2/14. feladat
            //for (int i = -30; i <= 30; i++)
            //{
            //    Console.WriteLine($"{i}°C = {i * 1.8 + 32}°F");
            //}
            #endregion
            #region 2/15. feladat
            //for (int i = 12; i <= 99; i += 3)
            //{
            //    Console.Write($"{i} ");
            //    if ((i - 9) % 30 == 0) Console.Write("\n");
            //}
            #endregion
            #region 2/16. feladat
            //Console.Write("szám: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write($"{n} osztói: ");
            //if (n != 1) Console.Write("1 ");
            //for (int i = 2; i <= n / 2; i++)
            //{
            //    if (n % i == 0) Console.Write($"{i} ");
            //}
            //Console.Write($"{n}");
            #endregion
            #region 2/17. feladat
            //Console.Write("szám: ");
            //int n = int.Parse(Console.ReadLine());
            //int db = 0;
            //for(int i = 2; i <= n/2; i++)
            //{
            //    if (n % i == 0) db++;
            //}

            //if (db == 0) Console.Write($"{n} egy prímszám!");
            //else
            //{
            //    bool oszto = false;
            //    for(int i = 2; !oszto; i++)
            //    {
            //        if(n % i == 0)
            //        {
            //            Console.Write($"pl egy osztója: {i}");
            //            oszto = true;
            //        }
            //    }
            //}
            #endregion
            #region 2/18. feladat
            //Console.Write("1. szám: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("2. szám: ");
            //int b = int.Parse(Console.ReadLine());
            //if (a % b == 0) Console.WriteLine($"lnko: {b}");
            //else if (b % a == 0) Console.WriteLine($"lnko: {a}");
            //int lnko = 0;
            //for(int i = a / 2; i >= 2 && lnko == 0; i--)
            //{
            //    if (b % i == 0 && a % i == 0) lnko = i;
            //}
            //if (lnko == 0) Console.WriteLine($"{a} és {b} relatív prímek");
            //else Console.WriteLine($"{a} és {b} lnko-ja {lnko}");
            #endregion
            #region 2/19. feladat
            //int db = 0;
            //for (int i = 101; i <= 999; i += 10)
            //{
            //    Console.Write($"{i} ");
            //    db++;
            //    if (db % 10 == 0)
            //    {
            //        i++;
            //        Console.Write("\n");
            //    }
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    for(int j = 1; j <= 9; j++)
            //    {
            //        Console.Write(i*101 + j*10 + " ");
            //    }
            //}

            //int i2 = 101;
            //Console.WriteLine();
            //while (i2 < 1000)
            //{
            //    for (int n = 0; n < 10; n++)
            //    {
            //        Console.Write(i2 + " ");
            //        i2 += 10;
            //        if (n == 9)
            //        {
            //            i2++;
            //            Console.WriteLine();
            //        }
            //    }
            //}

            #endregion
            #region 2/20. feladat
            //int n1 = 1;
            //int n2 = 1;

            //Console.Write($"1 1 ");
            //for(int i = 0; i <= 20; i++)
            //{
            //    int s = n1;
            //    n1 = n2;
            //    n2 += s;
            //    Console.Write($"{n2} ");
            //}
            #endregion
            Console.ReadKey();
        }
    }
}
