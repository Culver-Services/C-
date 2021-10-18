using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employeeTwo = new Employee();
            employeeTwo.Quit();
            Console.ReadLine();
        }
    }
}
