using System;
using System.Collections.Generic;
using System.Text;

namespace _04__Projection_Operation.Select_Many
{
    internal class clsSelectMany
    {


        private static void example01()
        {

            string[] sentences =
            {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
            };

            var result = sentences.SelectMany(x => x.Split(' '));

            foreach (var item in result)
                Console.WriteLine(item);

        }


        private static void example02()
        {
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Alice", Skills = new List<string>{ "C#", "SQL", "C#"} },
                new Employee { FirstName = "Bob", Skills = new List<string>{ "Java", "Docker" , "Docker" } },
                new Employee { FirstName = "Charlie", Skills = new List<string>{ "Python", "C#" } }
            };



            var skillLists = employees.SelectMany(e => e.Skills).Distinct();


            var result = (from Employee in employees
                         from skill in Employee.Skills
                         select skill).Distinct();


            foreach (var list in result)
            {
                Console.WriteLine($"[{string.Join(", ", list)}]");
            }


        }


        public static void SelectManyExamples()
        {

            //example01();

            example02();

        }



    }

    class Employee
    {
        public string FirstName { get; set; }
        public List<string> Skills { get; set; }
    }
}

