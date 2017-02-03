using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                   .Trim()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(x => int.Parse(x))
                   .ToArray();

            int sumL = 0, sumR = 0;
            bool fl = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumL += arr[j];
                    //Console.WriteLine("j " + arr[j]);
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    sumR += arr[k];
                    //Console.WriteLine("k " + arr[k]);
                }
                if (sumL == sumR) {
                    fl = true;
                    Console.WriteLine(i);
                    break;
                }
                sumL = 0;
                sumR = 0;
            }
            if (!fl) {
                Console.WriteLine("no");
            }
        }
    }
}
