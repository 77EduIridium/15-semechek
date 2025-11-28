using System;
using System.Linq;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPasswordStrong(string pass)
            {
                return pass.Length >= 6 && pass.Any(char.IsDigit) && pass.Any(char.IsLetter);
            }

            string password1 = "abc123";
            string password2 = "12abs";
            string password3 = "12345a";
            string password4 = "abcdef";

            Console.WriteLine($"IsPasswordStrong(\"{password1}\"): {IsPasswordStrong(password1)}"); // True
            Console.WriteLine($"IsPasswordStrong(\"{password2}\"): {IsPasswordStrong(password2)}"); // False
            Console.WriteLine($"IsPasswordStrong(\"{password3}\"): {IsPasswordStrong(password3)}"); // True
            Console.WriteLine($"IsPasswordStrong(\"{password4}\"): {IsPasswordStrong(password4)}"); // False
        }
    }
}