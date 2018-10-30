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

            gameMode = 0;

            DisplayUserData();

        }

        private void DisplayUserData()
        {
            Hide();
            userForm.ShowDialog();
            Show();

            username = userForm.username;
            age = userForm.age;

            usernameLbl.Text = "Name: " + username;
            ageLbl.Text = "Age: " + age;
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
