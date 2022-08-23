using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            double counterA = 0;
            double counterB = 0;
            double counterV = 0;
            double counterG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        counterA++;
                        break;
                    case "B":
                        counterB++;
                        break;
                    case "V":
                        counterV++;
                        break;
                    case "G":
                        counterG++;
                        break;
                }
            }

            Console.WriteLine($"{(counterA / fans * 100):f2}% ");
            Console.WriteLine($"{(counterB / fans * 100):f2}% ");
            Console.WriteLine($"{(counterV / fans * 100):f2}% ");
            Console.WriteLine($"{(counterG / fans * 100):f2}% ");
            Console.WriteLine($"{(fans * 100.0 / capacity):f2}% ");


        }
    }
}
