using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            a *= 1168;
            b *= 0.15;
            b *= 1.76;
            
            double sum = (a + b) / 1.95;

            Console.WriteLine(sum * ((100 - c) / 100));
        }
    }
}
