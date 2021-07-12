using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize objOne
            Number objOne = new Number();
            // Call MethodOne from objOne passing in a int type parameter of 1
            Console.WriteLine("MethodOne Results: {0}", objOne.MethodOne(1));

            // Initialize objTwo
            Number objTwo = new Number();
            // Call MethodTwo from objTwo passing in a double type parameter of 3.5
            Console.WriteLine("MethodTwo Results: {0}", objTwo.MethodTwo(3.5));

            // Initialize objThree
            Number objThree = new Number();
            // Call MethodThree from objThree passing in a string type parameter of 2
            // Add a try catch to make sure the parameter can be converted to a integer.
            try
            {
                Console.WriteLine("MethodThree Results: {0}", objThree.MethodThree("2"));
            }
            catch (FormatException)
            {

                Console.WriteLine("Cannot product results for MethodThree, cannot convert string to int");
            }
            Console.ReadLine();
        }
    }
}
