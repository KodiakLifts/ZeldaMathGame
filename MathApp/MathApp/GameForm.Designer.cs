namespace MathApp
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.submitNextBtn = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.correctLbl = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLbl = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // submitNextBtn
            // 
            this.submitNextBtn.Location = new System.Drawing.Point(183, 343);
            this.submitNextBtn.Name = "submitNextBtn";
            this.submitNextBtn.Size = new System.Drawing.Size(100, 23);
            this.submitNextBtn.TabIndex = 1;
            this.submitNextBtn.Text = "START";
            this.submitNextBtn.UseVisualStyleBackColor = true;
            this.submitNextBtn.Click += new System.EventHandler(this.submitNextBtn_Click);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(137, 320);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(40, 13);
            this.questionLbl.TabIndex = 2;
            this.questionLbl.Text = "2 + 2 =";
            this.questionLbl.Visible = false;
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Location = new System.Drawing.Point(183, 317);
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.ReadOnly = true;
            this.answerTxtBox.Size = new System.Drawing.Size(100, 20);
            this.answerTxtBox.TabIndex = 3;
            this.answerTxtBox.Visible = false;
            this.answerTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerTxtBox_KeyPress);
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.Location = new System.Drawing.Point(289, 320);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(44, 13);
            this.correctLbl.TabIndex = 4;
            this.correctLbl.Text = "Correct!";
            this.correctLbl.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Location = new System.Drawing.Point(207, 9);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(34, 13);
            this.timerLbl.TabIndex = 6;
            this.timerLbl.Text = "00:00";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::MathApp.Properties.Resources.question1;
            this.pictureBox.Location = new System.Drawing.Point(96, 33);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(278, 278);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // GameForm
            // 
            this.AcceptButton = this.submitNextBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.submitNextBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zelda Math Adventures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitNextBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label timerLbl;
    }
}