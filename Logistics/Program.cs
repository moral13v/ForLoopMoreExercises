using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int n = int.Parse(Console.ReadLine());

            // variables


            double bus = 0;
            double truck = 0;
            double train = 0;

            double totalWeight = 0;

            // conditions

            for (int i = 1; i <= n ; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    bus += weight;
                }

                else if (weight >= 4 && weight <= 11)
                {
                    truck += weight;
                }

                else if (weight >= 12)
                {
                    train += weight;
                }

                totalWeight += weight;
            }

            // Calculations

            double averagePrice = (bus * 200 + truck * 175 + train * 120) / totalWeight;

            // output

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{(bus / totalWeight * 100):f2}%");
            Console.WriteLine($"{(truck / totalWeight * 100):f2}%");
            Console.WriteLine($"{(train / totalWeight * 100):f2}%");
        }
    }
}
