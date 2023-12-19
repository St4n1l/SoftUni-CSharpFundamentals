using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] even = new int[lines];
            int[] odd = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    even[i] = numbers[0];
                    odd[i] = numbers[1];
                }
                else
                {
                    odd[i] = numbers[0];
                    even[i] = numbers[1];
                }


            }
            Console.WriteLine(String.Join(" ", even));
            Console.WriteLine(String.Join(" ", odd));
        }
    }
}