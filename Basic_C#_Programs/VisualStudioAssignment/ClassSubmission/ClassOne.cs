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
        public void MethodOne(int input)
        {
            Console.WriteLine("{0} divided by 2 equals: {1}", input, (input / 2));
        }
        // Overloaded MethodOne
        // This overloaded method takes in a string parameter
        public void MethodOne(string input)
        {
            try
            {
                int userInput = Convert.ToInt32(input);
                Console.WriteLine("{0} divided by 2 equals: {1}", userInput, (userInput / 2));

            }
            catch (FormatException)
            {

                Console.WriteLine("Error: please enter a valid number");
            }
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
