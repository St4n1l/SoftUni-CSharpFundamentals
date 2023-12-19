using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    AddNumber(nums, command[1]);
                }
                else if (command[0] == "Insert")
                {
                    InsertNumber(nums, command[1], command[2]);
                }
                else if (command[0] == "Remove")
                {
                    RemoveNumber(nums, command[1]);
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        ShiftLeft(nums, command[2]);
                    }
                    else
                    {
                        ShiftRight(nums, command[2]);
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void ShiftRight(List<int> nums, string count)
        {
            for (int i = 0; i < int.Parse(count); i++)
            {
                int lastNum = nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
                nums.Insert(0, lastNum);

            }
        }

        static void ShiftLeft(List<int> nums, string count)
        {
            for (int i = 0; i < int.Parse(count); i++)
            {
                int firstNum = nums[0];
                nums.RemoveAt(0);
                nums.Add(firstNum);

            }
        }

        static void RemoveNumber(List<int> nums, string index)
        {
            if (int.Parse(index) > -1 && int.Parse(index) < nums.Count)
            {
                nums.RemoveAt(int.Parse(index));
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void InsertNumber(List<int> nums, string number, string index)
        {
            if (int.Parse(index) > -1 && int.Parse(index) < nums.Count)
            {
                nums.Insert(int.Parse(index), int.Parse(number));
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void AddNumber(List<int> nums, string number)
        {
            nums.Add(int.Parse(number));
        }
    }
}
