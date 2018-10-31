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
    public enum GameMode { Addition, Subtraction, Multiplication, Division };

    public partial class HomeForm : Form
    {
        GameForm gameForm;
        UserForm userForm;
        ScoreForm scoreForm;

        Game game;
        User user;
        
        GameMode gameMode;

        public HomeForm()
        {
            InitializeComponent();

            gameForm = new GameForm();
            userForm = new UserForm();
            scoreForm = new ScoreForm();
            user = new User("", 0);
          
            DisplayUserData();
        }

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

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            DisplayUserData();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            var checkedButton = gameModesGrpBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            gameMode = (GameMode)checkedButton.TabIndex;
            game = new Game(gameMode);
            gameForm.newGame(game);
            Hide();
            gameForm.ShowDialog();
            scoreForm.viewScore(game.getScore()); 
            scoreForm.ShowDialog();
            Show();
        }
    }
}
