﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stWeek
{
    class Week1st//Author By Sinan KAPUSIZ.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kodla, Kariyerine Başla C# ile .NET Core Bootcamp");
            //sayısal veri tipleri
            byte age = 255;
            sbyte negativeNumber = -4;

            short length = -32768;

            ushort unsignedShort = 65535;

            int totalYear = 1000000000;


            long watchCount = 100000000000;

            double pi = 3.14;
            float discount = 0.15f;
            decimal formulaConstant = 0.000000000000000001M;



            //sözel
            char character = 'p';
            string word = "Türkay Ürkmez";



            //mantıksal
            bool isClosed = true;

            /*
             * Amaç: Kullanıcının boy ve kilosuna göre BMI hesaplamak
             */
            try
            {
                Console.WriteLine("Your weight:");
                string weightValue = Console.ReadLine();
                int weight = Convert.ToInt32(weightValue);

                Console.WriteLine("Your tall (meter unit): ");
                double height = Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);

                Console.WriteLine("Your bmi value is " + bmi);

                if (bmi < 18.5)
                {
                    Console.WriteLine("You are Underweight");
                }
                else if (bmi <= 24.9)
                {
                    Console.WriteLine("You are normal weight");
                }
                else if (bmi <= 29.9)
                {
                    Console.WriteLine("You are overweight");
                }
                else
                {
                    Console.WriteLine("You are obese");

                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Please give values with true format");
            }
        }
    }
}
