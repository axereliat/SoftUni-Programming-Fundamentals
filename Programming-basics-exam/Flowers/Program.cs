using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = decimal.Parse(Console.ReadLine());
            var r = decimal.Parse(Console.ReadLine());
            var l = decimal.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holiday = Console.ReadLine();
            decimal sum = 0;

            if (season.Equals("Spring") || season.Equals("Summer"))
            {
                sum = h * (decimal)2 + r * (decimal)4.1 + l * (decimal)2.5;
            }
            else {
                sum = h * (decimal)3.75 + r * (decimal)4.5 + l * (decimal)4.15;
            }

            if (holiday.Equals("Y"))
            {
                sum *= (decimal)1.15;
            }

            if (l > 7 && season.Equals("Spring")) {
                sum *= (decimal)0.95;
            }

            if (r >= 10 && season.Equals("Winter"))
            {
                sum *= (decimal)0.9;
            }

            if (h + r + l > 20) {
                sum *= (decimal)0.8;
            }

            Console.WriteLine("{0:f2}", sum + (decimal)2);
        }
    }
}
