using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object/instance of the Class Car
            /*
            Car honda = new Car("Civic", "Honda", true, 190);
            Car hyundai = new Car("Santa Fe", "Hyundai", false, 1976);
            */

            // Getting the Brand
            /*
             Console.WriteLine("Brand is " + honda.Brand);
            Console.WriteLine("Brand is  "  + hyundai.Brand);
            Console.Read();
            

            Customer johnny = new Customer("John");
            Customer jack = new Customer("Jack", "123 Fake Street", "123-456-7890");
            Console.WriteLine(johnny.Name);
            Console.WriteLine(jack.Address);

            // Default Customer with no arguments provided
            Customer newCustomer = new Customer();
            Console.WriteLine("Please enter customers name.");
            newCustomer.Name = Console.ReadLine();
            Console.WriteLine("Details about customer: " + newCustomer.Name);
            

            Car mazda = new Car("CX7", "Mazda", false, 1947);
            mazda.Drive();
            

            // Default object with no arguments
            Customer customer1 = new Customer();
            customer1.SetDetails("Jean", "234 True Street", "1234567890");
            Console.WriteLine(customer1.Name);
            Console.WriteLine(customer1.Address);
            Console.WriteLine(customer1.ContactNumber);
            */

            // Constructor with default/optional parameter
            Employee employee1 = new Employee("James");
            Console.WriteLine(employee1.Name);
            Console.WriteLine(employee1.EmployeeID);
            Console.WriteLine(employee1.Department);

            // Method with default/optional parameter
            employee1.setDetails("Nate", "2346534645");
            Console.WriteLine(employee1.Name);
            Console.WriteLine(employee1.EmployeeID);
            Console.WriteLine(employee1.Department);





            Console.ReadKey();


        }
    }
}
