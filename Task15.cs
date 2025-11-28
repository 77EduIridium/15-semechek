using System;
using System.Diagnostics;

namespace Task15
{
    // MiniTest:Task14.cs
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

    class GradeCalculator
    {
        private bool CheckRange(double[] doubles)
        {
            foreach (var dbl in doubles)
            {
                if (dbl > 100 || dbl < 0) return false;
            }

            return true;
        }

        public double CalculateFinal(double exam, double project, double attendance)
        {
            if (!CheckRange(new[] {exam, project, attendance}))
            {
                throw new ArgumentOutOfRangeException();
            }

            exam *= 0.5; // 50%
            project *= 0.4; // 40%
            attendance *= 0.1; // 10%

            double final = exam + project + attendance;

            Debug.WriteLine($"Exam (exam * 0.5): {exam}");
            Debug.WriteLine($"Project (project * 0.4): {project}");
            Debug.WriteLine($"Attendance (attendance * 0.1): {attendance}");
            Debug.WriteLine($"Final (exam + project + attendance): {final}");

            return final;
        }

        public string FormatReport(string name, double finalGrade)
        {
            string grade;

            if (finalGrade >= 95) grade = "A";
            else if (finalGrade >= 90) grade = "A-";
            else if (finalGrade >= 85) grade = "B+";
            else if (finalGrade >= 80) grade = "B";
            else if (finalGrade >= 75) grade = "B-";
            else if (finalGrade >= 70) grade = "C+";
            else if (finalGrade >= 65) grade = "C";
            else if (finalGrade >= 60) grade = "C-";
            else if (finalGrade >= 55) grade = "D+";
            else if (finalGrade >= 50) grade = "D";
            else grade = "F";

            return $"{name} - {finalGrade}% ({grade})";
        }

        public void PrintReport(string name, double finalGrade)
        {
            Console.WriteLine(FormatReport(name, finalGrade));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new GradeCalculator();

            Console.WriteLine("===== RUNNING TESTS =====");

            // CalculateFinal Tests

            MiniTest.AreEqual(85, calc.CalculateFinal(90, 80, 70), "CalculateFinal_Correct");

            MiniTest.Test(() =>
            {
                try
                {
                    calc.CalculateFinal(150, 90, 80); // out of range
                    return false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    return true;
                }
            }, "CalculateFinal_OutOfRange");

            // FormatReport Tests

            MiniTest.AreEqual(
                "Алишер - 92% (A-)",
                calc.FormatReport("Алишер", 92),
                "PrintReport_Grade_Aminus"
            );

            MiniTest.AreEqual(
                "Dana - 48% (F)",
                calc.FormatReport("Dana", 48),
                "PrintReport_Grade_F"
            );

            Console.WriteLine();
            Console.WriteLine("\n===== DEMO OUTPUT =====");

            // Regular output
            double f1 = calc.CalculateFinal(96, 94, 100);
            calc.PrintReport("Алишер", f1);

            double f2 = calc.CalculateFinal(82, 80, 75);
            calc.PrintReport("Мадина", f2);

            double f3 = calc.CalculateFinal(40, 50, 60);
            calc.PrintReport("Данияр", f3);
        }
    }
}