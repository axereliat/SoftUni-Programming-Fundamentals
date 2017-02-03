using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double d1 = Math.Abs(a + b);
            double d2 = Math.Abs(c + d);

            if (d1 <= d2)
            {
                Console.WriteLine("({0}, {1})", a, b);
            }
            else
            {
                Console.WriteLine("({0}, {1})", c, d);
            }
        }
    }
}
