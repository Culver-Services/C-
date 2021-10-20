using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int age = int.Parse(Console.ReadLine());
                if (age < 1)
                {
                    throw new FraudException();
                }
                var today = DateTime.Now;

                var year1 = today.Year - 1 - age;
                var year2 = today.Year - age;

                Console.WriteLine("If you have already had your birthday, you were born in {0} otherwise you were born in {1}.", year2, year1);
                Console.ReadLine();
            }
            catch (FraudException)
            {
                Console.WriteLine("You entered 0 or a negative number for your age. Please enter a number greater than 0.");
                Console.ReadLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("The system has encountered an error. Please see your administrator");
                Console.ReadLine();
                return;
            }
        }
    }
}
