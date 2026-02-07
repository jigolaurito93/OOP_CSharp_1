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
            Car honda = new Car("Civic", "Honda");
            Car hyundai = new Car("Santa Fe", "Hyundai");

            honda.Model = "Jazz";
            Console.WriteLine(honda.Model);

            Console.Read();
        }
    }
}
