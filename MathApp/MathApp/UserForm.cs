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
    public partial class UserForm : Form
    {
        public string username;
        public int userAge;

        public UserForm()
        {
            InitializeComponent();
        }

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
