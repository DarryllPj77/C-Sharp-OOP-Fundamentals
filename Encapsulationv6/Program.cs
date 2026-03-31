using System;

namespace Encapsulationv6
{
    // STYLE 6 — Method-Based Encapsulation - No public properties.
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string newName)
            {
                if (!string.IsNullOrEmpty(newName))
                {
                    name = newName;
                }
            }

            public void SetAge(int newAge)
            {
                if(newAge >= 0)
                {
                    age = newAge;
                }
            }

            public string GetName()
            {
                return name;
            }

            public int GetAge()
            {
                return age;
            }

            public void ShowInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introductory for OOP Fundamentals");
            Console.WriteLine("----------ENCAPSULATIONv6----------");

            Person person1 = new Person("Darryll", 21);

            person1.ShowInfo();

            person1.SetName("Celeine");
            person1.SetAge(21);
            person1.ShowInfo();
        }
    }
}
