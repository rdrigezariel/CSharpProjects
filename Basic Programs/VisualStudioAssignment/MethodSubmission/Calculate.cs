using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Calculate
    {
        // Add method will return one plus two,
        // If the two parameter is not provided, it will return one plus 1.
        public int Add(int one, int two = 1)
        {
            return one + two;
        }
    }
}
