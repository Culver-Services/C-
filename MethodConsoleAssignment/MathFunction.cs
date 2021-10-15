using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConsoleAssignment
{
    public class MathFunction
    {
        public int addition(int num1, int num2)
        {
            var Total = num1 + num2;
            return Total;
        }
        public int multiply(int num1, int num2)
        {
            var Total = num1 * num2;
            return Total;
        }
        public int subtract(int num1, int num2)
        {
            var Total = num1 - num2;
            return Total;
        }
    }
}
