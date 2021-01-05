using System;

namespace Task01_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double fixing = 1.79549;
            double bgn = usd * fixing;
            Console.WriteLine(bgn);
        }
    }
}
