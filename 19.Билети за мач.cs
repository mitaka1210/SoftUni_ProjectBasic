using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Билети_за_мач
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int count = int.Parse(Console.ReadLine());
            //Проверяваме Вида на БИлета
            double TicketPrice = 0.0;
            if (category == "vip")
            {
                TicketPrice = 499.99;
            }
            else if (category == "normal")
            {
                TicketPrice = 249.99;
            }

            //проверяваме нашата бройка на хората
            if (count >= 1 && count <= 4)
            {
                budget = budget - (budget * (75.0 / 100.0));
            }
            else if (count >= 5 && count <= 9)
            {
                budget = budget - (budget * (60.0 / 100.0));
            }
            else if (count >= 10 && count <= 24)
            {
                budget = budget - (budget * (50.0 / 100.0));
            }
            else if (count >= 25 && count <= 49)
            {
                budget = budget - (budget * (40.0 / 100.0));
            }
            else if (count >= 50)
            {
                budget = budget - (budget * (25.0 / 100.0));
            }

            if ((TicketPrice * count) <= budget)
            {
                Console.WriteLine($" Yes!You have {budget - (TicketPrice * count):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(TicketPrice * count) - budget:F2} leva.");
            }
        }
    }
}
