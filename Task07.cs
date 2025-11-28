using System;

namespace Task07
{
    class Program
    {
        static int[] GenerateSequence(int count)
        {
            int[] sequence = new int[count];

            for (int i = 1; i < count; i++)
            {
                sequence[i] = i + 1;
            }
            
            return sequence;
        }

        static void Main(string[] args)
        {
            int n = 5;
            int[] result = GenerateSequence(n);

            Console.WriteLine($"Последовательность из {n} чисел:");
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}