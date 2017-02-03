using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');

            int cnt = 0;
            
            for (int i = 0; i < Math.Min(s1.Length, s2.Length); i++)
            {
                if (s1[i] == s2[i]) {
                    cnt++;
                }
            }
            int cnt2 = 0;
            Array.Reverse(s1);
            Array.Reverse(s2);
            for (int i = 0; i < Math.Min(s1.Length, s2.Length); i++)
            {
                if (s1[i] == s2[i])
                {
                    cnt2++;
                }
            }
            Console.WriteLine(Math.Max(cnt, cnt2));
        }
    }
}
