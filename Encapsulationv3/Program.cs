using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulationv3
{
    internal class Program
    {
        public class Person
        {
            // Encapsulation with Validation (REAL ENCAPSULATION)

            // Storage for name and age ; Also called Field
            private int age;
            private string name;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 0)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Age!");
                    }
                }
            }
            public string Name
            {
                get { return name; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        name = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Name!");
                    }
                }
            }
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
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
            Console.WriteLine("----------ENCAPSULATIONv3----------");

            //Hide data
            //Control access

            Person person1 = new Person("", 21);
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
