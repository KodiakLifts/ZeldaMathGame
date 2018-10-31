using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace MathApp
{
    /// <summary>
    /// Form for displaying users score after playing math game.
    /// </summary>
    public partial class ScoreForm : Form
    {
        /// <summary>
        /// List of possible images to display with score.
        /// </summary>
        private List<Image> scoreImages;

        public ScoreForm()
        {
            InitializeComponent();
            scoreImages = new List<Image>();
            try
            {
                scoreImages.Add(Properties.Resources.poorScore);
                scoreImages.Add(Properties.Resources.goodScore);
                scoreImages.Add(Properties.Resources.perfectScore);
            }
            catch(Exception ex)
            {
                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + " -> " + "Failed to load score images." +
                    "\n" + ex.Message);
            }
        }

        /// <summary>
        /// Sets which image to display with the score.
        /// 0: Poor score.
        /// 1: Good score.
        /// 2: Perfect score.
        /// </summary>
        /// <param name="imageNumber"></param>
        public void setScoreImage(int imageNumber)
        {
            try
            {
                pictureBox.Image = scoreImages[imageNumber];
            }
            catch(Exception ex)
            {
                Console.Write(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " -> " + "Invalid image number." +
                    "\n" + ex.Message);
            }
        }

        /// <summary>
        /// Assigns the given name, score, and completion time to the score label.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        /// <param name="time"></param>
        public void viewScore(string name, string score, string time)
        {
            scoreLbl.Text = name + " got " + score + " in " + time + "!";
        }

        /// <summary>
        /// Handles home button click closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
