using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            while (count < number)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{number} ");
                }
                count++;
                Console.WriteLine();
            }

        }
    }
}
