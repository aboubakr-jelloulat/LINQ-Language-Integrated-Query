using _10_Generation_Operations.Shared;

namespace _10_Generation_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DefaultEmpty();

            //RangeOperation();

            Repeat();

            Console.ReadKey();
        }

        static void Repeat()
        {
            var q = QuestionBank.PickOne();

            var question = Enumerable.Repeat(q, 10);

            question.ToQuiz();

        }

        static void RangeOperation()
        {
            var range = Enumerable.Range(1, 10);

            //int[] range2 = new int[10];

            //for (int i = 0; i < range2.Length; i++)
            //    range2[i] = i;

            //for (int i = 0; i < range2.Length; i++)
            //    Console.Write($" {i}");

            //foreach (var i in range) 
            //    Console.Write($" {i}");

            var Question = QuestionBank.GetQuestionRange(range);

            Question.ToQuiz();

        }

        static void DefaultEmpty()
        {
            //int x; // x=0;
            //Console.WriteLine(default(int)); // 0
            //Console.WriteLine(default(DateTime)); // 01-01-0001 12:00:00 AM
            //Console.WriteLine(default(Object) is null ? "NULL" : default(Object) is null); // NULL


            var questions = Enumerable.Empty<Question>();

            var question2 = questions.DefaultIfEmpty();

            var question3 = questions.DefaultIfEmpty(Question.Default); // Question.Default => Metode in Question Class

            question3.ToQuiz();


        }

    }
}
