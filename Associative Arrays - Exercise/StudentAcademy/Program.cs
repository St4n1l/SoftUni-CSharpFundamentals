using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsByGrades = new Dictionary<string, List<double>>();
            int count = int.Parse(Console.ReadLine());
            int counter = 0;
            while (count != counter)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsByGrades.ContainsKey(name))
                {
                    studentsByGrades.Add(name, new List<double>());
                    studentsByGrades[name].Add(grade);
                }
                else
                {
                    studentsByGrades[name].Add(grade);
                }
                counter++;
            }

            foreach (var item in studentsByGrades)
            {
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}
