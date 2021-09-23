using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get current year in int type
            int currentYear = Convert.ToInt32(DateTime.Today.ToString("yyyy"));
            Console.WriteLine("Enter your age");

            try
            {
                // Get users born year
                var yearBorn = Convert.ToInt32(DateTime.Today.ToString(Console.ReadLine()));
                // Determine users age
                int usersAge = currentYear - yearBorn;

                Console.WriteLine("You were born in the year {0}.", usersAge);
            }
            catch (Exception)
            {
                // User didn't enter a pure int type
                Console.WriteLine("Please contact an Admin Administrator for assistance.");
            }
            // Pause program
            Console.ReadLine();
        }
    }
}
