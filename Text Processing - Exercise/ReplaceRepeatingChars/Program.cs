using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length - 1; i++)
            {

                if (word[i] != word[i + 1])
                {
                    Console.Write(word[i]);
                }
            }

            Console.Write(word[word.Length - 1]);
        }
    }
}
