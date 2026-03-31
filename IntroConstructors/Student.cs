namespace IntroConstructors
{
    internal class Student
    {
        // Auto-implemented properties
        public string Name { get; set; } // default value null
        public int Age { get; set; } // default value = 0
        public double Grade { get; set; }  // default value = 0

        // Parameterized constructor
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Default Constructors
        // Parameterized Constructors
        // Private Constructors
        // Static Constructors
        // Copy Constructors


    }
}
