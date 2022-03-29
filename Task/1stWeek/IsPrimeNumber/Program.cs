using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    class Program//Author By Sinan KAPUSIZ.
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Enter a number.");//Bir sayı girişi yapılıyor.
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)//Sayının kendinden başka bir sayıya bölünüp bölünmediği kontrol ediliyor.
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine($"{n} is a Prime Number");
            }
            else
            {
                Console.WriteLine($"{n} is not a Prime Number");
            }
            for (int x = 2; x < 15; x++)//Sayının asal olup olmadığı kontrol ediliyor.
            {
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    if (isPrime == 2) break;
                }
                if (isPrime != 2)
                    Console.WriteLine(x);

                isPrime = 0;
            }
            Console.ReadKey();
        }
    }
}
