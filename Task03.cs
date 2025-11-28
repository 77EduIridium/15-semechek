using System;

namespace Task03
{
    class Program
    {
        static int Square(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));
            Console.WriteLine(Square(10));
            Console.WriteLine(Square(1));
            Console.WriteLine(Square(0));
            Console.WriteLine(Square(2));
        }
    }
}