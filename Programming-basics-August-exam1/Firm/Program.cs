using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            double hours_jobDone = Math.Round(0.9f * d * 8f + w * 2f * d);

            //Console.WriteLine((0.9f * d * 8f + w * 2f * d));

            if (hours_jobDone >= h)
            {
                Console.WriteLine("Yes!" + (hours_jobDone - h) + " hours left.");
            }
            else {
                Console.WriteLine("Not enough time!" + (h - hours_jobDone) + " hours needed.");
            }
        }
    }
}
