using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            Subtract(result, num3);

        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Subtract(int result, int num3)
        {
            Console.WriteLine(result - num3);
        }
    }
}
