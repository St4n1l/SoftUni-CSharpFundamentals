using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int numOfMessages = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter != numOfMessages)
            {

                counter++;
                string message = Console.ReadLine();
                string loweredMessage = message.ToLower();
                MatchCollection matches = Regex.Matches(loweredMessage, @"[star]");
                int rollback = matches.Count;
                StringBuilder sb = new StringBuilder();
                foreach (var letter in message)
                {
                    int ASCIIOfNewLetter = letter - rollback;
                    sb.Append((char)ASCIIOfNewLetter);
                }

                Match newMatches = Regex.Match(sb.ToString(), @"\@(?<name>[A-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<outcome>[A,D])![^@\-!:>]*->(?<count>[\d]+)");

                if (newMatches.Success)
                {
                    if (newMatches.Groups["outcome"].Value == "A")
                    {
                        attackedPlanets.Add(newMatches.Groups["name"].Value);
                    }
                    else if (newMatches.Groups["outcome"].Value == "D")
                    {
                        destroyedPlanets.Add(newMatches.Groups["name"].Value);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            var orderedAttackedPlanets = attackedPlanets.OrderBy(x => x);
            var orderedDestroyedPlanets = destroyedPlanets.OrderBy(x => x);
            foreach (var planet in orderedAttackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in orderedDestroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
