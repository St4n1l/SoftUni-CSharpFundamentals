using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            GetRange(start, end);
        }
        static void GetRange(char a, char b)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }

        }
    }
}
