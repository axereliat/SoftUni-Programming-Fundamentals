using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();

            try
            {
                long n = long.Parse(m);
                if (n <= short.MaxValue)
                {
                    Console.WriteLine(n + " can fit in:");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else if (n <= int.MaxValue && n >= 0)
                {
                    Console.WriteLine(n + " can fit in:");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine(n + " can fit in:");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
            }
            catch (Exception) {
                Console.WriteLine("{0} can't fit in any type", m);
            }
        }
    }
}
