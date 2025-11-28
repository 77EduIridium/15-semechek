using System;

namespace Task14
{
    public class MiniTest
    {
        /// <summary>
        /// Checks if excepted is actual, Fails if not.
        /// </summary>
        /// <typeparam name="T">Type that needs to be checked</typeparam>
        /// <param name="expected">excepting value</param>
        /// <param name="actual">actual value</param>
        /// <param name="testName">Name of test to display in terminal</param>
        public static void AreEqual<T>(T expected, T actual, string testName)
        {
            if (Equals(expected, actual))
                Console.Write($"[Test {testName}] OK ");
            else
                Console.Write($"[Test {testName}] FAIL: expected {expected}, got {actual} ");
        }

        /// <summary>
        /// Simple "test" method, that requires Func<bool> and name for displaying
        /// </summary>
        /// <param name="testMethod">Method to test</param>
        /// <param name="name">Name of the test</param>
        public static void Test(Func<bool> testMethod, string name)
        {
            try // Func exception catch
            {
                if (testMethod()) // true - OK
                    Console.Write($"[Test {name}] OK ");
                else // false - FAIL
                    Console.Write($"[Test {name}] FAIL ");
            }
            catch (Exception ex) // Fatal
            {
                Console.Write($"[Test {name}] FAIL: {ex.Message} ");
            }
        }
    }

    public static class Functions
    {
        /// <summary>
        /// Checks two numbers
        /// </summary>
        /// <param name="a">First to check</param>
        /// <param name="b">Second to check</param>
        /// <returns>Max number beetwen two number</returns>
        public static int Max(int a, int b) => a > b ? a : b;

        /// <summary>
        /// Bruh
        /// </summary>
        /// <param name="x">Bruh</param>
        /// <returns>x * x</returns>
        public static int Square(int x) => x * x;

        /// <summary>
        /// Safe Math.Sqrt, checks if x is under 0 -> throw exception
        /// </summary>
        /// <param name="x">beb bruh</param>
        /// <returns>Math.Sqrt(x)</returns>
        /// <exception cref="ArgumentException">Negative Value</exception>
        public static double SafeSqrt(double x) // NOTE - safe required not only for test
        {
            if (x < 0) throw new ArgumentException("Negative value");
            return Math.Sqrt(x);
        }

        /// <summary>
        /// Bruh
        /// </summary>
        /// <param name="n">Bruuuh</param>
        /// <returns>1 to n sum</returns>
        public static int SumTo(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Max
            MiniTest.AreEqual(5, Functions.Max(5, 3), "Max_Positive");
            MiniTest.AreEqual(3, Functions.Max(5, 3), "Max_Fail");  // FAIL

            // Square
            MiniTest.AreEqual(16, Functions.Square(4), "Square_Simple");
            MiniTest.AreEqual(15, Functions.Square(4), "Square_Fail"); // FAIL

            // SafeSqrt
            // NOTE - Testing SafeSqrt like that because of double.
            MiniTest.Test(() =>
            {
                try
                {
                    Functions.SafeSqrt(-5);
                    return false; // исключения нет
                }
                catch
                {
                    return true; // исключение есть
                }
            }, "SafeSqrt_Negative");

            MiniTest.Test(() =>
            {
                try
                {
                    Functions.SafeSqrt(9);
                    return false;
                }
                catch
                {
                    return true;
                }
            }, "SafeSqrt_Fail");

            // SumTo
            MiniTest.AreEqual(15, Functions.SumTo(5), "SumTo_5");
            MiniTest.AreEqual(10, Functions.SumTo(5), "SumTo_Fail"); // FAIL
        }
    }
}
