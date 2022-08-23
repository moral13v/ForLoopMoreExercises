using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());

            //int years = endYear - 1800 + 1;
            int age = 18;
            double spendings = 0;

            for (int i = 1800; i <= endYear; i++)
            {
                if (i % 2 == 0)
                {
                    spendings += 12000;
                    age++;
                }
                else
                {
                    spendings += (12000 + age * 50);
                    age++;
                }
            }

            if (inheritance >= spendings)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(inheritance - spendings):f2} dollars left.");
            }

            else
            {
                Console.WriteLine($"He will need {Math.Abs((inheritance - spendings)):f2} dollars to survive.");
            }
        }
    }
}
