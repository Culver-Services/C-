using System;
using System.Collections.Generic;


namespace Classes_and_Methods_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            int Total;
            MathFunction functionOne = new MathFunction();

            Total = functionOne.mathOne(z);

            Console.WriteLine("Multiply 7 * 1");
            Console.WriteLine(Total);

            decimal q = 81.81m;
            int answer;
            MathFunction functionTwo = new MathFunction();
            answer = functionTwo.mathOne(q);

            Console.WriteLine("Divide 81.81 by 3.06");
            Console.WriteLine(answer);


            string x;
            int conclusion;
            MathFunction functionThree = new MathFunction();
            Console.WriteLine("Enter a number for the final Method:");
            x = (Console.ReadLine());
            Console.WriteLine(x + " minus 23 equals:");
            conclusion = functionThree.mathOne(x);

            Console.WriteLine(conclusion);



            Console.ReadLine();
        }
    }
}
