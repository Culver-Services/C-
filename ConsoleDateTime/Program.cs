using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;
            Console.WriteLine(time);
            Console.WriteLine("Please enter a number:");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime newTime = time.AddHours(hours);
            Console.WriteLine("In " + hours + " hours, it will be " + newTime);
            Console.ReadLine();
        }
    }
}
