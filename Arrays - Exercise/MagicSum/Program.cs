using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int first = numbers[i];
                for (int l = i + 1; l < numbers.Length; l++)
                {
                    int second = numbers[l];
                    if (first + second == sum)
                    {
                        Console.WriteLine($"{first} {second}");
                    }
                }
            }
        }
    }
}
