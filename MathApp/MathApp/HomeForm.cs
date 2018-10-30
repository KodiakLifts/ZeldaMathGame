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
    public partial class HomeForm : Form
    {
        GameForm gameForm;
        UserForm userForm;
        ScoreForm scoreForm;

        User user;

        string username;
        int age;
        int gameMode;

        enum GameMode {Addition, Subtraction, Multiplication, Division};

        public HomeForm()
        {
            InitializeComponent();

            gameForm = new GameForm();
            userForm = new UserForm();
            scoreForm = new ScoreForm();
            user = new User("", 0);

          
            DisplayUserData();
            gameMode = 0;

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
            int gameMode = checkedButton.TabIndex;
            Hide();
            gameForm.gameMode = gameMode;
            gameForm.ShowDialog();
            Show();
        }
    }
}
