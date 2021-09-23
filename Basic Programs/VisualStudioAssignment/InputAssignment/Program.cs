using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a number
            Console.WriteLine("Please enter a number:");
            // Store users input in 'input' variable
            string input = Console.ReadLine();
            // Generate text file in specified directory with the users input written in the file
            File.WriteAllText(@"C:\Users\Ariel\Desktop\Log3.txt", input);
        }
    }
}
