using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class GameForm : Form
    {
        private Game game;
        private bool nextQuestion;

        public GameForm()
        {
            InitializeComponent();
            nextQuestion = false;
        }

        public void newGame(Game game)
        {
            this.game = game;
            questionLbl.Text = game.nextQuestion();
        }

        private void answerTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

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
                            correctLbl.Text = "Correct!";
                        } else
                        {
                            correctLbl.Text = "Incorrect!";
                        }
                        nextQuestion = true;
                        submitNextBtn.Text = "NEXT QUESTION";
                    } else
                    {
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

        private void closingOperations()
        {
            gameTimer.Stop();
            timerLbl.Text = "00:00";
            answerTxtBox.Visible = false;
            submitNextBtn.Text = "START";
            answerTxtBox.ReadOnly = true;
            answerTxtBox.Visible = false;
            questionLbl.Visible = false;
            Hide();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.incrementTime();
            timerLbl.Text = game.getTime();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingOperations();
        }
    }
}
