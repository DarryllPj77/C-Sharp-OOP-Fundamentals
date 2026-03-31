using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntroPrivateConstructors
{
    internal class Subject
    {
        
        public string Name { get; private set; } // Writable only from within the class
        public string Description { get; private set; } // Writable only from within the class

        // Public constructor
        public Subject()
        {
            
        }

        // Private Constructor -> this can take private fields
        private Subject(string name)
        {
            Name = name;
            Description = name;
        }

        public static Subject CreateSubject(string name) // - > need this to use this => Subject subject1 = new Subject("Math")
        {
            return new Subject(name);
        }
    }
}
