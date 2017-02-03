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
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            var sum = double.Parse(Console.ReadLine());

            double sum1 = (a * 3.25 + b * 4 + c * 3.5 + d * 8) * 0.95;
            double result = Math.Abs(sum1 - sum);

            if (sum1 < sum)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(result));
            }
            else {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(result));
            }
        }
    }
}
