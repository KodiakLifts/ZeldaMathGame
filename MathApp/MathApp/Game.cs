using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    /// <summary>
    /// Class for managing math game logic.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Game mode of enum type GameMode.
        /// </summary>
        public GameMode gameMode { get; set; }
        /// <summary>
        /// Array of math problems formatted as strings.
        /// </summary>
        public string[] questions { get; set; }
        /// <summary>
        /// Array of integer answers corresponding to questions array by index.
        /// </summary>
        public int[] answers { get; set; }
        /// <summary>
        /// Array of boolean values corresponding to questions array by index.
        /// True if user provided correct answer, false if otherwise.
        /// </summary>
        public bool[] points { get; set; }
        /// <summary>
        /// Boolean value for determining if game has reached an end state.
        /// </summary>
        public bool gameOver { get; set; }
        /// <summary>
        /// Integer value for seconds elapsed since game started.
        /// </summary>
        private int timeSeconds;
        /// <summary>
        /// TimeSpan value for time elapsed since game started.
        /// </summary>
        private TimeSpan time;
        /// <summary>
        /// Random number generator for use in generating math problems.
        /// </summary>
        private Random rnd;
        /// <summary>
        /// Index of current question being viewed by the user.
        /// </summary>
        private int currentQuestion;

        public Game(GameMode gameMode)
        {
            this.gameMode = gameMode;
            rnd = new Random();
            questions = new string[10];
            answers = new int[10];
            points = new bool[10];
            generateQuestions();
            gameOver = false;
            currentQuestion = 0;
            timeSeconds = 0;
            time = TimeSpan.FromSeconds(timeSeconds);
        }

        /// <summary>
        /// Get the current elapsed time in game as a string.
        /// </summary>
        /// <returns></returns>
        public string getTime()
        {
            return time.ToString(@"mm\:ss");
        }

        /// <summary>
        /// Increment the elapsed game time by 1 second.
        /// </summary>
        public void incrementTime()
        {
            timeSeconds++;
            time = TimeSpan.FromSeconds(timeSeconds);
        }

        /// <summary>
        /// Awards user a point if they gave the correct answer to the last question provided.
        /// </summary>
        /// <param name="userAnswer"></param>
        public void answerCurrentQuestion(int userAnswer)
        {
            points[currentQuestion-1] = userAnswer == answers[currentQuestion-1];
        }

        /// <summary>
        /// Get total number of correct answers given by user out of 10.
        /// </summary>
        /// <returns></returns>
        public int getNumberCorrect()
        {
            int score = 0;
            for(int i = 0; i < 10; i++)
            {
                if(points[i] == true)
                {
                    score++;
                }
            }
            return score;
        }

        /// <summary>
        /// Get the correct answer for the last question provided.
        /// </summary>
        /// <returns></returns>
        public int getAnswer()
        {
            return answers[currentQuestion-1];
        }

        /// <summary>
        /// Increment current question index and return string of that question.
        /// If no more questions, return "GAME_OVER".
        /// </summary>
        /// <returns></returns>
        public string nextQuestion()
        {
            if(currentQuestion < 10)
            {
                string question = questions[currentQuestion];
                currentQuestion++;
                return question;
            } else
            {
                gameOver = true;
                return "GAME_OVER";
            }
        }

        /// <summary>
        /// Generates 10 math questions according to the game mode selected upon game initialization.
        /// Numbers used are between 1 and 10 and do not result in negative subtraction or remainder division.
        /// </summary>
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
                            do
                            {
                                n1 = rnd.Next(1, 11);
                                n2 = rnd.Next(1, 11);
                            } while (n1 < n2);
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
                            do
                            {
                                n1 = rnd.Next(1, 11);
                                n2 = rnd.Next(1, 11);
                            } while (n1 % n2 != 0);
                            q = "" + n1 + " / " + n2 + " = ";
                        } while (questions.Contains(q));
                        a = n1 / n2;
                        questions[i] = q;
                        answers[i] = a;
                    }
                    break;
            }
        }
    }
}
