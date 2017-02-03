using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int pos1 = n;
            int pos2 = n * 4 + 2 - n;

            //top

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n * 4 + 3; j++)
                {
                    if (i == 0)
                    {
                        if (j > pos1 && j < pos2)
                        {
                            Console.Write("_");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else {
                        if (j == pos1 + 1 || j == pos1 + 2)
                        {
                            Console.Write("/");
                        }
                        else if (j == pos2 - 1 || j == pos2 - 2)
                        {
                            Console.Write("\\");
                        }
                        else if (j > pos1 && j < pos2)
                        {
                            Console.Write("_");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                pos1--;
                pos2++;
                Console.WriteLine();
            }

            //middle

            for (int i = 0; i < n * 4 + 3; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.Write("/");
                }
                else if (i == n * 4 + 2 || i == n * 4 + 1)
                {
                    Console.Write("\\");
                }
                else if (i < n * 2 - 1)
                {
                    Console.Write("_");
                }
                else if (i == n * 2 - 1) {
                    Console.Write("S");
                }
                else if (i == n * 2)
                {
                    Console.Write("T");
                }
                else if (i == n * 2 + 1)
                {
                    Console.Write("O");
                }
                else if (i == n * 2 + 2)
                {
                    Console.Write("P");
                }
                else if (i == n * 2 + 3)
                {
                    Console.Write("!");
                }
                else if (i > n * 2 + 3)
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();

            //bottom

            pos1 = -1;
            pos2 = n * 4 + 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n * 4 + 3; j++)
                {
                    if (j == pos1 + 1 || j == pos1 + 2)
                    {
                        Console.Write("\\");
                    }
                    else if (j == pos2 - 1 || j == pos2 - 2)
                    {
                        Console.Write("/");
                    }
                    else if (j > pos1 && j < pos2)
                    {
                        Console.Write("_");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                pos1++;
                pos2--;
                Console.WriteLine();
            }
        }
    }
}
