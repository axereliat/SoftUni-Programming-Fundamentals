using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int k = int.Parse(Console.ReadLine());
            int rotations = new int[k][10];

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[i] * 2);
                }
            }
        }
    }
}
