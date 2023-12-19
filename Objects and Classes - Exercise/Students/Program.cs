using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] newStudent = Console.ReadLine().Split();
                var student = new Student(newStudent[0], newStudent[1], float.Parse(newStudent[2]));
                students.Add(student);
            }

            var sortedStudents = students.OrderByDescending(c => c.Grade);

            foreach (var item in sortedStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
    }
}
