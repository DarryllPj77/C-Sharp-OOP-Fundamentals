using System;

// PART 1: CLASS(Blueprint)
namespace OOPIntro
{
    internal class Program
    {

        public class Person
        {
            public string name;
            public int age;

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
            Console.WriteLine("--------------CLASS-------------");

            Person person1 = new Person("Darryll", 21);
            Person person2 = new Person("Celeine", 21);

            person1.ShowInfo();
            person2.ShowInfo();

            // Test case without encapsulation 
            person1.name = "Hack";
            Console.WriteLine("\nAfter Hacking");
            person1.ShowInfo();
        }
    }
}

// Bad Design
///*class Person
//{
//    // person data
//    // database connection
//    // login system
//}*/

// Good Design
// ONLY person-related data & behavior