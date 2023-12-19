using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> demons = new Dictionary<string, List<double>>();
            string namePattern = @"[^\+\-\*\/\.,0-9]";
            string damagePattern = @"-?\d+\.?\d*";
            string operatorPattern = @"[*\/]";
            string[] demonNames = Regex.Split(Console.ReadLine(), @"[,\s]+").OrderBy(x => x).ToArray();

            foreach (var demon in demonNames)
            {
                StringBuilder fullName = new StringBuilder();
                StringBuilder actualName = new StringBuilder();
                MatchCollection nameMatch = Regex.Matches(demon, namePattern);
                MatchCollection damageMatch = Regex.Matches(demon, damagePattern);
                MatchCollection operatorMatch = Regex.Matches(demon, operatorPattern);
                int health = 0;
                double damage = 0;

                foreach (var match in nameMatch)
                {
                    fullName.Append(match.ToString());
                }

                for (int i = 0; i < demon.Length; i++)
                {
                    actualName.Append(demon[i]);
                }

                string name = actualName.ToString();

                foreach (char match in fullName.ToString())
                {
                    health += match;
                }

                foreach (var match in damageMatch)
                {
                    damage += double.Parse(match.ToString());
                }

                foreach (var match in operatorMatch)
                {
                    if (match.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                if (!demons.ContainsKey(name))
                {
                    demons.Add(name, new List<double>());
                    demons[name].Add(health);
                    demons[name].Add(damage);
                }
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }

        }
    }
}