using System;

namespace Daily_Report_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College\r\nStudent Daily Report");
            Console.WriteLine("\r\nWhat course are you in?");
            string studCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pgNumber = Console.ReadLine();
            byte pgNumberByte = Convert.ToByte(pgNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            bool needHelpBool = Convert.ToBoolean(needHelp);


            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            decimal hoursStudiedDec = Convert.ToDecimal(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();

            //Chadwick.Culver

        }
    }
}
