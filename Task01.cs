using System;

namespace Task01
{
    class Program
    {
        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            int result1 = Max(10, 20);
            Console.WriteLine($"Максимальное значение между 10 и 20: {result1}");

            int result2 = Max(-5, -2);
            Console.WriteLine($"Максимальное значение между -5 и -2: {result2}");
        }
    }
}