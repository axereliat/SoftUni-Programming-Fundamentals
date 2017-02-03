using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int new_num = n;
            int d1 = n / 100;
            int d2 = n / 10 % 10;
            int d3 = n % 10;

            int rows = d1 + d3;
            int cols = d1 + d2;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (n % 5 == 0) {
                        n -= d1;
                    } else if (n % 3 == 0)
                    {
                        n -= d2;
                    } else {
                        n += d3;
                    }

                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
