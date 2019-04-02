using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable__Плод_или_зеленчук_
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            //string b = ("tomato, cucumber, pepper, carrot");

            if (n == "banana" || n == "kiwi" || n == "apple" || n == "cherry" || n == "lemon" || n == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (n == "tomato" || n == "cucumber" || n == "pepper" || n == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }

}


