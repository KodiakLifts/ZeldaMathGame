using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Game
    {
        public GameMode gameMode { get; set; }
        public string[] questions { get; set; }
        public int[] answers { get; set; }

        private Random rnd;
        private bool gameOver;
        private int currentQuestion;

        public Game(GameMode gameMode)
        {
            this.gameMode = gameMode;
            rnd = new Random();
            questions = new string[10];
            answers = new int[10];
            generateQuestions();
            gameOver = false;
            currentQuestion = 0;
        }

        public string nextQuestion()
        {
            string question = questions[currentQuestion];
            currentQuestion++;
            return question;
        }

        private void generateQuestions()
        {
            int n1;
            int n2;
            int a;
            string q;

            switch (gameMode)
            {
                case GameMode.Addition:
                    for (int i = 0; i < 10; i++)
                    {
                        do
                        {
                            n1 = rnd.Next(1, 11);
                            n2 = rnd.Next(1, 11);
                            q = "" + n1 + " + " + n2 + " = ";
                        } while (questions.Contains(q));

                        a = n1 + n2;
                        questions[i] = q;
                        answers[i] = a;
                    }

                    break;
                case GameMode.Subtraction:
                    for (int i = 0; i < 10; i++)
                    {
                        do
                        {
                            n1 = rnd.Next(1, 11);
                            n2 = rnd.Next(1, 11);
                            q = "" + n1 + " - " + n2 + " = ";
                        } while (questions.Contains(q));
                        
                        a = n1 - n2;
                        questions[i] = q;
                        answers[i] = a;
                    }
                    break;
                case GameMode.Multiplication: 
                    for (int i = 0; i < 10; i++)
                    {
                        do
                        {
                            n1 = rnd.Next(1, 11);
                            n2 = rnd.Next(1, 11);
                            q = "" + n1 + " x " + n2 + " = ";
                        } while (questions.Contains(q));

                        a = n1 * n2;
                        questions[i] = q;
                        answers[i] = a;
                    }
                    break;
                case GameMode.Division:
                    for (int i = 0; i < 10; i++)
                    {
                        do
                        {
                            n1 = rnd.Next(1, 11);
                            n2 = rnd.Next(1, 11);
                            q = "" + n1 + " / " + n2 + " = ";
                        } while (n1 % n2 != 0 && questions.Contains(q));

                        a = n1 / n2;
                        questions[i] = q;
                        answers[i] = a;
                    }
                    break;

            }
        }
    }
}
