using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    num = row + col + 1;

                    if (num > number)// ако е мината стойноста влизаме тук
                    {
                        num = 2 * number - num;
                    }
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }

        }
    }
}
