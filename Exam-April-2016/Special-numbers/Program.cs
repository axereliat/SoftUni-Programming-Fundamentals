using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = ulong.Parse(Console.ReadLine());

            for (ulong i = 1111; i <= 9999; i++)
            {
                try
                {
                    if (n % (i % 10) == 0 && n % (i / 10 % 10) == 0 && n % (i / 100 % 10) == 0 && n % (i / 1000) == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                catch (Exception e) {

                }
            }
        }
    }
}
