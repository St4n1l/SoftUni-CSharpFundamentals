using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * Math.Pow(radius, 2) * height;
                string currentKeg = name;

                if (currentVolume > biggestVolume)
                {
                    biggestVolume = currentVolume;
                    biggestKeg = currentKeg;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
