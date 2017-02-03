using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static bool isPrime(long n1) {
            if (n1 == 4) {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n1); i++)
            {
                if (n1 % i == 0) {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
    }
}
