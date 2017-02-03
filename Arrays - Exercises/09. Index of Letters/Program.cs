using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine()
                .Trim()
                .ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i] + " -> " + (s[i] - 97));
            }
        }
    }
}
