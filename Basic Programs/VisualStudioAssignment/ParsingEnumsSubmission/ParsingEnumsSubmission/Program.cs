using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            try
            {
                // Convert the users input to DaysOfWeek type
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
                Console.WriteLine("Thank you");
            }
            catch (Exception)
            {
                // Throw exception message to the user if they do not enter an actual day of the week.
                Console.WriteLine("Please enter an actual day of the week.");
            }
            // Pause the program
            Console.ReadLine();
        }

        // Define our DaysOfWeek enum
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
