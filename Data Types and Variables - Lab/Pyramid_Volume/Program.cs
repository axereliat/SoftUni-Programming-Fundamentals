using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            double dul, sh, V = 0;

            Console.Write("Length: ");

            dul = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            sh = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            V = double.Parse(Console.ReadLine());

            double res = (dul * sh * V) / 3;

            Console.WriteLine("Pyramid Volume: {0:f2}", res);
        }
    }
}
