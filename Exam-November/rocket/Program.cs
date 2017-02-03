using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = 0;

            //top

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == 3 * n / 2 - 1 - space)
                    {
                        Console.Write("/");
                    } else if (j == 3 * n / 2 + space)
                    {
                        Console.Write("\\");
                    } else if (j > 3 * n / 2 - 1 - space && j < 3 * n / 2 + space)
                    {
                        Console.Write(" ");
                    } else {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                space++;
            }

            // middle small

            for (int i = 0; i < 3 * n; i++)
            {
                if (i > 3 * n / 2 - 1 - space && i < 3 * n / 2 + space)
                {
                    Console.Write("*");
                }
                else {
                    Console.Write(".");
                }
            }
            Console.WriteLine();

            // middle
            for (int i = 0; i < 2 * n; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == 3 * n / 2 - space || j == 3 * n / 2 + space - 1)
                    {
                        Console.Write("|");
                    }
                    else if (j > 3 * n / 2 - space && j < 3 * n / 2 + space - 1)
                    {
                        Console.Write("\\");
                    }
                    else {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

            //bottom

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == 3 * n / 2 - space)
                    {
                        Console.Write("/");
                    }
                    else if (j == 3 * n / 2 + space - 1) {
                        Console.Write("\\");
                    }
                    else if (j > 3 * n / 2 - space && j < 3 * n / 2 + space - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                space++;
            }
        }
    }
}
