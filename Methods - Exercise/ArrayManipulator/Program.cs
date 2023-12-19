using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    arr = Exchange(arr, int.Parse(command[1]));
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    FindMinMax(arr, command[0], command[1]);

                }
                else if (command[0] == "first" || command[0] == "last")
                {
                    FindFirstLast(arr, command[0], int.Parse(command[1]), command[2]);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void FindFirstLast(int[] arr, string firstOrLast, int counts, string evenOrOdd)
        {
            if (counts > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (counts == 0)
            {
                Console.WriteLine($"[]");
                return;
            }

            int resultEvenOdd = 1;

            if (evenOrOdd == "even")
            {
                resultEvenOdd = 0;
            }
            int count = 0;
            List<int> nums = new List<int>();

            if (firstOrLast == "first")
            {
                foreach (int num in arr)
                {
                    if (num % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(num);
                    }
                    if (count == counts) break;

                }
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(arr[i]);
                    }
                    if (count == counts) break;
                }
                nums.Reverse();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");

        }

        private static void FindMinMax(int[] arr, string minOrMax, string evenOrOdd)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int index = -1;
            int resultOddEven = 1;
            if (evenOrOdd == "even") resultOddEven = 0;




            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultOddEven)
                {
                    if (minOrMax == "min" && min >= arr[i])
                    {
                        min = arr[i];
                        index = i;
                    }
                    else if (minOrMax == "max" && max <= arr[i])
                    {
                        max = arr[i];
                        index = i;
                    }
                }
            }

            Console.WriteLine(index > -1 ? index.ToString() : "No matches");
        }
        static int[] Exchange(int[] arr, int command)
        {
            if (command >= arr.Length || command < 0)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            int[] newArr = new int[arr.Length];
            int index = 0;
            for (int i = command + 1; i < arr.Length; i++)
            {
                newArr[index] = arr[i];
                index++;
            }

            for (int i = 0; i <= command; i++)
            {
                newArr[index] = arr[i];
                index++;
            }
            return newArr;



        }
    }
}
