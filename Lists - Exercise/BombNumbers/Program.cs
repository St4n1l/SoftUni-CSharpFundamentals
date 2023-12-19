using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = bomb[0];
            int power = bomb[1];

            for (int i = 0; i < nums.Count; i++)
            {
                int target = nums[i];
                if (target == bombNumber)
                {
                    BombNumber(nums, power, i);
                }
            }
            Console.WriteLine(nums.Sum());
        }

        private static void BombNumber(List<int> nums, int power, int index)
        {
            int start = Math.Max(0, index - power);
            int end = Math.Min(nums.Count - 1, index + power);

            for (int i = start; i <= end; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
