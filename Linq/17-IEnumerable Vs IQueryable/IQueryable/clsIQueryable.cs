using System;
using System.Collections.Generic;
using System.Text;

namespace _17_IEnumerable_Vs_IQueryable.IQueryable
{
    internal class clsIQueryable
    {
        public static void IQueryableTest()
        {
            Console.WriteLine("\n\nIQueryable<T> : Works with Expression Trees and lets the database do the filtering.");
            Console.WriteLine();
            Console.WriteLine("How it works:");
            Console.WriteLine("1. When you call .Where(x => x.Price > 50), the lambda is not executed immediately.");
            Console.WriteLine("   Instead, it is stored as an Expression Tree (a query blueprint).");
            Console.WriteLine();
            Console.WriteLine("2. Entity Framework inspects the Expression Tree and translates it into SQL.");
            Console.WriteLine("   Example SQL: SELECT * FROM Books WHERE Price > 50");
            Console.WriteLine();
            Console.WriteLine("3. The SQL is sent to the database engine.");
            Console.WriteLine("   The filtering (Price > 50) happens inside the database, not in C#.");
            Console.WriteLine();
            Console.WriteLine("4. Only the matching rows are returned to your application.");
            Console.WriteLine("   EF turns those rows into Book objects in memory.");
            Console.WriteLine();
            Console.WriteLine("=> Result: Only needed data is loaded, which is faster and uses less memory compared to IEnumerable.");


        }


        public static void ExpressionTree()
        {
            Console.WriteLine("\n\nExpression Trees in C#");
            Console.WriteLine();
            Console.WriteLine("1. An Expression Tree is a data structure that represents code as a tree of objects.");
            Console.WriteLine("   Example: Expression<Func<Book, bool>> expr = x => x.Price > 50;");
            Console.WriteLine("   This does not execute the code, it stores a blueprint of the code.");
            Console.WriteLine();
            Console.WriteLine("2. The tree describes:");
            Console.WriteLine("   - Parameter: x (of type Book)");
            Console.WriteLine("   - Member Access: x.Price");
            Console.WriteLine("   - Operator: >");
            Console.WriteLine("   - Constant: 50");
            Console.WriteLine();
            Console.WriteLine("3. Why we use it:");
            Console.WriteLine("   - LINQ providers like Entity Framework read the expression tree");
            Console.WriteLine("     instead of executing it directly.");
            Console.WriteLine("   - This allows EF to translate the logic into SQL.");
            Console.WriteLine("   - Example: x => x.Price > 50 becomes:");
            Console.WriteLine("     SELECT * FROM Books WHERE Price > 50");
            Console.WriteLine();
            Console.WriteLine("4. Without Expression Trees:");
            Console.WriteLine("   - EF would have to fetch all rows into memory");
            Console.WriteLine("     and filter in C# (like IEnumerable does).");
            Console.WriteLine("   - This would waste memory and be very slow on large tables.");
            Console.WriteLine();
            Console.WriteLine("=> Summary: Expression Trees let C# treat code as data, so frameworks like EF");
            Console.WriteLine("   can translate LINQ queries into SQL and run them efficiently in the database.");


        }

    }
}
