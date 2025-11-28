using System;

namespace Task06
{
    class Program
    {
        static (int sum, int diff) Calc(int a, int b)
        {
            int sum = a + b;
            int diff = a - b;
            return (sum, diff);
        }

        static void Main(string[] args)
        {
            var result1 = Calc(10, 5);
            Console.WriteLine($"Сумма: {result1.sum}, Разность: {result1.diff}");

            var result2 = Calc(20, 30);
            Console.WriteLine($"Сумма: {result2.sum}, Разность: {result2.diff}");
        }
    }
}