using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize obj
            ClassOne obj = new ClassOne();
            // Prompt the user to enter a number
            Console.WriteLine("Enter a number: ");
            try
            {
                // Convert the users string input into a int
                int input = Convert.ToInt32(Console.ReadLine());
                // Call MethodOne
                obj.MethodOne(input);
            }
            catch (FormatException)
            {
                // This catch will look for format errors,
                // incase the user does not enter a integer.
                Console.WriteLine("Error, please enter a number.");
            }
            Console.ReadLine();
        }
    }
}
