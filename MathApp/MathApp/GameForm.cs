using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MathApp
{
    /// <summary>
    /// Form for displaying active game.
    /// </summary>
    public partial class GameForm : Form
    {
        /// <summary>
        /// Game object shared with home form.
        /// </summary>
        private Game game;
        /// <summary>
        /// Boolean value for determining if submit button should display "next question".
        /// </summary>
        private bool nextQuestion;
        /// <summary>
        /// Stack for storing images displayed for each question.
        /// </summary>
        private Stack<Image> questionImages;
        /// <summary>
        /// Sound for when correct answer provided.
        /// </summary>
        private SoundPlayer correctSound;
        /// <summary>
        /// Sound for when incorrect answer provided.
        /// </summary>
        private SoundPlayer incorrectSound;

        public GameForm()
        {
            InitializeComponent();
            nextQuestion = false;
            questionImages = new Stack<Image>();
            pushImages();
            try
            {
                correctSound = new SoundPlayer("questionCorrectSound.wav");
            }catch(Exception ex)
            {
                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " -> " + "Failed to load 'correct' sound." +
                    "\n" + ex.Message);
            }
            try
            {
                incorrectSound = new SoundPlayer("questionIncorrectSound.wav");
            }
            catch(Exception ex)
            {
                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                   MethodInfo.GetCurrentMethod().Name + " -> " + "Failed to load 'incorrect' sound." +
                   "\n" + ex.Message);
            }
        }

        /// <summary>
        /// Pushes all question images to the stack.
        /// </summary>
        private void pushImages()
        {
            try
            {
                questionImages.Push(Properties.Resources.question10);
                questionImages.Push(Properties.Resources.question9);
                questionImages.Push(Properties.Resources.question8);
                questionImages.Push(Properties.Resources.question7);
                questionImages.Push(Properties.Resources.question6);
                questionImages.Push(Properties.Resources.question5);
                questionImages.Push(Properties.Resources.question4);
                questionImages.Push(Properties.Resources.question3);
                questionImages.Push(Properties.Resources.question2);
            }
            catch(Exception ex)
            {
                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                   MethodInfo.GetCurrentMethod().Name + " -> " + "Failed to load question images." +
                   "\n" + ex.Message);
            }
        }

        /// <summary>
        /// Initialize a new game.
        /// </summary>
        /// <param name="game"></param>
        public void newGame(Game game)
        {
            this.game = game;
            questionLbl.Text = game.nextQuestion();
        }

        /// <summary>
        /// Validates user input in answer box to only be integers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Determines whether the submit button state.
        /// "START" starts the current game and timer.
        /// "SUBMIT" submits the current answer for scoring.
        /// "NEXT QUESTION" retrieves the next question to be answered.
        /// "VIEW SCORE" ends game and displays score form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitNextBtn_Click(object sender, EventArgs e)
        {
            if(submitNextBtn.Text == "START")
            {
                gameTimer.Start();
                answerTxtBox.ReadOnly = false;
                answerTxtBox.Visible = true;
                submitNextBtn.Text = "SUBMIT";
                questionLbl.Visible = true;
            }
            if(submitNextBtn.Text != "VIEW SCORE" && submitNextBtn.Text != "START")
            {
                if(answerTxtBox.Text != "")
                {
                    if (!nextQuestion)
                    {
                        answerTxtBox.ReadOnly = true;
                        correctLbl.Visible = true;
                        int userAnswer = Int32.Parse(answerTxtBox.Text);
                        game.answerCurrentQuestion(userAnswer);
                        if (game.getAnswer() == userAnswer)
                        {
                            try
                            {
                                correctSound.Play();
                            }
                            catch (Exception ex)
                            {
                                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + "Could not play 'correct' sound." +
                                        "\n" + ex.Message);
                            }
                            correctLbl.Text = "Correct!";
                        } else
                        {
                            try
                            {
                                incorrectSound.Play();
                            }
                            catch(Exception ex)
                            {
                                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + "Could not play 'incorrect' sound." +
                                        "\n" + ex.Message);
                            }
                            correctLbl.Text = "Incorrect!";
                        }
                        nextQuestion = true;
                        submitNextBtn.Text = "NEXT QUESTION";
                    } else
                    {
                        try
                        {
                            pictureBox.Image = questionImages.Pop();
                        }
                        catch(Exception ex)
                        {
                            Console.Write("Last question image reached.\n");
                        }
                        answerTxtBox.ReadOnly = false;
                        answerTxtBox.Text = "";
                        correctLbl.Visible = false;
                        string question = game.nextQuestion();
                        if(question != "GAME_OVER")
                        {
                            questionLbl.Text = question;
                            submitNextBtn.Text = "SUBMIT";
                            nextQuestion = false;
                        } else
                        {
                            answerTxtBox.ReadOnly = true;
                            answerTxtBox.Visible = false;
                            questionLbl.Text = "";
                            submitNextBtn.Text = "VIEW SCORE";
                            nextQuestion = false;
                        }
                    }
                }
            } else
            {
                closingOperations();
            }
        }

        /// <summary>
        /// Resets game form when game ended or form closed.
        /// </summary>
        private void closingOperations()
        {
            gameTimer.Stop();
            timerLbl.Text = "00:00";
            answerTxtBox.Visible = false;
            submitNextBtn.Text = "START";
            answerTxtBox.ReadOnly = true;
            answerTxtBox.Visible = false;
            questionLbl.Visible = false;
            questionImages.Clear();
            pushImages();
            pictureBox.Image = Properties.Resources.question1;
            Hide();
        }

        /// <summary>
        /// When timer started, increments timer label every one second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.incrementTime();
            timerLbl.Text = game.getTime();
        }

        /// <summary>
        /// Calls closing operations when form closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingOperations();
        }
    }
}
