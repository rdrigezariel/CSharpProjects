using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsoleAppAssignment
{
    static class Program
    {
        static void Main()
        {
            string[] stringArray = { "Ariel", "Bob", "Dylan", "Jack", "Mary" };
            int[] intArray = { 1, 0, 999, 777, 44 };
            List<string> mylist = new List<string>(new string[] { "Ariel", "Bob", "Dylan", "Jack", "Mary" });

            // #1 - Ask the user to select an index of the stringArray array
            Console.WriteLine("Please select a number (0 through 4) to display a string from the array: ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            // Check if index exist
            // if not, let user know
            if (stringIndex < 5 || stringIndex > -1)
            {
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Sorry, this index does not exist in the array.");
            }

            // #2 - Ask the user to select an index of the intArray array
            Console.WriteLine("\nPlease select a number (0 through 4) to display a integer from the array: ");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            // Check if index exist
            // if not, let user know
            if (intIndex < 5 || intIndex > -1)
            {
                Console.WriteLine("You selected: " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Sorry, this index does not exist in the array.");
            }

            // #3 - Ask the user to select an index of the myList list
            Console.WriteLine("\nPlease select a number to display a string from the list: ");
            int stringListIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected: " + mylist[stringListIndex]);
        }
    }
}
