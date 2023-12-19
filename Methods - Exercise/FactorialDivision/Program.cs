using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{GetFactorial(num1) / (GetFactorial(num2)):f2}");
        }

        private static double GetFactorial(double num1)
        {
            double result = 1;
            while (num1 != 1)
            {
                result *= num1;
                num1--;
            }
            return result;
        }
    }
}
