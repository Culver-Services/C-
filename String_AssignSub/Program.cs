using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_AssignSub
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Chadwick";
            string hobby = "coding";
            string location = "home";

            Console.WriteLine(name + " likes to do " + hobby + " from " + location + "!");

            Console.WriteLine(name.ToUpper());

            StringBuilder sb = new StringBuilder();

            sb.Append("This is a paragraph of text.");
            sb.Append("\nIt is made one sentence at a time.");
            sb.Append("\nI am not sure what it's about.");
            sb.Append("\nRegardless, here it is!");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
