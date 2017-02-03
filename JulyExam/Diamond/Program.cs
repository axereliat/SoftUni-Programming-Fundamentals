using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = n - 1;
            int space2 = 0;

            //top

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 5 * n; j++)
                {
                    if (i == n) {
                        Console.Write("*");
                    } else if (i == 0)
                    {
                        if (j > space && j < 5 * n - space - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else {
                        if (j == space + 1 || j == 5 * n - space - 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                space--;
                Console.WriteLine();
            }

            //bottom
            space = 1;
            space2 = 5 * n - 2;

            for (int i = 0; i < 2 * n + 1; i++)
            {
                for (int j = 0; j < 5 * n; j++)
                {
                    if (i != 2 * n)
                    {
                        if (j == space || j == space2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else {
                        if (j > space2 || j < space)
                        {
                            Console.Write(".");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();
                space++;
                space2--;
            }
        }
    }
}
