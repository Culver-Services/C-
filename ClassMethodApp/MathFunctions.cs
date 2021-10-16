using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodApp
{
    class MathFunctions
    {
        public void divided(in int int1, out int answer)
        {
            answer = int1 / 2;
        }
        public void numbers(out int num1, out int num2)
        {
            num1 = 1;
            num2 = 2;
        }
        public void numbers(int num1, int num2, out int num3)
        {
            num3 = num1 + num2;
        }
    }
}
