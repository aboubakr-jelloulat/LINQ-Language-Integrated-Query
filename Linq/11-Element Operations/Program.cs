using _10_Generation_Operations.Shared;

namespace _11_Element_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ElementAt();

            //First();

            //Last();

            Single();


            Console.ReadKey();
        }


        static void Single()
        {
            var questions = QuestionBank.All;
            //var question = questions.Single(x => x.Title.Contains("#245"));
            //Console.WriteLine(question);

            //var question2 = questions.SingleOrDefault(x => x.Title.Contains("#245"));
            //Console.WriteLine(question2);

            //var question3 = questions.Single(x => x.Title.Length == 0);

            var question4 = questions.FirstOrDefault(x => x.Title.Length == 0);
            if (question4 is null)
                Console.WriteLine("Question 4 is null ");

        }

        static void Last()
        {
            var questions = QuestionBank.All;
            var lastQuestion = questions.Last();

            //Console.WriteLine(lastQuestion);

            //var someQuestion = questions.Last(x => x.Title.Length == 0); //InvalidOperationException

            var someOtherQuestion = questions.LastOrDefault(x => x.Title.Length == 0); //null

            if (someOtherQuestion is null)
            {
                Console.WriteLine("Question is null");
            }


        }


        static void First()
        {
            var questions = QuestionBank.All;

            var firstquestion = questions.First();

            //Console.WriteLine(firstquestion);

            //var somequestion = questions.First(x => x.Title.Length == 0); // exception 

            //Console.WriteLine(somequestion);


            var someAnotherQuestion = questions.FirstOrDefault(x => x.Title.Length == 0);

            if (someAnotherQuestion is null)
            {
                Console.WriteLine("Question is null");
            }

            Console.WriteLine(someAnotherQuestion);

        }

        static void ElementAt()
        {
            var questions = QuestionBank.All;

            var questionAt10 = questions.ElementAt(10);

            // var questionOutOfRange = questions.ElementAt(400); // Argument out of Range Exception 

            var questionOutOfRange = questions.ElementAtOrDefault(400);

            Console.WriteLine(questionOutOfRange);


        }


    }
}
