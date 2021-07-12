using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Number
    {
        // MethodOne will return a input of type int plus 2 as an integer.
        public int MethodOne(int input) => input + 2;
        // MethodTwo will return a input of type decimal minus 2 as an integer.
        public int MethodTwo(double input) => (int)(input - 2);
        // MethodThree will convert the string type input as an integer then return input plus 1 as an integer.
        public int MethodThree(string input) => Convert.ToInt32(input) + 2;
    }
}
