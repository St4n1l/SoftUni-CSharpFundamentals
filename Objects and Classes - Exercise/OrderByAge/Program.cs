using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            while (true)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (info[0] == "End")
                {
                    break;
                }
                var person = new Person(info[0], info[1], int.Parse(info[2]));

                people.Add(person);

            }

            foreach (var person in people.OrderBy(person => person.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
