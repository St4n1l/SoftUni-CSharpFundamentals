using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                for (int j = i; j > 0; j--)
                {
                    int leftPosition = j - 1;
                    if (j > 0)
                    {
                        leftSum += numbers[leftPosition];
                    }
                }

                for (int o = i; o < numbers.Length - 1; o++)
                {
                    int rightPosition = o + 1;
                    if (o < numbers.Length - 1)
                    {
                        rightSum += numbers[rightPosition];
                    }
                }


                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum = 0;
                rightSum = 0;

            }
            Console.WriteLine("no");

        }
    }
}
