using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double sumAll = 0;
            double sumM = 0;
            double sumK = 0;
            double sumT = 0;

            for (double i = 0; i < n; i++)
            {
                var a = double.Parse(Console.ReadLine());
                sumAll += a;
                if (a <= 3) {
                    sumM += a;
                }
                if (a >= 4 && a <= 11)
                {
                    sumK += a;
                }
                if (a >= 12)
                {
                    sumT += a;
                }
            }
            Console.WriteLine("{0:f2}", (sumM * 200 + sumK * 175 + sumT * 120) / sumAll);
            Console.WriteLine("{0:f2}%", sumM / sumAll * 100);
            Console.WriteLine("{0:f2}%", sumK / sumAll * 100);
            Console.WriteLine("{0:f2}%", sumT / sumAll * 100);
        }
    }
}
