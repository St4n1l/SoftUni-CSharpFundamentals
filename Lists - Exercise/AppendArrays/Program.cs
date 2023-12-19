using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersString = Console.ReadLine().Split('|').Reverse().ToList();
            var numbers = new List<int>();
            foreach (var item in numbersString)
            {
                numbers.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
