using System;

namespace ConsoleApplicationAssignment
{
    static class Program
    {
        static void Main()
        {
            // #1
            Console.WriteLine("#1- Please enter a number:");
            string inputOne = Console.ReadLine();
            long resultsOne = 50 * long.Parse(inputOne);
            Console.WriteLine("Results for #1 (multiply by 50): " + resultsOne);

            // #2
            Console.WriteLine("\n#2- Please enter a number:");
            string inputTwo = Console.ReadLine();
            int resultsTwo = 25 + Convert.ToInt32(inputTwo);
            Console.WriteLine("Results for #2 (add 25): " + resultsTwo);

            // #3
            Console.WriteLine("\n#3- Please enter a number:");
            string inputThree = Console.ReadLine();
            double resultsThree = Convert.ToDouble(inputThree) / 12.5;
            Console.WriteLine("Results for #3 (divide by 12.5): " + resultsThree);

            // #4
            Console.WriteLine("\n#4- Please enter a number:");
            string inputFour = Console.ReadLine();
            bool resultsFour = Convert.ToInt32(inputFour) > 50;
            Console.WriteLine("Results for #4 (if input greater than 50): " + resultsFour);

            // #5
            Console.WriteLine("\n#5- Please enter a number:");
            string inputFive = Console.ReadLine();
            int resultsFive = Convert.ToInt32(inputFive) % 7;
            Console.WriteLine("Results for #5 (remainder after dividing by 7): " + resultsFive);
        }
    }
}
