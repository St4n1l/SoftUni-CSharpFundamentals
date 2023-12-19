using System;

namespace Division
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] divs = { 10, 7, 6, 3, 2 };
            for (int i = 0; i < divs.Length; i++)
                if (num % divs[i] == 0)
                {
                    Console.WriteLine($"The number is divisible by {divs[i]}");
                    return;
                }
            Console.WriteLine("Not divisible");
        }
    }
}