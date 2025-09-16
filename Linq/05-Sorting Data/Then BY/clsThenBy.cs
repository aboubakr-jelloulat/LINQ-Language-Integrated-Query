using _05_Sorting_Data.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Sorting_Data.Then_BY
{
    internal class clsThenBy
    {


        public static void TestThenBy()
        {
            var emps = Repository.LoadEmployees();


            var sortedEmps01 = emps.OrderBy(x => x.Name).ThenBy(x => x.Salary);
            sortedEmps01.Print("Soretd empls then by ");


            var sortedEmps02 = emps.OrderByDescending(x => x.Name).ThenBy(p => p.Salary);
            sortedEmps02.Print("Soretd empls then by ");


        }

    }
}
