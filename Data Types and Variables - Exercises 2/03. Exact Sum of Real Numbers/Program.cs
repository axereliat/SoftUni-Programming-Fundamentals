using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal a = decimal.Parse(Console.ReadLine());
                sum += a;
            }

            Console.WriteLine(sum);
        }
    }
}
