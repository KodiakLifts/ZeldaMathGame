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
    public partial class ScoreForm : Form
    {
        public string score { get; set; }

        public ScoreForm()
        {
            InitializeComponent();
        }

        public void viewScore(string name, string score, string time)
        {
            scoreLbl.Text = "Congratulations " + name + "! You got " + score + " in " + time + "!";
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
