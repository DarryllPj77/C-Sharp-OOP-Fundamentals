using System;

namespace IntroPrivateConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate student class
            Student student1 = new Student("Darryll", 21, 97.8);

            // Display student information
            Console.WriteLine("Student 1 Information: ");
            Console.WriteLine($"Student Name: {student1.Name}");
            Console.WriteLine($"Student Age: {student1.Age}");
            Console.WriteLine($"Student Grade: {student1.Grade}");

            // Instantiate student class
            Student student2 = new Student();

            // Display student information
            Console.WriteLine("\nStudent 2 Information: ");
            Console.WriteLine($"Student Name: {student2.Name}");
            Console.WriteLine($"Student Age: {student2.Age}");
            Console.WriteLine($"Student Grade: {student2.Grade}");

            // Subject subject1 = new Subject(); // -> 'Subject' does not contain a constructor that takes 1 arguments
            // Subject subject1 = new Subject("Math"); // -> 'Subject.Subject(string)' is inaccessible due to its protection level

            // Trying to use both public and private constructor for a class

            // Creating a instance of subject instead of using new keyword
            Subject subject1 = Subject.CreateSubject("Math");

            Console.WriteLine("\nFor Display Subjects");
            Console.WriteLine(subject1.Name); // test
        }
    }
}
