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
            Car honda = new Car("Civic", "Honda", true);
            Car hyundai = new Car("Santa Fe", "Hyundai", false);

            // Getting the Brand
            Console.WriteLine("Brand is " + honda.Brand);
            Console.WriteLine("Brand is  "  + hyundai.Brand);
            Console.Read();
        }
    }
}
