using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            while (true)
            {
                string[] information = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (information[0] == "buy")
                {
                    break;
                }
                string product = information[0];
                double price = double.Parse(information[1]);
                int quantity = int.Parse(information[2]);
                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(quantity);
                }
                else if (products.ContainsKey(product) && price != products[product][0])
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }
                else if (products.ContainsKey(product) && price == products[product][0])
                {
                    products[product][1] += quantity;
                }
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
