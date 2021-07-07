using System;
using System.Globalization;

namespace BranchingSubmissionAssignment
{
    static class Program
    {
        static void Main()
        {
            // Greet the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            // Prompt user for the package weight
            Console.WriteLine("Please provide the weight of the package: ");
            string weightInput = Console.ReadLine();

            // Convert user string input to int
            int weight = Convert.ToInt32(weightInput);

            // Check if weight is greater than 50
            // If so, display an error
            // Else, continue
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Prompt user for the package width
                Console.WriteLine("Please provide the width of the package: ");
                string widthInput = Console.ReadLine();
                Console.WriteLine("Please provide the height of the package: ");
                string heightInput = Console.ReadLine();
                Console.WriteLine("Please provide the length of the package: ");
                string lengthInput = Console.ReadLine();

                // Convert user string inputs to int
                int width = Convert.ToInt32(widthInput);
                int height = Convert.ToInt32(heightInput);
                int length = Convert.ToInt32(lengthInput);
                int sum = width + height + length;

                // Check if dimensions tal greater than 50
                // If so, display an error
                // Else, continue
                if (sum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                } 
                else
                {
                    double quote = ((width * height * length) * weight) / 100.00;
                    Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C", CultureInfo.CurrentCulture));
                    Console.WriteLine("Thank you!");
                }

            }
        }
    }
}
