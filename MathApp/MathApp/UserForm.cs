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
    /// <summary>
    /// Form for managing user information.
    /// </summary>
    public partial class UserForm : Form
    {
        /// <summary>
        /// Temporary variable for username.
        /// </summary>
        public string username;
        /// <summary>
        /// Temporary variable for user age.
        /// </summary>
        public int userAge;

        public UserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles user click to confirm username and age.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!nameTxtBox.Text.Equals(""))
            {
                nameValidationLbl.Visible = false;
                username = nameTxtBox.Text;
                userAge =  (int)ageNumeric.Value;
                Hide();
            } else
            {
                nameValidationLbl.Visible = true;
            }
        }
    }
}
