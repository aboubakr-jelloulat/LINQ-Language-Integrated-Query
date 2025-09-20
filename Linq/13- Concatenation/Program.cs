using _10_Generation_Operations.Shared;

namespace _13__Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RunMethode01();

            // RunMethode02();

            // RunMethode03();

            RunMethod04();

            Console.ReadKey();
        }

        static void RunMethode03()
        {
            //var quiz1 = QuestionBank.Randomize(3);

            //var quiz2 = QuestionBank.Randomize(2);

            //var quiz3 = QuestionBank.GetQuestionRange(Enumerable.Range(11, 14));


            //var questionTitles = quiz1.Select(q1 => q1.Title)
            //    .Concat(quiz2.Select(q2 => q2.Title))
            //    .Concat(quiz3.Select(q3 => q3.Title));


            // you can use 

            var questionTitles = QuestionBank.Randomize(3).Select(q1 => q1.Title)
                .Concat(QuestionBank.Randomize(2).Select(q2 => q2.Title))
                .Concat(QuestionBank.GetQuestionRange(Enumerable.Range(11, 14)).Select(q3 => q3.Title));


            foreach (var title in questionTitles)
                Console.WriteLine(title);

        }

        static void RunMethod04()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);

            var quiz3 = new[] { quiz1, quiz2 }.SelectMany(q => q);

            quiz3.ToQuiz();
        }


        static void RunMethode02()
        {
            var quiz1 = QuestionBank.Randomize(3);

            var quiz2 = QuestionBank.Randomize(2);


            var questionTitles = quiz1.Select(q => q.Title).Concat(quiz2.Select(q => q.Title));

            foreach(var title in questionTitles)
                Console.WriteLine(title);
           
        }


        static void RunMethode01()
        {
            var quiz1 = QuestionBank.Randomize(3);

            var quiz2 = QuestionBank.Randomize(2);


            var concatin = quiz1.Concat(quiz2);

            concatin.ToQuiz();
        }

    }
}
