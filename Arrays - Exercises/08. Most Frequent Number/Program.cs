using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
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
            int cnt = 1, Max = int.MinValue, MaxN = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) {
                        cnt++;
                    }
                }
                if (cnt > Max) {
                    Max = cnt;
                    MaxN = arr[i];
                }
                cnt = 1;
            }
            Console.WriteLine(MaxN);
        }
    }
}
