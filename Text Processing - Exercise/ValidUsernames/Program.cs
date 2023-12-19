using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();


            foreach (var username in usernames)
            {
                if (username.Length > 3 && username.Length < 16)
                {
                    bool isValid = true;
                    foreach (var letter in username)
                    {
                        if (!char.IsLetterOrDigit(letter) && letter != '-' && letter != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(username);
                    }
                }
            }

            foreach (var username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
