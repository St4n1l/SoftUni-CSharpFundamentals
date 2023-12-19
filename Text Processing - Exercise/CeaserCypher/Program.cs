using System;
using System.Text;

namespace CeaserCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var encryptedText = new StringBuilder();
            foreach (var letter in text)
            {
                char newLetter = Convert.ToChar(letter + 3);
                encryptedText.Append(newLetter);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
