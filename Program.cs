namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Arizona?", 
                    new string[] {"Pheonix", "Tucson", "Sedona", "Mesa" } , 
                    0
                ),
                new Question(
                    "What is the fastest land mammal?",
                    new string[] {"Black Bear", "Cheetah", "Gazelle", "Ostritch" } ,
                    1
                ),
                new Question(
                    "What is the largest mammal in the world?",
                    new string[] { "Hippopotamus", "Colossal Squid", "Elephant", "Blue Whale" } ,
                    3
                ),
                new Question(
                    "What is the name of the largest ocean on Earth?",
                    new string[] { "Pacific", "Atlantic", "Indian", "Southern" } ,
                    0
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }
}
