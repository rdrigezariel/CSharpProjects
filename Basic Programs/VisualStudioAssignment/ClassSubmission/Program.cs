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
                string input = Console.ReadLine();
                int convInput = Convert.ToInt32(input);
                // Call MethodOne
                obj.MethodOne(convInput);
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
