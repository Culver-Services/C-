using System;
using System.Collections.Generic;

namespace ExceptionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 45, 86, 95, 34, 12, 76, 81 };
                string write;
                int number;

                Console.WriteLine("This is the list of numbers.");
                numbers.ForEach(Console.WriteLine);
                Console.WriteLine("Please select a number to divide the items in the list by.");
                int divider = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the list by " + divider);


                for (int x = 0; x < numbers.Count; x++)
                {
                    number = numbers[x];
                    write = Convert.ToString(number / divider);
                    Console.WriteLine(numbers[x] + " divided by " + divider + " equals " + write);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not enter 0. (You cannot divide by zero)");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            Console.WriteLine("The program has finished the try/catch.");
            Console.ReadLine();
        }


        // dividebyzeroexception when dividing by zero
        // formatException when using a string
    }
}
}
