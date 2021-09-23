using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize obj
            Calculate obj = new Calculate();

            // Ask the user for inputOne
            Console.WriteLine("Please enter a number: ");
            // Convert the string type input into a integer
            int inputOne = Convert.ToInt32(Console.ReadLine());
            // Ask the user for inputTwo
            Console.WriteLine("Please enter another number (optional): ");
            string inputTwo = Console.ReadLine();

            // Check if inputTwo is blank
            // If so, only provide inputOne to obj.Add()
            // Else, provide inputOne and inputTwo to obj.Add()
            if (inputTwo == "")
            {
                Console.WriteLine("Result: {0}", obj.Add(inputOne));
            }
            else
            {
                Console.WriteLine("Result: {0}", obj.Add(inputOne, Convert.ToInt32(inputTwo)));
            }
            // Stop program here to have user see results.
            Console.ReadLine();
        }
    }
}
