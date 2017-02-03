using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations
{
    class Program
    {
        private static object t;

        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var sign = Console.ReadLine();

            if (sign.Equals("+")) {
                if ((a + b) % 2 == 0)
                {
                    var t = "even";
                    Console.WriteLine("{0} + {1} = {2:f0} - {3}", a, b, (a + b), "even");
                }
                else
                {
                    var t = "odd";
                    Console.WriteLine("{0} + {1} = {2:f0} - {3}", a, b, (a + b), "odd");
                }
            }
            if (sign.Equals("-"))
            {
                if ((a - b) % 2 == 0)
                {
                    var t = "even";
                    Console.WriteLine("{0} - {1} = {2:f0} - {3}", a, b, (a - b), "even");
                }
                else
                {
                    var t = "odd";
                    Console.WriteLine("{0} - {1} = {2:f0} - {3}", a, b, (a - b), "odd");
                }
            }
            if (sign.Equals("*"))
            {
                if ((a * b) % 2 == 0)
                {
                    var t = "even";
                    Console.WriteLine("{0} * {1} = {2:f0} - {3}", a, b, (a * b), "even");
                }
                else
                {
                    var t = "odd";
                    Console.WriteLine("{0} * {1} = {2:f0} - {3}", a, b, (a * b), "odd");
                }
            }
            if (sign.Equals("/"))
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", a);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2}", a, b, (a / b));
                }
            }
            if (sign.Equals("%"))
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", a);
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2:f0}", a, b, (a % b));
                }
            }
        }
    }
}
