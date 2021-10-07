using System;

namespace Bool_while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isguessed = number == 9;

            do
            {
                switch (number)
                {
                    case 9:
                        Console.WriteLine("You guessed the number 9. That is correct!");
                        isguessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong!");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isguessed);
            Console.Read();

            // do while above. while below.

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.ReadLine();
        }
    }
}
