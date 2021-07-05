using System;

namespace DailyReportSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            // Program intro
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("The Student Daily Report.\n");

            // This set of code displays a message with the daily report questions.
            // It also has variables to store the users reponse accordingly.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? (Please answer \"true\" or \"false\".)");
            string helpNeeded = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string sharedExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please give specifics.");
            string sharedFeeback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursWorked = Console.ReadLine();

            // This line displays a message, thanking the user for submitting a daily report.
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!") ;
        }
    }
}
