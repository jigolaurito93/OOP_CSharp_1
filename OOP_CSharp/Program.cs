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
            Car honda = new Car("Civic", "");
            Car hyundai = new Car("Santa Fe", "Hyundai");

            Console.WriteLine("Please enter a brand name");
            // Setting the Brand
            honda.Brand = Console.ReadLine();

            // Getting the Brand
            Console.WriteLine($"You entered {honda.Brand} as the car's brand.");

            Console.Read();
        }
    }
}
