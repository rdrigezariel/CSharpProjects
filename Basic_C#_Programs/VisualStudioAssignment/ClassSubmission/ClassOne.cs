using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class ClassOne
    {
        // Created a void methid that outputs an int.
        // The method divides the input by 2.
        // The method also contains a overload.
        public void MethodOne(int input, int overload = 1)
        {
            Console.WriteLine("{0} divided by 2 equals: {1}", input, (input / 2));
            Console.WriteLine("Overload value: {0}", overload);
        }

        // Created a method with output parameters
        public void MethodOutputParams(out int input)
        {
            input = 2;
        }
    }

    // Declare static class ClassTwo
    static class ClassTwo
    {
    }
}
