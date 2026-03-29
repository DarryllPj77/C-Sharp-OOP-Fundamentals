using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEncapsulation
{
    internal class Employee
    {
        // Fields or Attributes of the Object -> 
        private string name;
        private int employeeId;
        private double salary;

        // Constructor
        public Employee(string name, int employeeId, double salary)
        {
            this.name = name;
            this.employeeId = employeeId;
            this.salary = salary;
        }

        // Properties to access and modify private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative.");
                }
            }
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}"); // ✅ Using property
            Console.WriteLine($"Name: {Name}"); // ✅ Using property
            Console.WriteLine($"Salary: ${salary}"); // ❌ Using field directly - Bad Practice; for practice purposes its fine
        }
    }
}
