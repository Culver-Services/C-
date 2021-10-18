using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee() { firstName = "Sample", lastName = "Student" };
            employeeOne.SayName();
            Console.ReadLine();
        }
    }
}
