using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    public class Employee : Person, IQuittable
    {
        public override string SayName()
        {
            Console.WriteLine("Employee");
            return base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("I Quit!");
        }
    }
}
