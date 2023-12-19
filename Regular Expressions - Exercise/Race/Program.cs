using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string[] racersAdded = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            foreach (var racer in racersAdded)
            {
                racers.Add(racer, 0);
            }

            while (input != "end of race")
            {

                StringBuilder name = new StringBuilder();
                int distance = 0;
                MatchCollection matchedNames = Regex.Matches(input, @"[A-Z]|[a-z]");
                MatchCollection matchedDigits = Regex.Matches(input, @"[0-9]");

                foreach (var letter in matchedNames)
                {
                    name.Append(letter);
                }

                if (racers.ContainsKey(name.ToString()))
                {
                    foreach (var digit in matchedDigits)
                    {
                        distance += int.Parse(digit.ToString());
                    }
                    racers[name.ToString()] += distance;
                }

                input = Console.ReadLine();
            }

            var orderedRacers = racers.OrderByDescending(x => x.Value).Take(3);
            int counter = 0;
            foreach (var racer in orderedRacers)
            {
                counter++;
                switch (counter)
                {
                    case 1:
                        Console.WriteLine($"1st place: {racer.Key}");
                        break;
                    case 2:
                        Console.WriteLine($"2nd place: {racer.Key}");
                        break;
                    case 3:
                        Console.WriteLine($"3rd place: {racer.Key}");
                        break;
                }
            }
        }
    }
}