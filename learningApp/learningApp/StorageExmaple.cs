using System;

namespace memoryTest
{
    public struct Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Program
    {
        static void Main()
        {
            Person p1 = new("Hasan", 21);
            Console.WriteLine($"p1 Name: {p1.Name}, Age: {p1.Age}");

            Person p2 = p1;
            p2.Name = "Hanna";
            p2.Age = 25;
            Console.WriteLine($"p2 Name: {p2.Name}, Ahe: {p2.Age}");
            Console.WriteLine($"p1 Name: {p1.Name}, Age: {p1.Age}");
        }
    }
}