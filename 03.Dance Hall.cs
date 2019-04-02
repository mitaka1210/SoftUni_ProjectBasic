using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Зала_за_танци_Dance_Hall_
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lenght = double.Parse(Console.ReadLine());//дължина на залата тук е в МЕТРИ
            double Width = double.Parse(Console.ReadLine());//ширина на залата тук е в МЕТРИ
            double legsideWardrobeht = double.Parse(Console.ReadLine());//страна на гардероба тук е в МЕТРИ

            // Големина на залата в квадратни сантиметри: 

            double wholeАrea = (Lenght * 100) * (Width * 100);
           // Console.WriteLine(wholeАrea);

            // Големина на гардероба:

            double sizeWardrobe = Math.Pow(legsideWardrobeht * 100, 2);
           // Console.WriteLine(sizeWardrobe);

            // Големина на пейката: 

            double benchSize = wholeАrea / 10;
            //Console.WriteLine(benchSize);

            // Свободно пространство:

            double freeSpaceHall = wholeАrea - sizeWardrobe - benchSize;
            //Console.WriteLine(freeSpaceHall);

            // Брой танцьори:

            double numberDancers = freeSpaceHall / (40 + 7000);
            Console.WriteLine(Math.Floor(numberDancers));

        }
    }
}
//Група танцьори си търсят нова зала.Залата, която са харесали, е правоъгълна и има размери: 
//L - дължина и W - ширина (в метри). В залата има квадратен гардероб със страна - A и правоъгълна скамейка с площ 10 пъти по-малка от площта на залата.
//Мястото, което заема един танцьор е 40 см² и допълнително за свободно движение му трябват още  7000см². 
//Напишете програма, която да изчислява колко танцьори могат да се поберат в залата и да се движат свободно.
//Полученият резултат трябва да се закръгли до най-близкото цяло число надолу. 
//Вход
//От конзолата се четат 3 реда:
//1.	L – дължина на залата в метри – реално число в интервала  [10.00 … 100.00];
//2.	W – ширина на залата в метри – реално число в интервала[10.00 … 100.00];
//3.	А – страна на гардероба в метри – реално число в интервала[2.00… 20.00];
//Изход
//Да се отпечата на конзолата едно цяло число – броя танцьори, които могат да се поберат в свободното пространство на залата, закръглени до най-близкото цяло число надолу.
