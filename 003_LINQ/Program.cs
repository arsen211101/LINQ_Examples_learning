using System;
using System.Collections.Generic;
using System.Linq;

namespace _002_LINQ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName="Ivan",
                    LastName="Ivanov",
                    Salary=94000,
                    StartDate=DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    FirstName="Petr",
                    LastName="Petrov",
                    Salary=123000,
                    StartDate=DateTime.Parse("12/3/1995")
                },
                new Employee
                {
                    FirstName="Andrew",
                    LastName="Andreev",
                    Salary=1000000,
                    StartDate=DateTime.Parse("1/12/2005")
                }
            };

            var query =
                Enumerable.Select(
                Enumerable.OrderBy(
                Enumerable.OrderBy(
                Enumerable.Where(
                employees, emp => emp.Salary > 100000),
                emp => emp.LastName),
                emp => emp.FirstName),
                emp => new { LastName = emp.LastName, FirstName = emp.FirstName });

            Console.WriteLine("Bardzr vardzatrvox ashxatoxner:");
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }
        }
    }
}
