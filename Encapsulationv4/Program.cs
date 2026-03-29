using System;

namespace Encapsulationv4
{
    internal class Program
    {
        // STYLE 4 — Read-Only Encapsulation
        class Person
        {
            public string Name { get; private set; }
            public int Age { get; private set; }


            // Constructor 
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // Method
            public void ShowInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introductory for OOP Fundamentals");
            Console.WriteLine("----------ENCAPSULATIONv4----------");

            Person person1 = new Person("Darryll", 21);

            person1.ShowInfo();

            //person1.Name = "Hack"; // The property or indexer 'Program.Person.Name' cannot be used in this context because the set accessor is inaccessible
        }
    }
}
