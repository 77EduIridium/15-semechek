using System;

namespace Task10
{
    class Program
    {
        static int Sum(int n)
        {
            if (n <= 0) return 0;

            return n + Sum(n - 1);
        }

        static void Main(string[] args)
        {
            int number = 5;
            int result = Sum(number);
            Console.WriteLine($"Сумма чисел от 1 до {number} равна: {result}");
        }
    }
}