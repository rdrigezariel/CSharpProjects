using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize obj
            Employee obj = new Employee();
            // Assign a first name to obj.FirstName prop
            obj.FirstName = "Sample";
            // Assign a last name to obj.LastName prop
            obj.LastName = "Student";
            // Call superclass method SayName()
            obj.SayName();
            // Pause program
            Console.ReadLine();
        }
    }
}
