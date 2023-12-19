using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            Dictionary<char, int> countOfChars = new Dictionary<char, int>();
            List<char> modifiedChars = new List<char>();


            foreach (var item in chars)
            {
                if (item != ' ')
                {
                    modifiedChars.Add(item);
                }
            }
            foreach (var character in modifiedChars)
            {
                if (!countOfChars.ContainsKey(character))
                {
                    countOfChars.Add(character, 1);
                }
                else
                {
                    countOfChars[character]++;
                }
            }

            foreach (var key in countOfChars)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }

        }
    }
}