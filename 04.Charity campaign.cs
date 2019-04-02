using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Charity_campaign_Благотворителна_кампания_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDaysCampaignRunning = int.Parse(Console.ReadLine());
            int numberConfectioners = int.Parse(Console.ReadLine());
            int numberCakes = int.Parse(Console.ReadLine());
            int numberWaffles = int.Parse(Console.ReadLine());
            int numberPancakes = int.Parse(Console.ReadLine());

            // количеството на тортите

            int amountCakes = numberCakes * 45 ;
            //Console.WriteLine(amountCakes);

            // количеството на Гофрета

            double amountWaffles = numberWaffles * 5.80 ;
          //  Console.WriteLine(amountWaffles);

            // количеството на Палачинка 

            double amountPancake = numberPancakes * 3.20 ;
           // Console.WriteLine(amountPancake);

            //Обща сума за един ден:

            double totalAmountOneDay = (amountCakes + amountPancake + amountWaffles) * numberConfectioners;
           // Console.WriteLine(totalAmountOneDay);

            //Сума събрана от цялата кампания:

            double AmountCollectedWholeCompany = totalAmountOneDay * numberDaysCampaignRunning;
             //Console.WriteLine(AmountCollectedWholeCompany);

            //Сума след покриване на разходите:

             double amountAfterCoverageCosts = AmountCollectedWholeCompany - ( AmountCollectedWholeCompany * 1 / 8);
            Console.WriteLine("{0:f2}",amountAfterCoverageCosts);
            //Console.WriteLine(amountAfterCoverageCosts);
            
        }
    }
}
//В сладкарница се провежда благотворителна кампания за събиране на средства, в която могат да се включат сладкари от цялата страна.Първоначално прочитаме от конзолата броя на дните, в които тече кампанията и броя на сладкарите, които ще се включат.След това на отделни редове получаваме количеството на тортите, гофретите и палачинките, които ще бъдат приготвени от един сладкар за един ден.

//Трябва да се има предвид следния ценоразпис:
//•	Торта - 45 лв.
//•	Гофрета - 5.80 лв.
//•	Палачинка – 3.20 лв.

//1/8 от крайната сума ще бъде използвана за покриване на разходите за продуктите по време на кампанията. Да се напише програма, която изчислява сумата, която е събрана в края на кампанията.

