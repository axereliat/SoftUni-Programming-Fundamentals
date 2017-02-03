using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static bool isPrime(long n1)
        {
            if (n1 == 4 || n1 == 1 || n1 == 0)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n1); i++)
            {
                if (n1 % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            long b = long.Parse(Console.ReadLine());
            string result = "";

            for (long i = 2; i <= b; i++)
            {
                if (isPrime(i))
                {
                    result += i + ", ";
                }
            }
            char[] c;
            c = new char[result.Length];
            c = result.ToCharArray();
            for (int i = 0; i < c.Length - 2; i++)
            {
                Console.Write(c[i]);
            }
        }
    }
}
