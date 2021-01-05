using System;

namespace Task03_Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double hours = pages / pagesPerHour / days;
            Console.WriteLine(hours);
        }
    }
}
