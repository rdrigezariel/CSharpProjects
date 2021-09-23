using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize obj
            Calculate obj = new Calculate();

            // Calling the OddMethod, passing in 1 and 2
            obj.OddMethod(1, 2);
            // Calling the OddMethod, passing in 1 and 3 but specifying the params by name
            obj.OddMethod(one: 1, two: 3);
            Console.ReadLine();
        }
    }
}
