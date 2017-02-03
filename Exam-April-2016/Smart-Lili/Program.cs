using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            double money = c;
            double p = 0;

            for (int i = 2; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    p += 10;
                    money += p - 1;
                }
                else {
                    money += c;
                }
            }
            if (money >= b)
            {
                Console.WriteLine("Yes! {0:f2}", (money - b));
            }
            else {
                Console.WriteLine("No! {0:f2}", (b - money));
            }
        }
    }
}
