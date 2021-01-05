using System;

namespace Task03_Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSuma = double.Parse(Console.ReadLine());
            int mounts = int.Parse(Console.ReadLine());
            double lybor = double.Parse(Console.ReadLine());
            double suma = depositSuma + mounts * ((depositSuma * lybor / 100) / 12);
            Console.WriteLine(suma);
        }
    }
}
