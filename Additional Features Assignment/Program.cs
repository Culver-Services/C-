using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string businessName = "Culver.co";
            var greeting = "Welcome to " + businessName;
            Console.WriteLine(greeting);
            Employee chadwick = new Employee("Chadwick");
            Console.WriteLine("{0}, You are employee number:{1}", chadwick.empName, chadwick.empId);
            Console.ReadLine();
        }
    }
}
