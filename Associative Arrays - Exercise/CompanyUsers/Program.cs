using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesByEmployees = new Dictionary<string, List<string>>();
            string[] info = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            while (info[0] != "End")
            {
                if (!companiesByEmployees.ContainsKey(info[0]))
                {
                    companiesByEmployees.Add(info[0], new List<string>());
                    companiesByEmployees[info[0]].Add(info[1]);
                }
                else if (!companiesByEmployees[info[0]].Any(x => x == info[1]))
                {
                    companiesByEmployees[info[0]].Add(info[1]);
                }
                info = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var company in companiesByEmployees)
            {
                Console.WriteLine($"{company.Key}");
                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}
