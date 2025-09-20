using _10_Generation_Operations.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Aggregate_Operations.Aggregate_Methode
{
    internal class clsAggregate
    {


        public static void RunAggregateMethode()
        {
            // RunMethode1();

            // RunMethode2();

            RunMethode3();

        }


        private static void RunMethode3()
        {
            var quiz = QuestionBank.All;

            var sed = quiz[0];


            Console.WriteLine($"===== sed =====");
            Console.WriteLine(sed);


            var result = quiz.Aggregate(sed, (curr, next) => curr.Title.Length < next.Title.Length ? next : curr, x => x);

            // x => x
            //  👉 This means: “just return the final accumulator as it is.”

            Console.WriteLine($"\n===== Long one =====\n\n {result}");

        }


        private static void RunMethode2()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6 };

            var sum = numbers.Aggregate((a, b) => a + b);

            /*
             *  1 + 2 = 3
                3 + 3 = 6
                6 + 4 = 10
                10 + 5 = 15
                15 + 6 = 21

                Final result = 21

            */

            Console.WriteLine(sum);

            sum = numbers.Aggregate(2, (a, b) => a + b);


            /*
                    Seed = 2

                    Start with a = 2

                    Add first element: 2 + 1 = 3

                    Add second element: 3 + 2 = 5

                    Add third element: 5 + 3 = 8

                    Add fourth element: 8 + 4 = 12

                    Add fifth element: 12 + 5 = 17

                    Add sixth element: 17 + 6 = 23

                    Final result = 23

            */

            Console.WriteLine(sum);


        }

        private static void RunMethode1()
        {

            var names = new[] { "Baker", "Sander", "Vini", "Jamil" };

            // **** Way 1 ****

            //var output = "";

            //foreach (var item in names)
            //{
            //    output += $"{item}, ";
            //}
            //Console.WriteLine(output.TrimEnd(","));


            // **** Way 2 ****


            //var result = string.Join(",", names);

            //Console.WriteLine(result);


            // *** Way 3 : using Aggregate ***


            var commaSeperatedNames = names.Aggregate((a, b) =>
            {
                Console.WriteLine($"a = {a}, b = {b}");

                return $"{a}, {b}";

            }

            );

            Console.WriteLine($"\nfull comma Seperated Names : {commaSeperatedNames}");


        }

    }

}
