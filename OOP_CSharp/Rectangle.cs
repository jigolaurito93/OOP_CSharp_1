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
        // Computed Property
        public double Area 
        { 
            get
            {
                return Width * Height;
            }
                
        }
    }
}
