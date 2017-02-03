using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void PrintWord(long a1)
        {
            if (a1 == 0) Console.WriteLine("zero");
            if (a1 == 1) Console.WriteLine("one");
            if (a1 == 2) Console.WriteLine("two");
            if (a1 == 3) Console.WriteLine("three");
            if (a1 == 4) Console.WriteLine("four");
            if (a1 == 5) Console.WriteLine("five");
            if (a1 == 6) Console.WriteLine("six");
            if (a1 == 7) Console.WriteLine("seven");
            if (a1 == 8) Console.WriteLine("eight");
            if (a1 == 9) Console.WriteLine("nine");
        }

        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            PrintWord(Math.Abs(a % 10));
        }
    }
}
