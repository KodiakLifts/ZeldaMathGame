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
        private GameForm gameForm;
        private UserForm userForm;
        private ScoreForm scoreForm;

        public string username;
        public int age;

        public HomeForm()
        {
            InitializeComponent();

            gameForm = new GameForm();
            userForm = new UserForm();
            scoreForm = new ScoreForm();

            
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userForm.ShowDialog();
            this.Show();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }
    }
}
