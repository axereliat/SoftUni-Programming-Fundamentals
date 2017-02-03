using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());

            double result = 0.4 * a * b / 2.5;
            if (result >= c)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(result));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(result - c), Math.Ceiling((result - c) / d));
            }
            else {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor((c - result)));
            }
        }
    }
}
