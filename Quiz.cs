using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _totalCorrect;

        public Quiz(Question[] questionsArray)
        {
            _questions = questionsArray;
            _totalCorrect = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz App!");
            int currentQuestionNum = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {currentQuestionNum++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice)) {
                    Console.WriteLine("Correct!");
                    _totalCorrect++;
                } else {
                    Console.WriteLine($"Incorrect. The correct answer was {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResults();
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                            Quiz Results                          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nThanks for playing!");
            Console.WriteLine($"You scored {_totalCorrect} out of {_questions.Length} questions.");
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                            Question                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"     {i + 1}. ");
                Console.ResetColor();
                Console.WriteLine($"{question.Answers[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.Write("Please provide your answer number: ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4 )
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                input = Console.ReadLine();
            }

            return choice - 1; 
        }
    }
}
