using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {

        static int GetMax(int a1, int b1, int c1) {
            int max1 = int.MinValue;
            if (a1 > max1) max1 = a1;
            if (b1 > max1) max1 = b1;
            if (c1 > max1) max1 = c1;
            return max1;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, b, c));
        }
    }
}
