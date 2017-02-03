using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Greetings(string name1) {
            Console.WriteLine("Hello, {0}!", name1);
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greetings(name);
        }
    }
}
