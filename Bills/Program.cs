using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricitySum = 0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricitySum += electricity;
            }

            double other = (months * 35 + electricitySum) * 1.20;
            double sum = months * 35 + electricitySum + other;

            Console.WriteLine($"Electricity: {electricitySum:f2} lv");
            Console.WriteLine($"Water: {(months * 20):f2} lv");
            Console.WriteLine($"Internet: {(months * 15):f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {(sum / months):f2} lv");
        }
    }
}
