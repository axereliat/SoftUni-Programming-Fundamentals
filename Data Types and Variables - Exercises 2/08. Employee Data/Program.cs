using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var fn = Console.ReadLine();
            var ln = Console.ReadLine();
            var age = Console.ReadLine();
            var g = Console.ReadLine();
            var id = Console.ReadLine();
            var num = Console.ReadLine();

            Console.WriteLine("First name: " + fn);
            Console.WriteLine("Last name: " + ln);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + g);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + num);
        }
    }
}
