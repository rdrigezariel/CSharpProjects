using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmission
{
    class Person
    {
        // FirstName & LastName props
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // SayName Method
        public void SayName()
        {
            // Display the first and last name assigned
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
