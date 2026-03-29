using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Darryll", 1, 5000);
            employee1.DisplayEmployeeInfo();
        }
    }
}
