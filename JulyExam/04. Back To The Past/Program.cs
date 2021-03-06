﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = double.Parse(Console.ReadLine());
            double currentYear = 1800;
            double sum = 0;
            double years = 18;
            double lastMoney = money;

           for(double i = 1800; i <= year; i++) {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else {
                    money -= (12000 + 50 * years);
                }
                years++;
            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
            else {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
            }
        }
    }
}
