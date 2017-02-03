using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            ulong seconds = 60 * (ulong)minutes;
            ulong miliseconds = 1000 * seconds;
            ulong microseconds = 1000 * miliseconds;
            ulong nanoseconds = 1000 * microseconds;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8}000 nanoseconds",
                centuries, years, days, hours, minutes, seconds, miliseconds, microseconds, microseconds);
        }
    }
}