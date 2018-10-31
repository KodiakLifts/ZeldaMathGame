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
        private List<Image> scoreImages;

        public ScoreForm()
        {
            InitializeComponent();
            scoreImages = new List<Image>();
            scoreImages.Add(Properties.Resources.poorScore);
            scoreImages.Add(Properties.Resources.goodScore);
            scoreImages.Add(Properties.Resources.perfectScore);
        }

        public void setScoreImage(int imageNumber)
        {
            pictureBox.Image = scoreImages[imageNumber];
        }

        public void viewScore(string name, string score, string time)
        {
            scoreLbl.Text = name + " got " + score + " in " + time + "!";
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
