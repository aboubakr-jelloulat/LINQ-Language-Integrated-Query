using _10_Generation_Operations.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Aggregate_Operations.Standard_Methode
{
    internal class clsStandard
    {

        public static void RunStandardMethode()
        {
            // RunCount();


            // RunMax();

            // RunMaxBy();

            // RunMin();

            // RunMinBy();

            // RunSum();

            RunAvg();

        }

        private static void RunCount()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range (1, 200));

            Console.WriteLine($"Total Questions: {quiz.Count()}");
            Console.WriteLine($"Total Questions With One Mark : {quiz.Count(x => x.Marks == 1337)}");
            Console.WriteLine($"Total Questions With One Mark : {quiz.Where(x => x.Marks == 1).Count()}");
            Console.WriteLine($"Total Questions With One Mark Using LongCount : {quiz.Where(x => x.Marks == 1).LongCount()}");


        }

        private static void RunAvg()
        {

            var quiz = QuestionBank.All;

            var avg = quiz.Average(x => x.Marks);

            Console.WriteLine($"Average :  {avg.ToString("#.##")}");

        }

        private static void RunSum()
        {

            var quiz = QuestionBank.All;

            var sum = quiz.Sum(x => x.Marks);

            Console.WriteLine($"Total sum : {sum}");

        }

        private static void RunMax()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            var maximumMark = quiz.Max(q => q.Marks);
            //var maximumMark = quiz.Where(x => x.Choices.Count < 3).Max(x => x.Marks);

            Console.WriteLine($"Maximum Mark: {maximumMark}");
        }

        private static void RunMaxBy()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            var maximumQuestionMark = quiz.MaxBy(x => x.Marks);


            Console.WriteLine($"{maximumQuestionMark}");
        }


        private static void RunMin()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var maximumMark = quiz.Min(x => x.Marks);
            //var minimumMark = quiz.Where(x => x.Choices.Count < 3).Min(x => x.Marks);
            Console.WriteLine($"Minimum Mark: {maximumMark}");
        }
        private static void RunMinBy()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var minimumQuestionMark = quiz.MinBy(x => x.Marks);
            //var minimumMark = quiz.Where(x => x.Choices.Count < 3).MinBy(x => x.Marks);
            Console.WriteLine($"{minimumQuestionMark}");
        }


    }
}
