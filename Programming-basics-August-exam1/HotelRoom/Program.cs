using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var days = int.Parse(Console.ReadLine());
            decimal apartPrice = 0;
            decimal studioPrice = 0;

            if (month.Equals("May") || month.Equals("October")) {
                apartPrice = 65 * days;
                studioPrice = 50 * days;
                if (days > 14)
                {
                    studioPrice *= (decimal)0.7;
                } else if (days > 7)
                {
                    studioPrice *= (decimal)0.95;
                }
            }
            if (month.Equals("June") || month.Equals("September"))
            {
                apartPrice = (decimal)68.70 * days;
                studioPrice = (decimal)75.20 * days;
                if (days > 14)
                {
                    studioPrice *= (decimal)0.8;
                }
            }
            if (month.Equals("July") || month.Equals("August"))
            {
                apartPrice = 77 * days;
                studioPrice = 76 * days;
            }
            if (days > 14) {
                apartPrice *= (decimal)0.9;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
