using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var people = double.Parse(Console.ReadLine());
            double per = 0;

            if (people < 5) {
                per = 0.75;
            }
            if (people >= 5 && people < 10)
            {
                per = 0.6;
            }
            if (people >= 10 && people < 25)
            {
                per = 0.5;
            }
            if (people >= 25 && people < 50)
            {
                per = 0.4;
            }
            if (people > 50)
            {
                per = 0.25;
            }

            money -= money * per;
            double price = 0;

            if (type.Equals("VIP"))
            {
                price = 499.99 * people;
            }
            else {
                price = 249.99 * people;
            }

            if (money > price)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", (money - price));
            }
            else {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", (price - money));
            }
        }
    }
}
