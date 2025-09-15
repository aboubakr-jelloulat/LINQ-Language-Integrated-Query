namespace _02_Functional_Programming
{
    internal class Program
    {
        static void Main()
        {

            //RunExtensionProcedural();

            //RunExtensionFunctional01();

            RunExtensionFunctional02();


            Console.ReadKey();

        }

        private static void RunExtensionProcedural()
        {
            var q1 = ExtnensionProcedural.GetEmployeesWithFirstNameStartsWith("ma");
            ExtnensionProcedural.Print(q1, "Employees with first name starts with 'ma'");

            var q2 = ExtnensionProcedural.GetEmployeesWithLastNameStartsWith("ju");
            ExtnensionProcedural.Print(q2, "Employees with last name starts with 'ju'");

            var q3 = ExtnensionProcedural.GetEmployeesWithDepartmentEqualsTo("hr");
            ExtnensionProcedural.Print(q3, "Employees in 'HR' department");

            var q4 = ExtnensionProcedural.GetEmployeesByGender("female");
            ExtnensionProcedural.Print(q4, "Female employees");

            var q5 = ExtnensionProcedural.GetEmployeesHiredInYear(2018);
            ExtnensionProcedural.Print(q5, "Employees hired in '2018'");

            var q6 = ExtnensionProcedural.GetEmployeesWithPensionPlanValueEqualsTo(true);
            ExtnensionProcedural.Print(q6, "Employees with Pension Plan");

            var q7 = ExtnensionProcedural.GetEmployeesWithHealthInsuranceValueEqualsTo(false);
            ExtnensionProcedural.Print(q7, "Employees without Health insurance");

            var q8 = ExtnensionProcedural.GetEmployeesWithSalaryEqualsTo(103200);
            ExtnensionProcedural.Print(q8, "Employees with Salary = $103200");

            var q9 = ExtnensionProcedural.GetEmployeesWithSalaryGreaterThan(107000);
            ExtnensionProcedural.Print(q9, "Employees with Salary > $107000");

            var q10 = ExtnensionProcedural.GetEmployeesWithSalaryLessThan(107000);
            ExtnensionProcedural.Print(q10, "Employees with Salary < $107000");

        }

        private static void RunExtensionFunctional01()
        {
            var list = Repository.LoadEmployees();

            var q1 = ExtensionFunctional01.Filter(list,
                e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
            ExtensionFunctional01.Print(q1, "Employees with first name starting with 'ma'");

            var q2 = ExtensionFunctional01.Filter(list,
                e => e.LastName.ToLowerInvariant().StartsWith("ju"));
            ExtensionFunctional01.Print(q2, "Employees with last name starting with 'ju'");

            var q3 = ExtensionFunctional01.Filter(list,
                e => e.Department.ToLowerInvariant() == "hr");
            ExtensionFunctional01.Print(q3, "Employees in 'HR' department");

            var q4 = ExtensionFunctional01.Filter(list,
                e => e.Gender.ToLowerInvariant() == "female");
            ExtensionFunctional01.Print(q4, "Female employees");

            var q5 = ExtensionFunctional01.Filter(list,
                e => e.HireDate.Year == 2018);
            ExtensionFunctional01.Print(q5, "Employees hired in '2018'");

            var q6 = ExtensionFunctional01.Filter(list,
                e => e.HasPensionPlan);
            ExtensionFunctional01.Print(q6, "Employees with Pension Plan");

            var q7 = ExtensionFunctional01.Filter(list,
                e => !e.HasHealthInsurance);
            ExtensionFunctional01.Print(q7, "Employees without Health insurance");

            var q8 = ExtensionFunctional01.Filter(list,
                e => e.Salary == 107000);
            ExtensionFunctional01.Print(q8, "Employees with Salary = $107000");

            var q9 = ExtensionFunctional01.Filter(list,
                e => e.Salary > 107000);
            ExtensionFunctional01.Print(q9, "Employees with Salary > $107000");

            var q10 = ExtensionFunctional01.Filter(list,
                e => e.Salary < 107000);
            ExtensionFunctional01.Print(q10, "Employees with Salary < $107000");

            var q11 = ExtensionFunctional01.Filter(list,
                e => e.Salary < 107000 && e.Gender.ToLowerInvariant() == "female");
            ExtensionFunctional01.Print(q11, "Employees with Salary < $107000 and female");
        }


        private static void RunExtensionFunctional02()
        {
            var list = Repository.LoadEmployees();

            var q1 = list.Filter(e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
            q1.Print("Employees with first name starting with 'ma'");

            var q2 = list.Filter(e => e.LastName.ToLowerInvariant().StartsWith("ju"));
            q2.Print("Employees with last name starting with 'ju'");

            var q3 = list.Filter(e => e.Department.ToLowerInvariant() == "hr");
            q3.Print("Employees in 'HR' department");

            var q4 = list.Filter(e => e.Gender.ToLowerInvariant() == "female");
            q4.Print("Female employees");

            var q5 = list.Filter(e => e.HireDate.Year == 2018);
            q5.Print("Employees hired in '2018'");

            var q6 = list.Filter(e => e.HasPensionPlan);
            q6.Print("Employees with Pension Plan");

            var q7 = list.Filter(e => !e.HasHealthInsurance);
            q7.Print("Employees without Health insurance");

            var q8 = list.Filter(e => e.Salary == 107000);
            q8.Print("Employees with Salary = $107000");

            var q9 = list.Filter(e => e.Salary > 107000);
            q9.Print("Employees with Salary > $107000");

            var q10 = list.Filter(e => e.Salary < 107000);
            q10.Print("Employees with Salary < $107000");

            var q11 = list.Filter(e => e.Salary < 107000 && e.Gender.ToLowerInvariant() == "female");
            q11.Print("Employees with Salary < $107000 and female");
        }


    }
}
