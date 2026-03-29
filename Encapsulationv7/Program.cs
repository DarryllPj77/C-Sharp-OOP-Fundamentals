using System;

namespace Encapsulationv7
{
    //STYLE 7 — Immutable Object(Strong Encapsulation) - Object becomes permanent.
    internal class Program
    {
        public class Person
        {
            public string Name { get; }
            public int Age { get; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void ShowInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introductory for OOP Fundamentals");
            Console.WriteLine("---------ENCAPSULATIONv7---------");

            Person person1 = new Person("Darryll", 21);

            person1.ShowInfo();

            // 
            /*person1.Age = 50; // impossible
            person1.Name = "Celeine";*/
        }
    }
}
