using _03_Core_Of_LINQ.Shared;

namespace _03_Core_Of_LINQ
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //FiltringWhere();


            //MethodeSyntaxVsQuerySyntax();

            LinQExamples();

            Console.ReadKey();
        }


        private static void FiltringWhere()
        {
            var employees = Repository.LoadEmployees();

            var q1 = employees.Filter(e => e.Gender == "female" && e.FirstName.ToLowerInvariant().StartsWith("s"));

            q1.Print("using my Filter : ");


            var q2 = employees.Where(e => e.Gender == "female" && e.FirstName.ToLowerInvariant().StartsWith("s"));

            q2.Print("using Linq Where : ");


        }

        private static void MethodeSyntaxVsQuerySyntax()
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbersUsingExtensionWhere = numbers.Where(x => x % 2 == 0);

            var evenNumbersUsingEnumerableWhereMethod = Enumerable.Where(numbers, x => x % 2 == 0);

            // Select n fROM numbers where n % 2 = 0;
            var evenNumbersUsingQuerySyntax =
                 from n in numbers
                 where n % 2 == 0
                 select n;


            evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
            evenNumbersUsingEnumerableWhereMethod.Print("evenNumbersUsingEnumerableWhereMethod");
            evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");

        }

        private static void LinQExamples()
        {

            var employees = Repository.LoadEmployees();

            var empMale = employees.Where(x => x.Gender == "male");

            var empsSalaryOver300K = employees.Where(x => x.Salary >= 300_000);

            empMale.Print("Male Employees");

            empsSalaryOver300K.Print("Employees with Salary >= 300K");

            var empMaleInHRDepartment =
                empMale.Where(x => x.Department.ToLowerInvariant() == "hr");

            empMaleInHRDepartment.Print("Male Employees In HR");

        }

    }
}
