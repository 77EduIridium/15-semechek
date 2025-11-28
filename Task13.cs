using System;
using System.Diagnostics;

namespace Task13
{
    class Program
    {
        static int Multiply(int a, int b)
        {
            Debug.Assert(a != 0 && b != 0, "Одна из переменных равна нулю");
            return a * b;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int b1 = 1;

            Console.WriteLine($"{a} * {b} = {Multiply(a, b)}");
            Console.WriteLine($"{a} * {b1} = {Multiply(a, b1)}");
        }
    }
}