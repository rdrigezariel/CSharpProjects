using System;

namespace MathComparisonOperatorAssignment
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Person 1 inputs
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            string personOneHourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week: ");
            string personOneHoursWorked = Console.ReadLine();

            // Person 2 inputs
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Rate: ");
            string personTwoHourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week: ");
            string personTwoHoursWorked = Console.ReadLine();

            // Display annual salary of Person 1
            int personOneAnnualSalary = (Convert.ToInt32(personOneHourlyRate) * Convert.ToInt32(personOneHoursWorked)) * 52;
            Console.WriteLine("\nAnnual Salary of Person 1: " + "$" + String.Format("{0:n0}", personOneAnnualSalary));

            // Display annual salary of Person 2
            int personTwoAnnualSalary = (Convert.ToInt32(personTwoHourlyRate) * Convert.ToInt32(personTwoHoursWorked)) * 52;
            Console.WriteLine("Annual Salary of Person 2: " + "$" + String.Format("{0:n0}", personTwoAnnualSalary));
        }
    }
}
