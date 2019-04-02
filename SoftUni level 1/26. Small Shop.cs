using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (town == "Sofia")
            {
                if (product == "beer")
                {
                    price = 1.20;
                    Console.WriteLine("BEER:" + price * quantity);
                }
                else if (product == "coffee")
                {
                    price = 0.50;
                    Console.WriteLine("COFFEE:" + price * quantity);
                }
                else if (product == "water")
                {
                    price = 0.80;
                    Console.WriteLine("WATER:" + price * quantity);
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                    Console.WriteLine("SWEETS:" + price * quantity);
                }
                else if (product == "peanuts")
                {
                    price = 1.60;
                    Console.WriteLine("PEANUTS:" + price * quantity);
                }

            }
            if (town == "Varna")
            {
                if (product == "beer")
                {
                    price = 1.10;
                    Console.WriteLine("BEER:" + price * quantity);
                }
                else if (product == "coffee")
                {
                    price = 0.45;
                    Console.WriteLine("COFFEE:" + price * quantity);
                }
                else if (product == "water")
                {
                    price = 0.70;
                    Console.WriteLine("WATER:" + price * quantity);
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                    Console.WriteLine("SWEETS:" + price * quantity);
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                    Console.WriteLine("PEANUTS:" + price * quantity);
                }
            }
            {
            if (town == "Plovdiv")

                {
                    if (product == "beer")
                    {
                        price = 1.15;
                        Console.WriteLine("BEER:" + price * quantity);
                    }
                    else if (product == "coffee")
                    {
                        price = 0.40;
                        Console.WriteLine("COFFEE:" + price * quantity);
                    }
                    else if (product == "water")
                    {
                        price = 0.70;
                        Console.WriteLine("WATER:" + price * quantity);
                    }
                    else if (product == "sweets")
                    {
                        price = 1.30;
                        Console.WriteLine("SWEETS:" + price * quantity);
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.50;
                        Console.WriteLine("PEANUTS:" + price * quantity);
                    }
                }
            }

        }
    }
}



