using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {


            double budge = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            

            double percent = 0.0;
            //condition
            if (budge <= 100 && season == "summer")//почивка в България
            {
                percent = 0.30;
            }
            else if(budge <= 100 && season == "winter")
            {
                percent = 0.70;
            }
            Console.WriteLine("Somewhere in Bulgaria");
            Console.WriteLine("{0:F2}", budge * percent);
            //}
            //else if (budge <= 1000 && country == "balkania") //на балканите
            //{
            //    if (season == "summer")
            //    {
            //        percent = 0.40;
            //    }
            //    else if (season == "winter")
            //    {
            //        percent = 0.80;
            //    }
            //}
            //else if (budge > 1000 && country == "europa") //в европа
            //{
            //    percent = 0.90;
            //}
            //else
            //{
            //    console.writeline(budge * percent + country);

            //}
        }
    }
}


