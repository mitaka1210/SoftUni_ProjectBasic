using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Tailoring_Workshop__Шивашки_цех_
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());//брой на масите
            double Length = double.Parse(Console.ReadLine());//дължина на масата
            double Width = double.Parse(Console.ReadLine());//широчина на масата

            //Общата площ на покривките е:
            double totalArea = number * (Length + 2.00 * 0.30) * (Width + 2.00 * 0.30);
            //Console.WriteLine(totalArea);



            ////Общата площ на каретата  е:

            double totalAreacarriage = number * (Length / 2) * (Length / 2);
            //Console.WriteLine(totalAreacarriage);
        


            ////Цена в долари: 
            double totalDolars = totalArea * 7 + totalAreacarriage * 9;


            //Цена в левове: 

            double totalLeva = totalDolars * 1.85;

            
            Console.WriteLine($"{totalDolars:f2} USD");
            Console.WriteLine($"{totalLeva:f2} BGN");

        }
    }
}

//Шивашки цех приема поръчки за ушиване на покривки и карета за маси за заведения.Покривките са правоъгълни, каретата са квадратни, броят им винаги е еднакъв.Покривката трябва да виси с 30 см от всеки ръб на масата. Страната на каретата е половината от дължината на масите.Във всяка поръчка се включва информация за броя и размерите на масите.
//Напишете програма, която пресмята цената на поръчка в долари и в левове, като квадратен метър плат за правоъгълна покривка струва 7 долара, а за каре – 9 долара.Курсът на долара е 1.85 лева.
//Вход
//Потребителят въвежда 3 числа, по едно на ред:
//•	Брой правоъгълни маси – цяло число в интервала [0..500];
//•	Дължина на правоъгълните маси в метри – реално число в интервала[0.00...3.00];
//•	Широчина на правоъгълните маси в метри – реално число в интервала[0.00...3.00];
//Изход
//Да се отпечатат на конзолата две числа: цената на изделията в долари и в левове.
//o   "{цена в долари} USD"
//o   "{цена в левове} BGN

