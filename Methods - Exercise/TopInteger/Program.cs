using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (Sum(i) && OddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }


        }
        static bool Sum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum == 8 || sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool OddDigit(int num)
        {
            int currentNum = 0;
            while (num != 0)
            {
                currentNum = num % 10;
                num /= 10;
                if (currentNum % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}