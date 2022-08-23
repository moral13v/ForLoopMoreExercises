using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double top = 0;
            double good = 0;
            double fair = 0;
            double fail = 0;

            double totalGPA = 0;

            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5.00)
                {
                    top++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    good++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    fair++;
                }
                else if (grade < 3.00)
                {
                    fail++;
                }

                totalGPA += grade;
            }

            Console.WriteLine($"Top students: {(top / n * 100):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(good / n * 100):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(fair / n * 100):f2}%");
            Console.WriteLine($"Fail: {(fail / n * 100):f2}%");
            Console.WriteLine($"Average: {(totalGPA / n):f2}");

        }
    }
}
