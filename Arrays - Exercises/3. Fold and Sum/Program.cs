using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fold_and_Sum
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
            var left = new int[arr.Length / 4];
            var right = new int[100000];

            int index = -1;
            for (int i = arr.Length / 4 - 1; i >= 0; i--)
            {
                index++;
                left[index] = arr[i];
            }

            index = -1;
            for (int i = arr.Length - 1; i >= arr.Length - arr.Length / 4 - 1; i--)
            {
                if (i < 0) break;
                index++;
                right[index] = arr[i];
            }

            var all = new int[arr.Length / 2];

            index = -1;
            for (int i = 0; i < arr.Length / 4; i++)
            {
                index++;
                all[index] = left[i];
            }
            
            for (int i = 0; i < arr.Length / 4; i++)
            {
                index++;
                all[index] = right[i];
            }
            for (int i = 0; i <= index; i++)
            {
                Console.Write("{0} ", all[i] + arr[i + arr.Length / 4]);
            }
        }
    }
}
