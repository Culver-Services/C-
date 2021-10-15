using System;
using System.Collections.Generic;


namespace MethodConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter a Number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int b = 81;
            int Total;
            MathFunction functionOne = new MathFunction();

            Total = functionOne.addition(x, b);
            Console.WriteLine("The sum of " + x + " plus " + b + " equals:" + Total);
            Total = functionOne.subtract(x, b);
            Console.WriteLine("The sum of " + x + " minus " + b + " equals:" + Total);
            Total = functionOne.multiply(x, b);
            Console.WriteLine("The sum of " + x + " multiplied by " + b + " equals:" + Total);
            Console.ReadLine();
        }
    }
}
