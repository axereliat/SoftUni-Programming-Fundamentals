using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
            int cnt = 1, Max = int.MinValue, Max2 = 0;
            for (int i = 0; i < n.Length - 1; i++)
            {
                //Console.WriteLine(n[i]);
                if (n[i] == n[i + 1])
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                }
                if (cnt > Max)
                {
                    Max = cnt;
                    Max2 = n[i];
                }
            }

            for (int i = 0; i < Max; i++)
            {
                Console.Write("{0} ", Max2);
            }
        }
    }
}
