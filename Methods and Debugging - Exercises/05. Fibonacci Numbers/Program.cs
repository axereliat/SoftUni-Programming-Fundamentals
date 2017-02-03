using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static long Fib(long n1) {
            long[] a1;
            a1 = new long[1000000];
            a1[0] = 1;
            a1[1] = 1;
            a1[2] = 2;

            for (long i = 3; i <= n1; i++)
            {
                a1[i] = a1[i - 1] + a1[i - 2];
            }
            return a1[n1];
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
}
