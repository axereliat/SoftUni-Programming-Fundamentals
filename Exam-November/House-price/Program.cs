using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_price
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            double bathroom = a / 2;
            double secondroom = a * 1.1;
            double thirdroom = secondroom * 1.1;

            double sum = (bathroom + secondroom + thirdroom + a + b) * 1.05;

            sum *= c;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
