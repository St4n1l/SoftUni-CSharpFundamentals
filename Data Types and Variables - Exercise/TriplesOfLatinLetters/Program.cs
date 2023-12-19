using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < n; l++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + l);
                        char thirdChar = (char)('a' + j);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
