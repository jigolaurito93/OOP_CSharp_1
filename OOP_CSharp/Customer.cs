using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;
        // Read-only instance field initialized from the constructor
        private readonly int _id;

        // Read Only Property
        // Omitting the setter
        public int Id { 
            get
            { return _id; }
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Custom Constructor
        public Customer(string name, string address, string contactNumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Custom Constructor
        public Customer(string name)
        {
            _id = nextId++;
            Name = name;   
        }

        // Default Constructor
        public Customer()
        {
            _id = nextId++;
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

        // Using Static
        // It is used to declare members of the class that belongs to the class itself
        // rather than to any specific instance of the class
        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm doing some customer stuff!");
        }

        public void getDetails()
        {
            Console.WriteLine($"Details about the customer: Name is {Name} and ID is {_id}");
        }
    }
}
