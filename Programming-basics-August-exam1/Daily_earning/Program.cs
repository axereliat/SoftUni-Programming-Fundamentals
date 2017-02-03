using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_earning
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            double m = 365d;
            double n = (a * b * 12d + a * b * 2.5d - 0.25d * (a * b * 12d + a * b * 2.5d)) * c;
            double result = n / m;

            Console.WriteLine("{0:f2}", result);

            //Console.WriteLine("n: " +n);

            //Console.WriteLine((a * b * 12d + a * b * 2.5d - 0.25d * (a * b * 12d + a * b * 2.5d) * c) / 365d);
            
            //Console.WriteLine((a * b * 12d + a * b * 2.5d - 0.25d * (a * b * 12d + a * b * 2.5d))*c);
        }
    }
}
