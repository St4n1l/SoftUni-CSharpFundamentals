using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string firstWord = strings[0];
            string secondWord = strings[1];
            int totalSum = 0;

            if (firstWord.Length > secondWord.Length)
            {
                int currentIndex = 0;
                for (int i = 0; i < secondWord.Length; i++)
                {
                    totalSum += firstWord[i] * secondWord[i];
                    currentIndex++;
                }

                for (int i = firstWord.Length - 1; i >= currentIndex; i--)
                {
                    totalSum += firstWord[i];
                }
            }
            else if (firstWord.Length < secondWord.Length)
            {
                int currentIndex = 0;
                for (int i = 0; i < firstWord.Length; i++)
                {
                    totalSum += firstWord[i] * secondWord[i];
                    currentIndex++;
                }

                for (int i = secondWord.Length - 1; i >= currentIndex; i--)
                {
                    totalSum += secondWord[i];
                }
            }
            else
            {
                int currentIndex = 0;
                for (int i = 0; i < secondWord.Length; i++)
                {
                    totalSum += firstWord[i] * secondWord[i];
                    currentIndex++;
                }
            }

            Console.WriteLine(totalSum);

        }
    }
}
