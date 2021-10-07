using System;

namespace Price_Quote_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                else
                {
                    int quote = weight * width * height * length / 100;
                    decimal shipping = quote;

                    Console.WriteLine("Your estimate total for shipping this package is: " + shipping.ToString("C"));
                    Console.WriteLine("Thank you");
                    Console.ReadLine();
                }
            }
        }
    }
}
