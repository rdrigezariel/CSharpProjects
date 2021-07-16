using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const int level = 5;
            // Create a variable using var
            var name = "Ariel";

            // The rest is to test constructors :)
            var player = new Player(name);
            if (player.Level > 1)
            {
                Console.WriteLine("Welcome back, {0}!", player.Name);
            }
            else
            {
                Console.WriteLine("Welcome, {0}!", player.Name);
            }
            // Pause program
            Console.ReadLine();
        }
    }
}
