using System.Linq.Expressions;

namespace _16__Expression_Trees
{
    internal class Program
    {
       static void Main(string[] args)
       {
            // RunExample01();


            ParceExpressionTree();


            Console.ReadKey();
       }

        private static void  ParceExpressionTree()
        {
            Expression<Func<int, bool>> IsNegativeExpression = (num) => num < 0;

            ParameterExpression numParam = IsNegativeExpression.Parameters[0];
            BinaryExpression operation = (BinaryExpression)IsNegativeExpression.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            Console.WriteLine($"Decomposed Expression: " +
                $"{numParam.Name} => {left.Name} {operation.NodeType} {right.Value}");


        }


        private static void RunExample01()
        {
            Func<int, bool> IsEven = (num) => num % 2 == 0;

            Console.WriteLine("Using Delegate : " + IsEven(10));

            Console.WriteLine("Using Delegate & Invoke : " + IsEven.Invoke(10));

            Console.WriteLine("Using Methode : " + IsEvenMethode(11)); // using Methode 



            Console.WriteLine("\n\t * * * * * *  Using Expression * * * * * * \n");

            Expression<Func<int, bool>> IsEvenexpression = (num) => num % 2 == 0;

            Func<int, bool> IsEvenV2 = IsEvenexpression.Compile();

            Console.WriteLine("Using Expression : " + IsEvenV2(10));


        }

        static bool IsEvenMethode(int num)
        {
            return num % 2 == 0;
        }




    }
}
