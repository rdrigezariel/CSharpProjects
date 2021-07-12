using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsConsoleApp
{
    class Calculate
    {
        public int Input { get; set; }

        public int AddTwo(int input)
        {
            // Adding two to users input
            return input + 2;
        }

        public int MinusTwo(int input)
        {
            // Subtracting two from users input
            return input - 2;
        }

        public int TimesTwo(int input)
        {
            // Multiplying users input by 2
            return input * 2;
        }
    }
}
