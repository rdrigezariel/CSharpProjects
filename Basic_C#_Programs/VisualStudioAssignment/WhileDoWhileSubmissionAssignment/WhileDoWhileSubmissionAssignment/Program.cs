using System;

namespace WhileDoWhileSubmissionAssignment
{
    static class Program
    {
        static void Main()
        {
            // #1
            Console.WriteLine("#1 -");
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("\"i\" is less than 3. i = " + i + ".");
                i++;
            }

            Console.WriteLine("\n");

            // #2
            Console.WriteLine("#2 -");
            int j = 0;
            do
            {
                Console.WriteLine("\"j\" is less than 5. i = " + j + ".");
                j++;
            }
            while (j < 5);
        }
    }
}
