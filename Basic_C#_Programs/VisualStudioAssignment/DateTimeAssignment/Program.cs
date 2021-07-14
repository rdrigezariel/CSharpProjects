using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display current date and time
            Console.WriteLine(DateTime.Now);
            // Prompt the user for a number
            Console.WriteLine("Please enter a number:");
            // Store the users input in the 'input' variable
            int input = Convert.ToInt32(Console.ReadLine());
            // Display to user the time it will in {input} hours
            Console.WriteLine(DateTime.Now.AddHours(input));
            // Pause program
            Console.ReadLine();
        }
    }
}
