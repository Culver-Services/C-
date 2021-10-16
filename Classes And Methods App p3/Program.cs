using System;
using System.Collections.Generic;

namespace Classes_And_Methods_App_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 3;
            MathFunction function = new MathFunction();

            function.functionOne(num1, num2);

            function.functionOne(int1: num1, int2: num2);

            Console.ReadLine();
        }
    }
}
