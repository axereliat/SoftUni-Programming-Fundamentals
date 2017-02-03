using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = ulong.Parse(Console.ReadLine());
            var s = ulong.Parse(Console.ReadLine());
            var trace = Console.ReadLine().ToLower();

            double jk = 0;
            double sk = 0;

            if (trace.Equals("trail")) {
                jk = 5.5;
                sk = 7.0;
            }
            if (trace.Equals("cross-country"))
            {
                jk = 8.0;
                sk = 9.5;
            }
            if (trace.Equals("downhill"))
            {
                jk = 12.25;
                sk = 13.75;
            }
            if (trace.Equals("road"))
            {
                jk = 20.0;
                sk = 21.5;
            }

            if (j + s >= 50 && trace.Equals("cross-country")) {
                jk *= 0.75;
                sk *= 0.75;
            }

            double amount = jk * j + sk * s;
            decimal result = (decimal)(amount * 0.95);
            //double result = (jk * j + sk * s) - 0.05 * (jk * j + sk * s);

            Console.WriteLine("{0:f2}", result);
        }
    }
}
