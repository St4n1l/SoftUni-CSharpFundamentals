using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double cap = double.Parse(Console.ReadLine());
            double courses = Math.Ceiling(people / cap);
            Console.WriteLine(courses);
        }
    }
}
