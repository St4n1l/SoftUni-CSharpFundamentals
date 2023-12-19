
using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spice = 0;
            int days = 0;
            while (n >= 100)
            {
                spice += n - 26;
                n -= 10;
                days++;
            }
            Console.WriteLine(days);
            if (spice > 0)
            {

                Console.WriteLine(spice - 26);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
