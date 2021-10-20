using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    class Employee
    {
        public string empName { get; set; }
        public int empId { get; set; }
        public Employee(string name) : this(name, 1) { }
        public Employee(string name, int Id)
        {
            empName = name;
            empId = Id;
        }
    }
}
