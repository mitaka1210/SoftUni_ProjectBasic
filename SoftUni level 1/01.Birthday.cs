using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday_Рожден_ден_
{
    class Program
    {
        static void Main(string[] args)
        {
           int  Length = int.Parse(Console.ReadLine());
           int  Width =  int.Parse(Console.ReadLine());
           int  Height = int.Parse(Console.ReadLine());
            double Percentage  = double.Parse(Console.ReadLine());

            Percentage = Percentage * 0.01;
            double sumLitersAquarium =( Length * Width * Height * 0.001);//Тук умножаваме по 0.001 за да преобърнем кубичен сънтиметър в Литър
            Console.WriteLine("{0:f3}",sumLitersAquarium * (1 - Percentage));
        }
    }
}

//За рождения си ден Любомир получил аквариум с формата на паралелепипед.Първоначално прочитаме от конзолата на отделни редове размерите му – дължина, широчина и височина в сантиметри.Трябва да се пресметне колко литра вода ще събира аквариума, ако се знае, че определен процент от вместимостта му е заета от пясък, растения, нагревател и помпа.
//Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм3/. 

//Вход   Изход                        Обяснения:
//85  |  248.689
//75  | 
//47  |
//17  |	                   Изчисляваме обем на аквариум:
//                           обем на аквариум= 85*75*47=299625 см3

//                           общо литри, които ще събере: 299625 * 0.001=299.625 литра

//                           процент: 17*0.01=0.17

//                           литрите, които реално ще трябват : 299.625* (1-0.17) =248.688литра
 

