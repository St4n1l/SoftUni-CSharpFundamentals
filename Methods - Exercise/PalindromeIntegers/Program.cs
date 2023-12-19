using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (Palindrome(input))
                {
                    Console.WriteLine("true");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("false");
                    input = Console.ReadLine();
                }

            }

        }
        static bool Palindrome(string input)
        {
            bool result = false;
            int number = int.Parse(input);
            if (input.Length == 1)
            {
                return result = true;
            }
            else
            {

                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input.Length == 0)
                    {
                        return result = true;
                    }

                    if (input[i] == input[input.Length - 1])
                    {
                        return result = true;
                    }
                    else
                    {
                        return result = false;
                    }
                }
                number = int.Parse(input);
                return result;
            }



        }




    }
}