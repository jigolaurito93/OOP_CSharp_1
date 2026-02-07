using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    class Employee
    {
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public string Department { get; set; }

        // Default/optional parameter for constructor
        public Employee(string name, string employeeId = "NA", string department = "NA")
        {
            Name = name;
            EmployeeID = employeeId;
            Department = department;
        }

        // Default/optional parameter for methods
        public void setDetails(string name, string employeeId = "NA", string department = "NA")
        {
            Name = name;
            EmployeeID = employeeId;
            Department = department;
        }
    }
}
