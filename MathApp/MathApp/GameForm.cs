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
            if(submitNextBtn.Text != "VIEW SCORE")
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
                answerTxtBox.ReadOnly = false;
                submitNextBtn.Text = "SUBMIT";
                Hide();
            }
        }
    }
}
