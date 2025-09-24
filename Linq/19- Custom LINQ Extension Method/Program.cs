using _19__Custom_LINQ_Extension_Method.Shared;

namespace _19__Custom_LINQ_Extension_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // SimplePaginate();

            // UsingPaginateExtentionMethode();

            // WhereWithPaginateMethode();


            RandomMethode();

            Console.ReadKey();
        }



        static void RandomMethode()
        {
            var employees = Repository.Employees;

            var randomEmployee = employees.Random(x => true);
            Console.WriteLine("Random Employee");
            Console.WriteLine(randomEmployee);


            var randomEmployeeWithoutPensionPlan = employees.Random(x => !x.HasPensionPlan);
            Console.WriteLine("Random Employee without pension plan");
            Console.WriteLine(randomEmployeeWithoutPensionPlan);


            var randomEmpfromItDepartments = employees.Random(e => e.Department.Equals("IT"));
            Console.WriteLine("Random Employee From IT Department : ");
            Console.WriteLine(randomEmpfromItDepartments);



        }

        static void WhereWithPaginateMethode()
        {
            var employees = Repository.Employees;

            var page1x7Covered = employees.WhereWithPaginate(e => e.HasHealthInsurance, 1, 7);
            page1x7Covered.Print("page #1  [7 covered emps]");


            var page1x5IT = employees.WhereWithPaginate(e => e.Department.Equals("IT"), 1, 5);
            page1x5IT.Print("page #1  [5 Emps in IT]");

        }

        static void UsingPaginateExtentionMethode()
        {

            var employees = Repository.Employees;


            var page = 1;
            var pageSize = 4;

            var page2x4 = employees.Paginate(page, pageSize);
            page2x4.Print("page #2  [4 emps]");

            var page1x10 = employees.Paginate();
            page1x10.Print("page #1  [10 emps]");

            var page7x10 = employees.Paginate(7);
            page7x10.Print("page #7  [10 emps]");


            var page1x7 = employees.Paginate2(null, 7); // Handle null
            page1x7.Print("page #1  [7 emps]");


        }

        static void SimplePaginate()
        {
            var employees = Repository.Employees;

            var page = 1;
            var pagesize = 4;

            var page1 = employees.Skip((page - 1) * pagesize).Take(pagesize);

            page1.Print("Page #1 ");


        }



    }
}
