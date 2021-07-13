using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize testOne (string type)
            Employee<string> testOne = new Employee<string>();
            testOne.Things = new List<string>() { "thingOne", "thingTwo", "thingThree" };
            // Initialize testTwo (int type)
            Employee<int> testTwo = new Employee<int>();
            testTwo.Things = new List<int>() { 1, 2, 3, 4, 5 };

            // Loop that prints out all things in testOne
            foreach (string thing in testOne.Things)
            {
                Console.WriteLine(thing);
            }

            // Loop that prints out all things in testTwo
            foreach (int thing in testTwo.Things)
            {
                Console.WriteLine(thing);
            }

            // Pause program for user
            Console.ReadLine();

        }
    }
}
