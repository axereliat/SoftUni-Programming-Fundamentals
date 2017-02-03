using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var c = decimal.Parse(Console.ReadLine());
            var d = decimal.Parse(Console.ReadLine());
            var e = decimal.Parse(Console.ReadLine());
            var f = decimal.Parse(Console.ReadLine());

            decimal s1 = a * b;
            decimal s2 = c * d / (decimal)2;
            decimal s3 = Math.Ceiling(s1 / s2) + (decimal)5;
            decimal sum = (decimal)s3 * e + f;
            //Console.WriteLine("s1: {0}, s2: {1}, s3: {2}", s1, s2, s3);
            //Console.WriteLine(sum);
            if (sum <= money)
            {
                Console.WriteLine("{0:f2} lv left.", (money - sum));
            }
            else {
                Console.WriteLine("You'll need {0:f2} lv more.", (sum - money));
            }
        }
    }
}
