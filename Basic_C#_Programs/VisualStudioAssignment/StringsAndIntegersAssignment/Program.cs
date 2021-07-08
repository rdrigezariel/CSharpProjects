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
            // Take in the users input and converts it to a int type.
            int input = Convert.ToInt32(Console.ReadLine());

            // Iterate through each number in myList to divide by the users input.
            foreach (int number in myList)
            {
                int result = number / input;
                Console.WriteLine("Dividing " + number + " by " + input + ". The result is: " + result + ".");
            }
        }
        // This catch will look out for a zero input by the user (i.e. we cannot divide by zero).
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error, cannot divide by zero.");
        }
        // This catch will look out for data type errors
        catch (FormatException)
        {
            Console.WriteLine("Error, that is not a number!");
        }
        // Pause the program for the user to see results (i.e. we can only divide by number).
        Console.ReadLine();
        
    }
}
