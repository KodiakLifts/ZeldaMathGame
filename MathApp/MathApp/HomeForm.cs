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
    /// Enum containing all available math game modes.
    /// </summary>
    public enum GameMode { Addition, Subtraction, Multiplication, Division };

    /// <summary>
    /// Home screen form where user can edit their information or select which game to play.
    /// </summary>
    public partial class HomeForm : Form
    {
        /// <summary>
        /// Instance of Game Form where game is played.
        /// </summary>
        GameForm gameForm;
        /// <summary>
        /// Instance of User Form where user information is edited.
        /// </summary>
        UserForm userForm;
        /// <summary>
        /// Instance of Score Form where game score is displayed.
        /// </summary>
        ScoreForm scoreForm;
        /// <summary>
        /// Field for storing currently played game.
        /// </summary>
        Game game;
        /// <summary>
        /// Field for storing current user object.
        /// </summary>
        User user;
        /// <summary>
        /// Sound to play upon reaching the score form.
        /// </summary>
        SoundPlayer scoreSound;
        /// <summary>
        /// Enum value of currently selected game mode.
        /// </summary>
        GameMode gameMode;

        public HomeForm()
        {
            InitializeComponent();
            gameForm = new GameForm();
            userForm = new UserForm();
            scoreForm = new ScoreForm();
            user = new User("", 0);
            try
            {
                scoreSound = new SoundPlayer("scoreSound.wav");
            }catch(Exception ex)
            {
                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " -> " + "Failed to load Score Sound." +
                    "\n" + ex.Message);
            }
            DisplayUserData();
        }

        /// <summary>
        /// Shows user form for editing user information and storing in user object.
        /// </summary>
        private void DisplayUserData()
        {
            Hide();
            userForm.ShowDialog();
            user.name = userForm.username;
            user.age = userForm.userAge;
            Show();
            usernameLbl.Text = "Name: " + user.name;
            ageLbl.Text = "Age: " + user.age;
        }

        /// <summary>
        /// When edit user data button is clicked, display user form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editUserBtn_Click(object sender, EventArgs e)
        {
            DisplayUserData();
        }

        /// <summary>
        /// When play button is clicked, display game form, followed by score form when game form is exited.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playBtn_Click(object sender, EventArgs e)
        {
            var checkedButton = gameModesGrpBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            gameMode = (GameMode)checkedButton.TabIndex;
            game = new Game(gameMode);
            gameForm.newGame(game);
            Hide();
            gameForm.ShowDialog();
            scoreForm.viewScore(user.name, game.getNumberCorrect() + " out of 10", game.getTime());
            scoreForm.setScoreImage(scoreImageIndex(game.getNumberCorrect()));
            try
            {
                scoreSound.Play();
            }catch(Exception ex)
            {
                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " -> " + "Could not play Score Sound." +
                    "\n" + ex.Message);
            }
            scoreForm.ShowDialog();
            Show();
        }

        /// <summary>
        /// Determines which score image to display based on the users score.
        /// </summary>
        /// <param name="numberCorrect"></param>
        /// <returns></returns>
        private int scoreImageIndex(int numberCorrect)
        {
            if(numberCorrect < 5)
            {
                return 0;
            }
            if(numberCorrect < 10)
            {
                return 1;
            }
            if(numberCorrect == 10)
            {
                return 2;
            }
            return 2;
        }

        /// <summary>
        /// Changed home form image to addition variant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addittionRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.homeAdd;
        }

        /// <summary>
        /// Changes home form image to subtraction variant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractionRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.homeSub;
        }

        /// <summary>
        /// Changes home form image to multiplication variant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiplicationRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.homeMult;
        }

        /// <summary>
        /// Changes home form image to division variant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divisionRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.homeDiv;
        }
    }
}
