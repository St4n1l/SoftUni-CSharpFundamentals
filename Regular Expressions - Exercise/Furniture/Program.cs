using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            List<string> furnitureList = new List<string>();
            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, @">>(?<item>[A-z]+)<<(?<price>[0-9]+(\.[0-9]+)?)\!(?<quantity>[0-9]+)\b");
                if (matches.Success)
                {
                    var name = matches.Groups["item"].Value;
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    furnitureList.Add(name);
                    totalPrice += price * quantity;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            furnitureList.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
