using System;

namespace Task12
{
    class Program
    {
        static double SafeSqrt(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Cannot compute square root of a negative number.");
            }
            return Math.Sqrt(x);
        }

        static void Main(string[] args)
        {
            double[] testValues = { 16, 0, 25, -4, 9 };

            foreach (double value in testValues)
            {
                try
                {
                    double result = SafeSqrt(value);
                    Console.WriteLine($"Square root of {value} is {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error for input {value}: {ex.Message}");
                }
            }
        }
    }
}