using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    internal class Car
    {
        // member variable
        // private hides the variable from other classes
        // These are backing fields
        private string _model;
        private string _brand;
        private int _year;

        // Static field, can be accessed using class itself
        // Can't use an instance of a class to access.
        public static int numberOfCars = 0;

        //Property
        public bool IsLuxury { get; set; }
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get 
            { 
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You did't assign a value to the brand!!!!");
                    _brand = "DEFAULT VALUE";
                }
                else
                {
                    _brand = value;
                }
                }
        }
        public int Year 
        { get => _year;
         set
            {
                if (value < 1000 || value > 9999)
                {
                    Console.WriteLine("Invalid Year. Year has to be 4 digits for " + _brand);
                }
                else
                {
                    _year = value;
                }
            }
                }

        //Constructor
        public Car(string model, string brand, bool isLuxury, int year)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Year = year;
        }

        // Custom Constructor
        public Car()
        {
            // Increment the numberOfCars value to 1 everytime you create an instance of the class
            numberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine("Im driving my " + Year + " " +  Brand + " " + Model);
        }
    }
}
