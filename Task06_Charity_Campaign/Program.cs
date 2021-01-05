using System;

namespace Task06_Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double sumCakes = cakes * 45;
            double sumWaffles = waffles * 5.80;
            double sumPancakes = pancakes * 3.20;
            double sumPerDay = (sumCakes + + sumWaffles + sumPancakes) * confectioners;
            double sumAll = sumPerDay * days;
            double sum = sumAll - (sumAll / 8);
            Console.WriteLine(sum);
        }
    }
}
