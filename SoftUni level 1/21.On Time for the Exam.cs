using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.On_Time_for_the_Exam_Навреме_за_изпит_
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursExam =    int.Parse(Console.ReadLine()); //•	Първият ред съдържа час на изпита 
            int minExam =      int.Parse(Console.ReadLine());//•	Вторият ред съдържа минута на изпита 
            int HoursArrival = int.Parse(Console.ReadLine());//•	Третият ред съдържа час на пристигане 
            int minArrival =   int.Parse(Console.ReadLine());//•	Четвъртият ред съдържа минута на пристигане 

            //Ако имаме изпит в 1:30 това е 90мин==>60+30
            int examtotalMints = (hoursExam * 60) + minExam; //цялото време на изпита
            
            int ArrivalTotalMints = (HoursArrival * 60) + minArrival; //минутите на пристигане на нашия студент

            if (ArrivalTotalMints <= examtotalMints && ArrivalTotalMints >= examtotalMints - 30) // тук проверяваме дали съм дошъл на време или по-рано от 30мин
            {
                int timeBeforStartExam = examtotalMints - ArrivalTotalMints;
                Console.WriteLine("On time");
                //Проверяваме дали имаме повече от 60мин или 60мин зада променим минутите на часове
                if (timeBeforStartExam >= 60)
                {
                    Console.WriteLine($"{timeBeforStartExam / 60 }:{timeBeforStartExam % 60 :D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{timeBeforStartExam} minutes before the start");
                }
            }
            else if (ArrivalTotalMints <= examtotalMints - 30)
            {
                int timeBeforStartExam = examtotalMints - ArrivalTotalMints;
                Console.WriteLine("Early");
                //Проверяваме дали имаме повече от 60мин или 60мин зада променим минутите на часове
                if (timeBeforStartExam >= 60)
                {
                    Console.WriteLine($"{timeBeforStartExam / 60 }:{timeBeforStartExam % 60 :D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{timeBeforStartExam} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                //Проверяваме дали имаме повече от 60мин или 60мин зада променим минутите на часове
                int timeBeforStartExam = ArrivalTotalMints - examtotalMints;
                if (timeBeforStartExam >= 60)
                {
                    Console.WriteLine($"{timeBeforStartExam / 60 }:{timeBeforStartExam % 60 :D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{timeBeforStartExam} minutes after the start");
                }
            }
        }
    }
}
