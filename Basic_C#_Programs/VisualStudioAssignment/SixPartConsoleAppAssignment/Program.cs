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
            // ** Part One **

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

            // ** Part Two **
            int count = 0;
            while (true)
            {
                Console.WriteLine("Count = " + count);
                count++;

                // ** Part Three **
                if (count < 10)
                {
                    continue;
                }
                if (9 <= count)
                {
                    break;
                }
            }

            // ** Part Four **
            List<string> mylist = new List<string>(new string[] { "Ariel", "Bob", "Dylan", "Jack", "Mary" });
            Console.WriteLine("Please enter a text to search for in the list: ");
            string input = Console.ReadLine();

            for (int i = 0; i < mylist.Count; i++)
            {
                if (mylist[i] == input)
                {
                    Console.WriteLine("The index of the list that contains the input you entered is " + i + ".");
                    break;
                }
                else if (i+1 == mylist.Count)
                {
                    Console.WriteLine("Your input was not found on the list.");
                }
            }

            // ** Part Five **
            List<string> partFiveList = new List<string>(new string[] { "Ariel", "Bob", "Dylan", "Jack", "Mary", "Ariel" });
            Console.WriteLine("Please enter a text to search for in the list: ");
            string inputFive = Console.ReadLine();

            for (int i = 0; i < partFiveList.Count; i++)
            {
                if (partFiveList[i].Contains(inputFive))
                {
                    Console.WriteLine("The index of the list that contains the text you entered is " + i + ".");
                }
                else if (i + 1 == partFiveList.Count)
                {
                    Console.WriteLine("Your input was not found on the list.");
                }
            }

            // ** Part Six **
            List<string> partSixList = new List<string>(new string[] { "Ariel", "Bob", "Dylan", "Jack", "Mary", "Ariel" });
            List<string> partSixListTwo = new List<string>();
            foreach (string item in partSixList)
            {

                if (partSixListTwo.Count == 0)
                {
                    Console.WriteLine(item + " has NOT already appeared in the list.");
                    partSixListTwo.Add(item);
                } else
                {
                    for (int i = 0; i < partSixListTwo.Count; i++)
                    {
                        if (partSixListTwo[i] == item)
                        {
                            Console.WriteLine(item + " has already appeared in the list.");
                            break;
                        }
                        if (i + 1 == partSixListTwo.Count)
                        {
                            Console.WriteLine(item + " has NOT already appeared in the list.");
                            partSixListTwo.Add(item);
                            break;
                        }
                    }
                }
            }
        }
    }
}
