using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            // double value = 0;

            for (int i = 0; i < n; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());


                if (i % 2 == 0)
                {
                    evenSum = num1 + num2;
                }
                else
                {
                    oddSum = num1 + num2;
                }

                if (n == 1)
                {
                    Console.WriteLine($"Yes, value={evenSum}");
                    return;
                }

            }

            double diff = evenSum - oddSum;


            if (evenSum != oddSum)
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(diff)}");

            }

            else
            {
                Console.WriteLine($"Yes, value={evenSum}");

            }



        }
    }
}
