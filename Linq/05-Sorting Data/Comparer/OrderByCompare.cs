using _05_Sorting_Data.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Sorting_Data.Comparer
{
    internal class OrderByCompare
    {

        public static   void TestOrderByCompare()
        {
            IEnumerable<Employee> emps = Repository.LoadEmployees();
            //IOrderedEnumerable<Employee> sortedEmps = 
            //    emps.OrderBy(e => e.EmployeeNo);

            IOrderedEnumerable<Employee> sortedEmps =
             emps.OrderBy(e => e, new EmployeeComparer());

            sortedEmps.Print("sorted employees");

        }

        public static void ReverseOperation()
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };

            var reveredOrder = fruits.Reverse();

            // fruits.Reverse(); // do nothing
            reveredOrder.Print("Employees in reverse order");

        }


    }
}
