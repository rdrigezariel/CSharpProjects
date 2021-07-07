using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            // First exercise (addition)
            Console.WriteLine("Addition");
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);

            // Second exercise (subtraction)
            Console.WriteLine("\nSubtraction");
            int difference = 10 - 5;
            Console.WriteLine(difference.ToString());

            // Third exercise (multiplication)
            Console.WriteLine("\nMultiplication");
            int product = 10 * 5;
            Console.WriteLine(product);

            // Fourth exercise (division)
            Console.WriteLine("\nDivision");
            double quotient = 100.0 / 17.0;
            Console.WriteLine(quotient);

            // Fifth exercise (remainder)
            Console.WriteLine("\nRemainder");
            int remainder = 10 % 3;
            Console.WriteLine(remainder);

            // 6th exercise (boolean)
            Console.WriteLine("\nBoolean");
            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse);

            int roomTemperature = 70;
            int currentTemperature = 72;
            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);

            

        }
    }
}
