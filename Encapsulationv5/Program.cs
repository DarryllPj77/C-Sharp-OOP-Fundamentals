using System;

namespace Encapsulationv5
{
    // STYLE 5 — Write-Only Property (Rare) - You can set but cannot read:
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name { set { name = value; } }
            public int Age { set { age = value; } }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
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
            Console.WriteLine("----------ENCAPSULATIONv5----------");

            Person person1 = new Person("Darryll", 21);

            person1.ShowInfo();

            person1.Name = "New";
            person1.Age = 31;
            person1.ShowInfo();

            // string nameValue = person1.Name;  // ❌ ERROR - Cannot read write-only property
            // int ageValue = person1.Age;       // ❌ ERROR - Cannot read write-only property
        }
    }
}
