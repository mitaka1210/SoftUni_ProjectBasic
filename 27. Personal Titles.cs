﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (n < 16.0)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
