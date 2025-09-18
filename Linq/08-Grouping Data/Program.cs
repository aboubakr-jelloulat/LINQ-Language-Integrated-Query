using _08_Grouping_Data.Shared;

namespace _08_Grouping_Data
{
    internal class Program
    {

        /* 
          * ===============================================
          * GROUPBY EXAMPLE
          * ===============================================
          * GroupBy groups items **lazily**, meaning the actual grouping
          * happens only when you iterate over the result.
          * 
          * Result type: IEnumerable<IGrouping<TKey, TElement>>
          * - group.Key gives the key (here, Subject)
          * - group elements are all students in that group
          * 
          * Analogy: “Magic sorting hat” – students are organized **on-demand**.
          * Use GroupBy when:
          * - You only need to iterate once
          * - You want to chain LINQ queries (Where, Select, etc.)
          */


        /*
         * ===============================================
         * TOLOOKUP EXAMPLE
         * ===============================================
         * ToLookup groups items **eagerly**, meaning all groups
         * are created immediately and stored in memory.
         * 
         * Result type: ILookup<TKey, TElement>
         * - lookup[key] gives direct access to a group by key
         * 
         * Analogy: “Pre-packed buffet” – all students already in labeled buckets.
         * Use ToLookup when:
         * - You need **fast, repeated access** to specific keys
         * - You want a fixed, cached group structure
         */


        static void Main(string[] args)
        {
            // RunGroupByExample();

            //RunGroupByWithQuerySyntax();

            RunLookupExample();


            Console.ReadKey();
        }


        private static void RunLookupExample()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("ToLookup (Method Syntax");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();
            var result = employees.ToLookup(x => x.Department);

            foreach (var item in result)
            {
                item.Print($"Employee in '{item.Key}' Department");
            }
        }

        private static void RunGroupByWithQuerySyntax()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("GroupBy (Query Syntax");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();
            var result = from emp in employees
                         group emp by emp.Department;

            foreach (var item in result)
            {
                item.Print($"Employee in '{item.Key}' Department");
            }
        }

        private static void RunGroupByExample()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("GroupBy (Method Syntax");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();
            var result = employees.GroupBy(e => e.Department);
            foreach (var item in result)
            {
                item.Print($"Employee in '{item.Key}' Department");
            }

        }

    }
}
