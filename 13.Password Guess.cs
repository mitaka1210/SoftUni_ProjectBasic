using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Guess_Познай_паролата_
{
    class Program
    {
        static void Main(string[] args)
        {
            string V = Console.ReadLine();

            bool v = V == "s3cr3t!P@ssw0rd";
            if (v)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
