
using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int startingPower = pokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;
                if (pokePower * 2 == startingPower && pokePower >= exhaustionFactor)
                {
                    if (exhaustionFactor == 0)
                    {
                        pokePower *= 1;
                    }
                    else
                    {

                        pokePower /= exhaustionFactor;
                    }
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
