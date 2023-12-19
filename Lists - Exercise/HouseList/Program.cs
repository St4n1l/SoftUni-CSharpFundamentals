using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            List<string> command = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                command = Console.ReadLine().Split().ToList();

                if (!command.Contains("not"))
                {
                    if (!guests.Contains(command[0]))
                    {
                        guests.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(command[0]))
                    {
                        string name = command[0];
                        guests.RemoveAll(item => item == name);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
