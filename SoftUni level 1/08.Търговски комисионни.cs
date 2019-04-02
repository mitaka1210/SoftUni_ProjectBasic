using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Търговски_комисионни
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            var comission = 0.0;
            if (city == "Sofia")
            {
                if (number >= 0 && number <= 500)
                {
                    comission = 0.05;
                }
                else if (number > 500 && number <= 1000)
                {
                    comission = 0.07;
                }
                else if (number > 1000 && number <= 10000)
                {
                    comission = 0.08;
                }
                else if (number > 10000)
                {
                    comission = 0.12;
                }
                Console.WriteLine("{0:F2}", comission * number);
            }
            else if (city == "Varna")
            {
                if (number >= 0 && number <= 500)
                {
                    comission = 0.45;
                }
                else if (number > 500 && number <= 1000)
                {
                    comission = 0.75;
                }
                else if (number > 1000 && number <= 10000)
                {
                    comission = 0.10;
                }
                else if (number > 10000)
                {
                    comission = 0.13;
                }
                Console.WriteLine("{0:F2}", comission * number);
            }
            else if (city == "Plovdiv")
            {
                if (number >= 0 && number <= 500)
                {
                    comission = 0.55;
                }
                else if (number > 500 && number <= 1000)
                {
                    comission = 0.08;
                }
                else if (number > 1000 && number <= 10000)
                {
                    comission = 0.12;
                }
                else if (number > 10000)
                {
                    comission = 0.145;
                }
                {
                    Console.WriteLine("{0:F2}", comission * number);
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}


