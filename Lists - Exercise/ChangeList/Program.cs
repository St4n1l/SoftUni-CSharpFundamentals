using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    DeleteNum(nums, command[1]);
                }
                else if (command[0] == "Insert")
                {
                    InsertNum(nums, command[1], command[2]);
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        private static void InsertNum(List<int> nums, string element, string index)
        {
            nums.Insert(int.Parse(index), int.Parse(element));
        }

        private static void DeleteNum(List<int> nums, string num)
        {
            nums.RemoveAll(item => item == int.Parse(num));
        }
    }
}