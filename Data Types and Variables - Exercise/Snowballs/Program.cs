using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger snowBalls = BigInteger.Parse(Console.ReadLine());
            BigInteger biggestSnowBallSnow = 0;
            BigInteger shortestSnowBallTime = 0;
            BigInteger biggestSnowBallQuality = 0;
            BigInteger biggestSnowBallValue = 0;

            for (int i = 1; i <= snowBalls; i++)
            {
                BigInteger snowBallSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowBallTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowBallQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), (int)snowBallQuality);
                if (snowBallValue > biggestSnowBallValue)
                {
                    biggestSnowBallSnow = snowBallSnow;
                    shortestSnowBallTime = snowBallTime;
                    biggestSnowBallQuality = snowBallQuality;
                    biggestSnowBallValue = snowBallValue;
                }



            }
            Console.WriteLine($"{biggestSnowBallSnow} : {shortestSnowBallTime} = {biggestSnowBallValue} ({biggestSnowBallQuality})");
        }
    }
}
