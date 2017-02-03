using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var per = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treated = 0;
            int untreated = 0;

            for (int i = 0; i < per; i++)
            {
                var patients = int.Parse(Console.ReadLine());

                if ((i + 1) % 3 == 0)
                {
                    if (treated < untreated)
                    {
                        doctors++;
                    }
                }

                if (doctors >= patients)
                {
                    treated += patients;
                }
                else {
                    treated += doctors;
                    untreated += patients - doctors;
                }
            }
            Console.WriteLine("Treated patients: " + treated + ".");
            Console.WriteLine("Untreated patients: " + untreated + ".");
        }
    }
}
