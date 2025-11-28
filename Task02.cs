using System;

namespace Task02
{
    class Program
    {
        static void PrintInfo(string name, int age)
        {
            Console.WriteLine($"{name}: возвраст {age}");
        }

        static void Main(string[] args)
        {
            PrintInfo("Alice", 30);
            PrintInfo("Bob", 25);
        }
    }
}