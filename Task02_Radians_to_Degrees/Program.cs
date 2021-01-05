using System;

namespace Task02_Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double formula = 180 / Math.PI;
            double degrees = radians * formula;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
