using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int curr = 0;

            while (a != 0)
            {
                for (int i = 1; i <= a; i++)
                {
                    curr = a % 10;
                    sum += curr;
                    a /= 10;
                }

            }
            Console.WriteLine(sum);
        }
    }
}