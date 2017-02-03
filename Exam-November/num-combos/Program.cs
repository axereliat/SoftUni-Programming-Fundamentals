using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_combos
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ulong.Parse(Console.ReadLine());
            var b = ulong.Parse(Console.ReadLine());
            var c = ulong.Parse(Console.ReadLine());

            ulong cnt = 0;
            bool stop = false;

            for (ulong i = a; i <= b; i++)
            {
                for (ulong j = a; j <= b; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    cnt++;
                    if (cnt >= c) {
                        stop = true;
                        i = b + 1;
                        break;
                    }
                }
                if (stop) {
                   break;
                }
            }
        }
    }
}
