using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {

        \/static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = (n % 2 == 0) ? 2*n : 2*n - 1;
            int last_pos = 0;
            int last_pos2 = 3 * n + 1;

            //top

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 5 * n; j++)
                {
                    if (j == 3 * n + i + 1 || j == 3 * n)
                    {
                        Console.Write("*");
                        last_pos = 3 * n + i + 1;
                    } else {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }

            //middle

            for (int i = 0; i < n/2; i++)
            {
                for (int j = 0; j < 5 * n; j++)
                {
                    if (j < 3 * n + 1 || j == last_pos)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }

            //bottom

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < 5 * n; j++)
                {
                    if (i != n / 2 - 1)
                    {
                        if (j == last_pos || j == last_pos2 - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    else {
                        if (j >= last_pos2 - 1 && j <= last_pos)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                }
                Console.WriteLine();
                last_pos++;
                last_pos2--;
            }
        }
    }
}
