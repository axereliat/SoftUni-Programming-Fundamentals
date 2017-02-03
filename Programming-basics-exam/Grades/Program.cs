using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double ex = 0;
            double vg = 0;
            double g = 0;
            double f = 0;
            double sum = 0;

            for (double i = 0; i < n; i++)
            {
                var m = double.Parse(Console.ReadLine());
                sum += m;
                if (m >= 5) {
                    ex++;
                }
                if (m <= 4.99 && m >= 4) {
                    vg++;
                }
                if (m < 4 && m >= 3) {
                    g++;
                }
                if (m < 3) {
                    f++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%", ex / n * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", vg / n * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", g / n * 100);
            Console.WriteLine("Fail: {0:f2}%", f / n * 100);
            Console.WriteLine("Average: {0:f2}", sum / n);
        }
    }
}
