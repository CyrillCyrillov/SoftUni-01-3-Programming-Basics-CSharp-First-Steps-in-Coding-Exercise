using System;

namespace Task05_Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentOfHall = double.Parse(Console.ReadLine());
            double cakePrice = rentOfHall * 20 / 100;
            double drinks = cakePrice - (cakePrice * 45 / 100);
            double animator = rentOfHall / 3;
            double sum = rentOfHall + cakePrice + drinks + animator;
            Console.WriteLine(sum);
        }
    }
}
