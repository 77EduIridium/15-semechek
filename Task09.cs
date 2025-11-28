using System;

namespace Task09
{
    class Program
    {
        static string CheckTemperature(int t)
        {
            if (t < 10)
            {
                return "Cold";
            }
            else if (t >= 10 && t <= 25)
            {
                return "Warm";
            }
            else
            {
                return "Hot";
            }
        }

        static void Main(string[] args)
        {
            int temp1 = 5;
            Console.WriteLine($"{temp1}°C is {CheckTemperature(temp1)}");

            int temp2 = 15;
            Console.WriteLine($"{temp2}°C is {CheckTemperature(temp2)}");

            int temp3 = 30;
            Console.WriteLine($"{temp3}°C is {CheckTemperature(temp3)}");
        }
    }
}