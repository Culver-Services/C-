using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClasses
{
    public class Employee : Person
    {
        public override string SayName()
        {
            Console.WriteLine("Employee");
            return base.SayName();
        }
    }
}
