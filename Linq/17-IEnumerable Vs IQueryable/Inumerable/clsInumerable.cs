using System;
using System.Collections.Generic;
using System.Text;

namespace _17_IEnumerable_Vs_IQueryable.Inumerable
{
    internal class clsInumerable
    {
        public static void InumerableTest()
        {
            Console.WriteLine("IEnumerable<T> : Loads all records from the database into memory first,");
            Console.WriteLine("                then applies filters in C# (in-memory).");
            Console.WriteLine("                This can cause high memory usage if the table is large, since all rows are fetched first.");
            Console.WriteLine();
            Console.WriteLine("- Use IEnumerable only if you truly need all the data in memory;");
            Console.WriteLine("  otherwise prefer IQueryable, which translates filters into SQL and lets the DB do the work.");


        }

    }
}
