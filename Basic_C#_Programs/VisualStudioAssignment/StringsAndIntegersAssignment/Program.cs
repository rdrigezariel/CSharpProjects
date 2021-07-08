using System;
using System.Collections.Generic;

static class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> myList = new List<int>(new int[] { 1, 2, 3, 4, 5 });

        try
        {
            // Ask user for a number to divide each number in myList.
            Console.WriteLine("Please enter a number to divide each number in my list by: ");
            int input = Convert.ToInt32(Console.ReadLine());

            foreach (int number in myList)
            {
                int result = number / input;
                Console.WriteLine("Dividing " + number + " by " + input + ". The result is: " + result + ".");
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error, cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error, that is not a number!");
        }
    }
}
