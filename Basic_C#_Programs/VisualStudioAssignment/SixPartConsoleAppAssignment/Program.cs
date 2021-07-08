using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartConsoleAppAssignment
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Initialize a one dimensional array of strings
            string[] array = { "Ariel", "Jack", "Daniel", "Carter" };
            // Ask the user to input a text
            Console.WriteLine("Please input some text: ");
            // Store user input in userInput variable
            string userInput = Console.ReadLine();
            // Iterate through each item in array and concat each value with userInput
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += userInput;
            }
            // Iterate through each item in array and print off each string
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
