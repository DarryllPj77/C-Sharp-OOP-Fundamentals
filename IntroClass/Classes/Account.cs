using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClass.Classes
{
    internal class Account
    {
        public int AccountNumber { get; set; }

        public double Balance { get; private set; }
    }
}
