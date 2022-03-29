using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetToMeterConverter
{
    class FeetToMeterConverter//Author By Sinan KAPUSIZ.
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Your weight:");//Kilo Girişi.
                string weightValue = Console.ReadLine();
                int weight = Convert.ToInt32(weightValue);

                Console.WriteLine("Your tall (meter unit): ");//Boy, uzunluk girişi.
                double height = Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);

                Console.WriteLine("Your bmi value is " + bmi);//Kitle index gösterimi.

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
