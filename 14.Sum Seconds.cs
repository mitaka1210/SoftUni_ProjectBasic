using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds_Сумиране_на_секунди_
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int fullTime = firstTime + secondTime + thirdTime;
            int minutes = fullTime / 60;
            int seconds = fullTime % 60;

            Console.WriteLine("{0}:{1:00}", minutes, seconds);
            
          
        }
    }
}
