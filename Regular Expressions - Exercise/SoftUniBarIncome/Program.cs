using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalIncome = 0;
            while (input != "end of shift")
            {
                Match matches = Regex.Match(input,
                    @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$");
                if (matches.Success)
                {
                    double totalPrice = double.Parse(matches.Groups["price"].ToString()) * double.Parse(matches.Groups["quantity"].ToString());
                    Console.WriteLine($"{matches.Groups["name"]}: {matches.Groups["product"]} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
