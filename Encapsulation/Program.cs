using System;
using System.Data.Common;
using System.Xml.Linq;


// PART 2: DATA — Fields → Properties

namespace Encapsulation
{
    internal class Program
    {
        public class Person
        {
            // Using a Classic Encapsulation -> for beginner only

            // Storage for name and age ; Also called Field
            private string name; 
            private int age;

            // Access Controller
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // Access Controller
            public int Age
            {
                get { return age; }
                set { age = value; }
            }

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
            Console.WriteLine("----------ENCAPSULATION----------");

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

