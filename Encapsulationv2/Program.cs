using System;

namespace Encapsulationv2
{
    internal class Program
    {
        public class Person
        {
            // Using Auto-Implemented Properties (MOST COMMON)

            // Storage for name and age ; Also called Field
            public string Name { get; set; }
            public int Age { get; set; }

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
            Console.WriteLine("----------ENCAPSULATIONv2----------");

            //Hide data
            //Control access

            Person person1 = new Person("Darryll", 21);
            Person person2 = new Person("Celeine", 21);


            person1.ShowInfo();
            person2.ShowInfo();

            // Test Case with encapsulation, still can assign
            person1.Name = "Mochi";
            person1.Age = 12;
            person1.ShowInfo();


            // Test case without encapsulation -> Error : 'Program.Person.name' is inaccessible due to its protection level
            /*person1.name = "Hack";
            Console.WriteLine("\nAfter Hacking");
            person1.ShowInfo();*/

        }
    }
}
