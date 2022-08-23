using System;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {

            //            цвете Роза Далия Лале Нарцис Гладиола
            //Цена на брой в лева 5   3.80  2.80     3    2.50
            //Roses & q; Dahlias & q Tulips & q; Narcissus & q Gladiolus

            // Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            // Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена
            // Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            // Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            // Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %


            string nom = Console.ReadLine();
            double nombreFleurs = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double prix = 0;
            switch (nom)
            {
                case "Roses": prix += 5.00; break;
                case "Dahlias": prix += 3.80; break;
                case "Tulips": prix += 2.80; break;
                case "Narcissus": prix += 3; break;
                case "Gladiolus": prix += 2.50; break;



            }
            double Tout = nombreFleurs * prix;
            if (nom == "Roses" && nombreFleurs > 80)
            {
                Tout *= 0.90;
            }
            else if (nom == "Dahlias" && nombreFleurs > 90)
            {
                Tout *= 0.75;
            }
            else if (nom == "Tulips" && nombreFleurs > 80)
            {
                Tout *= 0.75;
            }
            else if (nom == "Narcissus" && nombreFleurs < 120)
            {
                Tout *= 1.15;
            }
            else if (nom == "Gladiolus" && nombreFleurs < 80)
            {
                Tout *= 1.20;
            }

            if (budget > Tout)
            {
                Console.WriteLine($"Hey, you have a great garden with  {Math.Abs(budget - Tout):f2} leva left.");
            }
            else if (budget < Tout)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - Tout):f2} leva more.");
            }
        }
    }
}