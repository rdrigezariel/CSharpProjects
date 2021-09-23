using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize obj
            IQuittable obj = new Employee();
            // Call the Quit method
            obj.Quit();
            // Pause Program
            Console.ReadLine();
        }
    }
}
