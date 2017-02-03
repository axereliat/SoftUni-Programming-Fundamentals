using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());

            if (c >= 0 && c <= 58)
            {
                Console.WriteLine("digit");
            }
            else if (c == 97 || c == 101 || c == 105 || c == 111 || c == 117
                || c == 65 || c == 69 || c == 77 || c == 83 || c == 89) {
                Console.WriteLine("vowel");
            } else {
                Console.WriteLine("other");
            }
        }
    }
}
