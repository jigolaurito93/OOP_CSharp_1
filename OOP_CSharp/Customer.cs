using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Custom Constructor
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Custom Constructor
        public Customer(string name)
        {
            Name = name;   
        }

        // Default Constructor
        public Customer()
        {
            Name = "Default Name";
            Address = "Default Address";
            ContactNumber = "Default Contact Number";
        }

        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
