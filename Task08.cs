using System;

namespace Task08
{
    class Program
    {
        static int Sum(int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = Sum(numbers);
            Console.WriteLine($"Сумма элементов массива: {result}");
        }
    }
}