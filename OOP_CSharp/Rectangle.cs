using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    class Rectangle
    {
        // Const and readonly are two keywords used to define non-modifiable fields
        // but they differ in terms of when they are initialized and their usage contexts.

        // declaration of field
        public const int NumberOfCorners = 4;
        // declaration of field
        public readonly string Color;

        public double Width { get; set; }
        public double Height { get; set; }
        // Computed Properties and No Constructor
        public double Area 
        {
            // Only has a getter, this is Read Only and 
            // you can't set a value on an object since there is no setter
            get
            {
                return Width * Height;
            }
            // No setter here   
        }

        // Constructor
        public Rectangle(string color)
        {
            Color = color;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("The area of this rectangle is: " + Area + ". The number of corners is: " + NumberOfCorners + ". The color is: " + Color + ".");
        }
    }
}
