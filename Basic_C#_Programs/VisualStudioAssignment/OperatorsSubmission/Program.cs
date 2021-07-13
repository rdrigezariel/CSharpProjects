using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize employeeOne and employeeTwo
            Employee employeeOne = new Employee();
            Employee employeeTwo = new Employee();

            // Set Id values for each employee
            employeeOne.Id = 1;
            employeeTwo.Id = 2;

            // Print equal operator results
            Console.WriteLine(employeeOne == employeeTwo);

            // Pause program
            Console.ReadLine();
        }
    }
}
