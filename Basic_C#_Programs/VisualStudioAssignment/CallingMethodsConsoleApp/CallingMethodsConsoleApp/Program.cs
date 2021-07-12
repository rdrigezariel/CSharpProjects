using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsConsoleApp
{
    static class Program
    {
        static void Main()
        {
            // Initialize the input object
            Calculate input = new Calculate();

            // Ask the user for an input
            Console.WriteLine("Enter a number: ");

            // Record the users input
            input.Input = Convert.ToInt32(Console.ReadLine());

            // Display results of each method to the user
            Console.WriteLine("Calling the \"AddTwo\" method returns: " + AddTwo(input.Input));
            Console.WriteLine("Calling the \"MinusTwo\" method returns: " + MinusTwo(input.Input));
            Console.WriteLine("Calling the \"TimesTwo\" method returns: " + TimesTwo(input.Input));
            Console.ReadLine();
        }

        public static int AddTwo(int input)
        {
            // Adding two to users input
            return input + 2;
        }

        public static int MinusTwo(int input)
        {
            // Subtracting two from users input
            return input - 2;
        }

        public static int TimesTwo(int input)
        {
            // Multiplying users input by 2
            return input * 2;
        }
    }
}
