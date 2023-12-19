using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int current = numbers[0];
                for (int l = 0; l < numbers.Length - 1; l++)
                {
                    numbers[l] = numbers[l + 1];
                }
                numbers[numbers.Length - 1] = current;
            }
            Console.WriteLine(string.Join(' ', numbers));

        }
    }
}
