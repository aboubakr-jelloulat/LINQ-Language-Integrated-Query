using _06_Data_Partitioning.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Data_Partitioning._02_Take
{
    internal class Take
    {
        public static void TakeMethods()
        {

            var emps = Repository.LoadEmployees();


            var q1 = emps.Take(10);
            q1.Print("Take First 10 employees : ");


            // 

            var q2 = emps.TakeWhile(x => x.Salary != 214400);
            q2.Print("Take While Salary does not equal 214400 : ");


            var q3 = emps.TakeLast(10);
            q3.Print("Take last 10 elements : ");

        }

    }
}
