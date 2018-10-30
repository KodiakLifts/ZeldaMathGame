﻿namespace MathApp
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
            this.startStopBtn = new System.Windows.Forms.Button();
            this.submitNextBtn = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.correctLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(204, 381);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(100, 23);
            this.startStopBtn.TabIndex = 0;
            this.startStopBtn.Text = "START";
            this.startStopBtn.UseVisualStyleBackColor = true;
            // 
            // submitNextBtn
            // 
            this.submitNextBtn.Location = new System.Drawing.Point(204, 352);
            this.submitNextBtn.Name = "submitNextBtn";
            this.submitNextBtn.Size = new System.Drawing.Size(100, 23);
            this.submitNextBtn.TabIndex = 1;
            this.submitNextBtn.Text = "SUBMIT";
            this.submitNextBtn.UseVisualStyleBackColor = true;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(158, 329);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(40, 13);
            this.questionLbl.TabIndex = 2;
            this.questionLbl.Text = "2 + 2 =";
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Location = new System.Drawing.Point(204, 326);
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.Size = new System.Drawing.Size(100, 20);
            this.answerTxtBox.TabIndex = 3;
            this.answerTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerTxtBox_KeyPress);
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.Location = new System.Drawing.Point(310, 329);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(44, 13);
            this.correctLbl.TabIndex = 4;
            this.correctLbl.Text = "Correct!";
            this.correctLbl.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 308);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.submitNextBtn);
            this.Controls.Add(this.startStopBtn);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button submitNextBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}