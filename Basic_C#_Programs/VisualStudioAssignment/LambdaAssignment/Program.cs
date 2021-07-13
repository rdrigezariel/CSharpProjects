using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize an employee list with 10 employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Rodriguez" },
                new Employee { Id = 2, FirstName = "Joe", LastName = "Alvarez" },
                new Employee { Id = 3, FirstName = "Jesse", LastName = "James" },
                new Employee { Id = 4, FirstName = "Jessica", LastName = "Rodriguez" },
                new Employee { Id = 5, FirstName = "Ariel", LastName = "Rodriguez" },
                new Employee { Id = 6, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 7, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 8, FirstName = "Jimmy", LastName = "Hendrix" },
                new Employee { Id = 9, FirstName = "Bob", LastName = "Williams" },
                new Employee { Id = 10, FirstName = "Katt", LastName = "Rogers" }
            };

            // Initialize a empty employee list
            List<Employee> employeesNamedJoe = new List<Employee>();

            // This loop will add any employees with a first name of "Joe" to employeesNamedJoe variable
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }

            // Initialize a list with employees with a id greater than 5
            List<Employee> employeesWithIdGreaterThanFive = employees.Where(x => x.Id > 5).ToList() ;

            // Pause program
            Console.ReadLine();
        }
    }
}
