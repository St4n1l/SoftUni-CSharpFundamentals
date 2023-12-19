using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool lenght = LenghtCheck(password);
            bool lettersAndDigits = SymbolCheck(password);
            bool atLeast2Digits = DigitCheck(password);

            if (lenght == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (lettersAndDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (atLeast2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (lenght == true && lettersAndDigits == true && atLeast2Digits == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool DigitCheck(string password)
        {
            int count = 0;
            bool result = false;

            foreach (char symbol in password)
            {
                if (Char.IsDigit(symbol))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return result = true;
            }
            else
            {
                return result = false;
            }
        }

        static bool SymbolCheck(string password)
        {
            bool result = true;
            foreach (char symbol in password)
            {
                if (!Char.IsDigit(symbol) && !Char.IsLetter(symbol))
                {
                    result = false;
                }

            }
            return result;
        }

        private static bool LenghtCheck(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
