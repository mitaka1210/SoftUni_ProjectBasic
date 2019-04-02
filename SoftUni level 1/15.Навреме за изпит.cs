using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Навреме_за_изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            int startExam = int.Parse(Console.ReadLine()); // час на изпита 
            int minetstExam = int.Parse(Console.ReadLine()); // минута на изпита 
            int hourArrival = int.Parse(Console.ReadLine()); // час на пристигане 
            int minuteArrival = int.Parse(Console.ReadLine());// минута на пристигане 

            int TotalEXam = startExam + minetstExam;

            int TotalArrival = hourArrival + minuteArrival;
            


            if (TotalEXam < TotalArrival)
            {
                Console.WriteLine("late");
            }
            else if (TotalEXam == TotalArrival && TotalEXam > TotalArrival + 30)
            {
                Console.WriteLine("On time");
            }
            else if (TotalArrival > TotalEXam)
            {
                Console.WriteLine("Early");
                Console.WriteLine("");
            }


        }
    }
}
