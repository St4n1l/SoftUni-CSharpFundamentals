using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ').ToArray();
            string[] second = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < second.Length; i++)
            {
                string secondCurrent = second[i];
                for (int ki = 0; ki < first.Length; ki++)
                {
                    string firstCurrent = first[ki];
                    if (secondCurrent == firstCurrent)
                    {
                        Console.Write($"{firstCurrent} ");
                    }
                }
            }
        }
    }
}
