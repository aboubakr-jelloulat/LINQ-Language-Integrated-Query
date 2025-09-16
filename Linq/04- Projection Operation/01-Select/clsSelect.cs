using System;
using System.Collections.Generic;
using System.Linq;

namespace _04__Projection_Operation._01_Select
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Skills { get; set; }
    }

    // DTO (Data Transfer Object) with fewer details
    class EmployeeDto
    {
        public string Name { get; set; }
        public int TotalSkills { get; set; }

        public override string ToString()
        {
            return $"{Name} ({TotalSkills} skills)";
        }
    }



    internal class clsSelect
    {
        // projection → you take objects and project (transform) them into a new shape.
        public static void RunSelectExample()
        {
            //RunExample01();
            //RunExample02();
            RunExample03();

            Console.ReadKey();
        }

        private static void RunExample01()
        {
            var words = new List<string> { "hej !", "im a software", "engineer" };

            // Method syntax
            var result = words.Select(x => x.ToUpper());

            // Query syntax
            var result02 = from item in words
                           select item.ToUpper();

            foreach (var item in result02)
            {
                Console.WriteLine(item);
            }
        }

        private static void RunExample02()
        {
            var numbers = new List<int> { 2, 3, 6, 7, 8 };

            // Method syntax → projection to bool
            var result = numbers.Select(x => x % 2 == 0);

            // Query syntax → projection to doubled numbers
            var result02 = from nb in numbers
                           select nb * 2;

            foreach (var n in result02)
            {
                Console.WriteLine(n);
            }
        }

        private static void RunExample03()
        {
            // Create a sample list of employees
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Alice", LastName = "Johnson", Skills = new List<string>{ "C#", "SQL" } },
                new Employee { FirstName = "Bob", LastName = "Smith", Skills = new List<string>{ "Java", "Python", "Docker" } },
                new Employee { FirstName = "Charlie", LastName = "Brown", Skills = new List<string>{ "JavaScript" } }
            };

            // Projection: Employee → EmployeeDto
            var result = employees.Select(e => new EmployeeDto
            {
                Name = $"{e.FirstName} {e.LastName}",
                TotalSkills = e.Skills.Count
            });

            // Print results
            foreach (var dto in result)
            {
                Console.WriteLine($"{dto.Name} - Skills: {dto.TotalSkills}");
            }
        }
    }
}
