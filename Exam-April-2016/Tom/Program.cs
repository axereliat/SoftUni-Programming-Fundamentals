using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int result = (365 - n) * 63 + n * 127;

            if (result < 30000)
            {
                result = 30000 - result;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", result / 60, result % 60);
            }
            else {
                result = result - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", result / 60, result % 60);
            }
        }
    }
}
