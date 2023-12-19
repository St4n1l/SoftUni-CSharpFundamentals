using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> oresByQuantity = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!oresByQuantity.ContainsKey(resource))
                {
                    oresByQuantity.Add(resource, 0);
                }
                oresByQuantity[resource] += quantity;
            }

            foreach (var ores in oresByQuantity)
            {
                Console.WriteLine($"{ores.Key} -> {ores.Value}");
            }
        }
    }
}
