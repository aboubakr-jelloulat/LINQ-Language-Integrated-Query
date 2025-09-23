using _17_IEnumerable_Vs_IQueryable.Inumerable;
using _17_IEnumerable_Vs_IQueryable.IQueryable;

namespace _17_IEnumerable_Vs_IQueryable
{
    internal class Program
    {

        // you need a data base

        static void Main(string[] args)
        {

            clsInumerable.InumerableTest();


            clsIQueryable.IQueryableTest();


            clsIQueryable.ExpressionTree();




            Console.ReadKey();
        }
    }
}
