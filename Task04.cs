using System;

namespace Task04
{
    class Program
    {
        static void PrintSeparator()
        {
            Console.WriteLine("------------------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 04: Print Separator Line");
            PrintSeparator();
            Console.WriteLine("This is some text above the separator.");
            PrintSeparator();
        }
    }
}