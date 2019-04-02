using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckConditiones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isHungry = true; //Казвам, че съм гладен
            if (isHungry)
            {
                bool haveFood = false; // Тук проверявам имам ли храна
                if (haveFood)
                {
                    Console.WriteLine("Yes,I have feed"); // ако имам принтира това
                }
                else
                {
                    Console.WriteLine("Go buy food"); // ако нямам принтира това
                }
            }
        }
    }
}
