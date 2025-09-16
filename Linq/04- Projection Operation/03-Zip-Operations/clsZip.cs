using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _04__Projection_Operation._03_Zip_Operations
{
    internal class clsZip
    {


        private static void example01()
        {
            string[] colorName = { "Red", "Green", "Blue", "extra" };
            string[] colorHEX = { "FF0000", "00FF00", "0000FF", };


            var pairs = colorName.Zip(colorHEX, (name, hex) => $"{name} => {hex}");

            foreach (var c in pairs)
                Console.WriteLine(c);

        }

        private static void RunExample02()
        {
            var employees = new List<Employee>
            {
                new Employee { FullName = "Alice Johnson" },
                new Employee { FullName = "Bob Smith" },
                new Employee { FullName = "Charlie Brown" },
                new Employee { FullName = "Diana Prince" },
                new Employee { FullName = "Ethan Hunt" },
                new Employee { FullName = "Fiona Gallagher" }
            }.ToArray();

            // Take first 3 and last 3 employees
            var firstThree = employees[..3];
            var lastThree = employees[^3..];

            // Method syntax with Zip
            var teams = firstThree.Zip(lastThree,
                (first, last) => $"{first.FullName} with {last.FullName}");

            // Query syntax with Zip (using deconstruction)
            var teamsQuery =
                from pair in firstThree.Zip(lastThree)
                select $"{pair.First.FullName} with {pair.Second.FullName}";

            // Print results
            Console.WriteLine("=== Teams (Method Syntax) ===");
            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("\n=== Teams (Query Syntax) ===");
            foreach (var team in teamsQuery)
            {
                Console.WriteLine(team);
            }
        }

        public static void ZipExample()
        {

            //example01();

            RunExample02();
        }



    }

    class Employee
    {
        public string FullName { get; set; }
    }
}
