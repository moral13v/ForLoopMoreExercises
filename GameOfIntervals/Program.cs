using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //double points = 0;
            double result = 0;
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;
            double counter6 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    result += number * 0.2;
                    counter1++;
                }
                else if (number >= 10 && number <= 19)
                {
                    result += number * 0.3;
                    counter2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    result += number * 0.4;
                    counter3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    result += 50;
                    counter4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    result += 100;
                    counter5++;
                }
                else
                {
                    result /= 2;
                    counter6++;
                }
            }

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(counter1 / n * 100):f2}%");
            Console.WriteLine($"From 10 to 19: {(counter2 / n * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {(counter3 / n * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {(counter4 / n * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {(counter5 / n * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {(counter6 / n * 100):f2}%");

        }
    }
}
