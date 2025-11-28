using System;

namespace Task05
{
    class Program
    {
        static bool IsEmpty(string str)
        {
            return str == null || str.Length == 0;
        }

        static void Main(string[] args)
        {
            string test1 = "";
            string test2 = "Hello";
            string test3 = null;

            Console.WriteLine($"IsEmpty(\"\"): {IsEmpty(test1)}"); // True
            Console.WriteLine($"IsEmpty(\"Hello\"): {IsEmpty(test2)}"); // False
            Console.WriteLine($"IsEmpty(null): {IsEmpty(test3)}"); // True
        }
    }
}