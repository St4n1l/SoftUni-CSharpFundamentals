using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();



            for (int i = 0; i < numbers.Length; i++)
            {
                bool biggest = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] >= numbers[i])
                    {
                        biggest = false;
                    }
                }
                if (biggest)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

        }
    }
}