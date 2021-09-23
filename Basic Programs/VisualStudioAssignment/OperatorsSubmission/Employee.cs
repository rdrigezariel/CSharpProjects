using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    public class Employee
    {
        // Id prop
        public int Id { get; set; }

        // Equal operator
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            if (employeeOne.Id == employeeTwo.Id)
            {
                return true;
            }
            return false;
        }

        // Not equal operator
        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            if (employeeOne.Id == employeeTwo.Id)
            {
                return false;
            }
            return true;
        }
    }
}
