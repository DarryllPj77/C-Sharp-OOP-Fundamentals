using IntroClass.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClass
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // Create Bank
            Bank bank = new Bank(); // -> instance of a back called Object

            // Create Customer
            Customer customer1 = new Customer();
            customer1.Name = "Darryll";
            customer1.Address = "Blk 22 Lot 1 St.Santol Palmera Woodlands";
            bank.Customers.Add(customer1);
        }
    }
}
