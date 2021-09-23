using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    public struct Number
    {
        public Decimal Amount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize test variable
            Number test;
            // Assign an amount
            test.Amount = (decimal)200.5;
            // Display results to user
            Console.WriteLine(test.Amount);
            // Pause program
            Console.ReadLine();
        }
    }
}
