using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());

            double mps = d / (h * 3600f + m * 60f + s);
            double kph = d / 1000f / (h + m / 60f + s / 3600f);
            double mph = d / 1609f / (h + m / 60f + s / 3600f);

            Console.WriteLine("{0:f7}, {1}", mps, mps);
            Console.WriteLine("{0:f7}, {1}", kph, kph);
            Console.WriteLine("{0:f7}, {1}", mph, mph);
        }
    }
}
