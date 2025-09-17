using _06_Data_Partitioning.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Data_Partitioning._01_Skip
{
    internal class Skip
    {

        public static void SkipMethods()
        {

            var emps = Repository.LoadEmployees();


            var q1 = emps.Skip(10);
            q1.Print("Skip First 10 employees : ");


            // It skips elements in a sequence as long as a condition is true.

            var q2 = emps.SkipWhile(x => x.Salary != 214400);
            q2.Print("Skip While Salary does not equal 214400 : ");


            var q3 = emps.SkipLast(10);
            q3.Print("Skip last 10 elements : ");

        }
    }
}
