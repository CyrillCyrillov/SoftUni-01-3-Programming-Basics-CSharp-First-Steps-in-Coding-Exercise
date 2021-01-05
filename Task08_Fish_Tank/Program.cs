using System;

namespace Task08_Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = (length * width * height) * 0.001;
            double water = volume * (1 - percent * 0.01);
            Console.WriteLine(water);
        }
    }
}
