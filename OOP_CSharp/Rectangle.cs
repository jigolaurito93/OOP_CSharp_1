using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    class Rectangle
    {
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
    }
}
