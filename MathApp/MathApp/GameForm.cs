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
        private GameMode gameMode;
        private Game game;
        private int questionNumber;
        private bool nextQuestion;

        public GameForm()
        {
            InitializeComponent();

            gameMode = GameMode.Addition;
            game = new Game(gameMode);
            questionNumber = 0;
            nextQuestion = false;
        }

        public void newGame(GameMode gameMode)
        {
            this.gameMode = gameMode;
            this.game = new Game(gameMode);
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
            if(answerTxtBox.Text != "")
            {
                if (!nextQuestion)
                {
                    correctLbl.Visible = true;
                    if(game.answers[questionNumber] == Int32.Parse(answerTxtBox.Text))
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
                    answerTxtBox.Text = "";
                    correctLbl.Visible = false;
                    questionNumber++;
                    questionLbl.Text = game.nextQuestion();
                    submitNextBtn.Text = "SUBMIT";
                    nextQuestion = false;
                }
            }
        }
    }
}
