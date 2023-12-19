using System;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Exceptional product.",
                "I can't live without this product."
            };

            List<string> events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> authors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            List<string> cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int messagesToCreate = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesToCreate; i++)
            {
                Random random = new Random();
                int randomPhrase = random.Next(0, phrases.Count - 1);
                int randomEvent = random.Next(0, events.Count - 1);
                int randomAuthor = random.Next(0, authors.Count - 1);
                int randomCity = random.Next(0, cities.Count - 1);
                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {authors[randomAuthor]} - {cities[randomCity]}.");
            }


        }
    }


}
