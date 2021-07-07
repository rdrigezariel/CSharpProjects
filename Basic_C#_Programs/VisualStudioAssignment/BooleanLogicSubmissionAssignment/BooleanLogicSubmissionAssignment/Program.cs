using System;

namespace BooleanLogicSubmissionAssignment
{
    static class Program
    {
        static void Main()
        {
            // Welcome message
            Console.WriteLine("Welcome to the Insurance Approval Console Application!\n");


            // Required questions for applicant
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string DUIInput = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine();

            // Convert inputs to appropriate data type
            int age = Convert.ToInt32(ageInput);
            bool DUI = Convert.ToBoolean(DUIInput);
            int tickets = Convert.ToInt32(ticketsInput);

            // Calculate results
            bool results = (age > 15 && !DUI && tickets <= 3);

            // Display results
            Console.WriteLine("Qualified? " + results);
        }
    }
}
