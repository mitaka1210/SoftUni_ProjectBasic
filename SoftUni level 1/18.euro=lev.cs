using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euro_lev
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Petur";
            int age = 29;
            double height = 1,8;
            DateTime dateofBirth = DateTime.Now;
            Console.WriteLine(firstName);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(dateofBirth.ToString("yyyy"));

        }
    }
}
