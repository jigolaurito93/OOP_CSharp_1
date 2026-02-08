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
          

            // Named parameters
            // Different ways to write it
            Math math1 = new Math();

            Console.WriteLine(math1.AddNum(1, 5));
            Console.WriteLine(math1.AddNum(num1: 1, 5));
            Console.WriteLin e(math1.AddNum(1, num2: 5));
            Console.WriteLine(math1.AddNum(num1: 1, num2: 5));
            Console.WriteLine(math1.AddNum(num2: 5, num1: 1));
              

            // Passing arguments by Value and Reference
            void ModifyValue(ref int num)
            {
                num = 100; // Change affects the original variable
            }

            int number = 50;
            ModifyValue(ref number);
            Console.WriteLine(number); // Output: 100 (modified)
            

            Rectangle r1 = new Rectangle();
            r1.Height = 5;
            r1.Width = 5;
            Console.WriteLine("The area of r1 is: " + r1.Area);
            

            // Using Static
            // It is used to declare members of the class that belongs to the class itself
            // rather than to any specific instance of the class
            Customer.DoSomeCustomerStuff();
            

            // Example of static field where you can access a field through the class itself, not from an object
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine(Car.numberOfCars);
            

            Animal myPet = new Dog();

            if (myPet is Animal)
            {
                Console.WriteLine("myPet is a Dog");
            }
            else
            {
                Console.WriteLine("myPet is not a Dog");
            }
            

            // Accessing ID Key with incrementing ID number from a readonly private field
            Customer cust1 = new Customer("Mitch");
            Customer cust2 = new Customer("Joan");
            Customer cust3 = new Customer();
            cust1.getDetails();
            cust2.getDetails();

            //Console.WriteLine("Customer 1 ID no. is: " + cust1.Id);
            //Console.WriteLine("Customer 2 ID no. is: " + cust2.Id);
            cust3.Password = "123password$%^";
            cust3.getDetails();
            */

            // Const and Readonly Field in Rectangle Class
            Rectangle rectangle1 = new Rectangle("Blue");
            rectangle1.Height = 5;
            rectangle1.Width = 2;
            rectangle1.DisplayDetails();

            Console.ReadKey();
        }
    }

    class Animal { }

    class Dog : Animal {}

    


}
