using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelCount(input);
        }

        static void VowelCount(string input)
        {
            Console.WriteLine(input.Count(vowel => "aeoui".Contains(vowel)));
        }
    }
}
