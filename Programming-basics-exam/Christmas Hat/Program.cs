using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //top

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4 * n + 1; j++)
                {
                    if (i == 0)
                    {
                        if (j == n * 2 - 1)
                        {
                            Console.Write("/");
                        }
                        else if (j == n * 2)
                        {
                            Console.Write("|");
                        }
                        else if (j == n * 2 + 1)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else if (i == 1)
                    {
                        if (j == n * 2 - 1)
                        {
                            Console.Write("\\");
                        }
                        else if (j == n * 2)
                        {
                            Console.Write("|");
                        }
                        else if (j == n * 2 + 1)
                        {
                            Console.Write("/");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else if (i == 2)
                    {
                        if (j >= n * 2 - 1 && j <= n * 2 + 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }

            //middle

            int pos1 = n * 2 - 2;
            int pos2 = n * 2 + 2;

            for (int i = 0; i < n * 2 - 1; i++)
            {
                for (int j = 0; j < 4 * n + 1; j++)
                {
                    if (j == pos1 || j == n * 2 || j == pos2)
                    {
                        Console.Write("*");
                    }
                    else if (j > pos1 && j < pos2)
                    {
                        Console.Write("-");
                    }
                    else {
                        Console.Write(".");
                    }
                }
                pos1--;
                pos2++;
                Console.WriteLine();
            }

            //bottom

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4 * n + 1; j++)
                {
                    if (i == 0 || i == 2)
                    {
                        Console.Write("*");
                    }
                    else {
                        if (j % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        else {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
