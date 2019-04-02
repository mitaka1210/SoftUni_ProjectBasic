using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Alcoholic_Exchange_Алкохолна_борса_
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyePice = double.Parse(Console.ReadLine());
            double quantityBeerLiters = double.Parse(Console.ReadLine());
            double quantityWineLiters = double.Parse(Console.ReadLine());
            double quantityRakiqLiters = double.Parse(Console.ReadLine());
            double quantityWhiskyeLiters = double.Parse(Console.ReadLine());

            //Цена на ракията:

            double rakiqPrice = whiskyePice / 2;
            double totalRakiq = quantityRakiqLiters * rakiqPrice;
           // Console.WriteLine(totalRakiq);

            //Цена на виното:

            double winePrice = rakiqPrice - (rakiqPrice * 0.4);
            double totalwine = winePrice * quantityWineLiters;
           // Console.WriteLine(totalwine);

            //Цена на бирата:

            double beerPrice = rakiqPrice - (rakiqPrice * 0.8);
            double totalBeer = beerPrice * quantityBeerLiters;
            //Console.WriteLine(totalBeer);

            double totalWhiskey = whiskyePice * quantityWhiskyeLiters;
           // Console.WriteLine(totalWhiskey);

            double totalPrice = totalWhiskey + totalBeer + totalwine + totalRakiq;
            Console.WriteLine("{0:f2}", totalPrice);


        }
    }
}
