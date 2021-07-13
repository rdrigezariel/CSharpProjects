using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismSubmission
{
    // Employee class inherits the Person calss
    public class Employee : Person, IQuittable
    {
        // Implement SayName method
        public void SayName()
        {
            // Print out full name to user
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
