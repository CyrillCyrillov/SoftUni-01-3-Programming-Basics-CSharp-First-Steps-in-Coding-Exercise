using System;

namespace Task07_Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());
            double priceRaspberies = priceStrawberries / 2;
            double priceOranges = priceRaspberies - (priceRaspberies * 40 / 100);
            double priceBananas = priceRaspberies - (priceRaspberies * 80 / 100);
            double sum = priceStrawberries * strawberries + priceBananas * bananas + priceOranges * oranges + priceRaspberies * raspberries;
            Console.WriteLine(sum);
        }
    }
}
