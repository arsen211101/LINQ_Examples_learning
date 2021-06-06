using System;
using System.Collections.Generic;
using System.Linq;

namespace _011_LINQ
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee{LastName="Ivanov",FirstName="Ivan"},
                new Employee{LastName="Andreev",FirstName="Andrey"},
                new Employee{LastName="Petrov",FirstName="Petr"}
            };

            var query = from emp in employees
                        let fullName = emp.FirstName + " " + emp.LastName
                        orderby fullName descending
                        select fullName;

            foreach (var person in query)
            {
                Console.WriteLine(person);
            }
        }
    }
}
