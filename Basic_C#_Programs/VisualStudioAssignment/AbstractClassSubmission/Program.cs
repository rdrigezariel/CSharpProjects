using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize employee
            Employee employee = new Employee();
            // Assign name to firstName prop
            employee.firstName = "Sample";
            // Assign name to lastName prop
            employee.lastName = "Student";
            // Call SayName method from Employee class
            employee.SayName();
            // Pause Program
            Console.ReadLine();
        }
    }
}
