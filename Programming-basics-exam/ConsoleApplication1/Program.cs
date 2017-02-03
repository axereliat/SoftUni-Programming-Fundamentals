using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            var t1 = double.Parse(Console.ReadLine());
            var t2 = double.Parse(Console.ReadLine());
            var t3 = double.Parse(Console.ReadLine());

            double s1 = speed * (t1 / 60);
            double s2 = speed * 1.1 * (t2 / 60);
            double s3 = speed * 1.1 * 0.95 * (t3 / 60);

            Console.WriteLine("{0:f2}", s1 + s2 + s3);
        }
    }
}
