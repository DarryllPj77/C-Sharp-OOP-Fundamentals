using System;

namespace IntroConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate student class
            Student student1 = new Student("Darryll", 21, 97.8);

            // Display student information
            Console.WriteLine("Student Information: ");
            Console.WriteLine($"Student Name: {student1.Name}");
            Console.WriteLine($"Student Age: {student1.Age}");
            Console.WriteLine($"Student Grade: {student1.Grade}");


        }
    }
}
