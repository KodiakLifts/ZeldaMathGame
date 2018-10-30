namespace MathApp
{
    partial class HomeForm
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
            this.editUserBtn = new System.Windows.Forms.Button();
            this.userDataLbl = new System.Windows.Forms.Label();
            this.gameModesGrpBox = new System.Windows.Forms.GroupBox();
            this.addittionRadioBtn = new System.Windows.Forms.RadioButton();
            this.subtractionRadioBtn = new System.Windows.Forms.RadioButton();
            this.multiplicationRadioBtn = new System.Windows.Forms.RadioButton();
            this.divisionRadioBtn = new System.Windows.Forms.RadioButton();
            this.playBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gameModesGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // editUserBtn
            // 
            this.editUserBtn.Location = new System.Drawing.Point(34, 64);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(98, 23);
            this.editUserBtn.TabIndex = 0;
            this.editUserBtn.Text = "Edit User";
            this.editUserBtn.UseVisualStyleBackColor = true;
            // 
            // userDataLbl
            // 
            this.userDataLbl.AutoSize = true;
            this.userDataLbl.Location = new System.Drawing.Point(53, 29);
            this.userDataLbl.Name = "userDataLbl";
            this.userDataLbl.Size = new System.Drawing.Size(60, 13);
            this.userDataLbl.TabIndex = 1;
            this.userDataLbl.Text = "Name, Age";
            // 
            // gameModesGrpBox
            // 
            this.gameModesGrpBox.Controls.Add(this.divisionRadioBtn);
            this.gameModesGrpBox.Controls.Add(this.multiplicationRadioBtn);
            this.gameModesGrpBox.Controls.Add(this.subtractionRadioBtn);
            this.gameModesGrpBox.Controls.Add(this.addittionRadioBtn);
            this.gameModesGrpBox.Location = new System.Drawing.Point(34, 107);
            this.gameModesGrpBox.Name = "gameModesGrpBox";
            this.gameModesGrpBox.Size = new System.Drawing.Size(98, 159);
            this.gameModesGrpBox.TabIndex = 6;
            this.gameModesGrpBox.TabStop = false;
            this.gameModesGrpBox.Text = "Game Mode";
            // 
            // addittionRadioBtn
            // 
            this.addittionRadioBtn.AutoSize = true;
            this.addittionRadioBtn.Checked = true;
            this.addittionRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.addittionRadioBtn.Name = "addittionRadioBtn";
            this.addittionRadioBtn.Size = new System.Drawing.Size(63, 17);
            this.addittionRadioBtn.TabIndex = 0;
            this.addittionRadioBtn.TabStop = true;
            this.addittionRadioBtn.Text = "Addition";
            this.addittionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // subtractionRadioBtn
            // 
            this.subtractionRadioBtn.AutoSize = true;
            this.subtractionRadioBtn.Location = new System.Drawing.Point(6, 56);
            this.subtractionRadioBtn.Name = "subtractionRadioBtn";
            this.subtractionRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.subtractionRadioBtn.TabIndex = 1;
            this.subtractionRadioBtn.TabStop = true;
            this.subtractionRadioBtn.Text = "Subtraction";
            this.subtractionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // multiplicationRadioBtn
            // 
            this.multiplicationRadioBtn.AutoSize = true;
            this.multiplicationRadioBtn.Location = new System.Drawing.Point(6, 93);
            this.multiplicationRadioBtn.Name = "multiplicationRadioBtn";
            this.multiplicationRadioBtn.Size = new System.Drawing.Size(86, 17);
            this.multiplicationRadioBtn.TabIndex = 2;
            this.multiplicationRadioBtn.TabStop = true;
            this.multiplicationRadioBtn.Text = "Multiplication";
            this.multiplicationRadioBtn.UseVisualStyleBackColor = true;
            // 
            // divisionRadioBtn
            // 
            this.divisionRadioBtn.AutoSize = true;
            this.divisionRadioBtn.Location = new System.Drawing.Point(6, 131);
            this.divisionRadioBtn.Name = "divisionRadioBtn";
            this.divisionRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.divisionRadioBtn.TabIndex = 3;
            this.divisionRadioBtn.TabStop = true;
            this.divisionRadioBtn.Text = "Division";
            this.divisionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(34, 284);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(98, 23);
            this.playBtn.TabIndex = 7;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 278);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 343);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.gameModesGrpBox);
            this.Controls.Add(this.userDataLbl);
            this.Controls.Add(this.editUserBtn);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Game - Home";
            this.gameModesGrpBox.ResumeLayout(false);
            this.gameModesGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Label userDataLbl;
        private System.Windows.Forms.GroupBox gameModesGrpBox;
        private System.Windows.Forms.RadioButton divisionRadioBtn;
        private System.Windows.Forms.RadioButton multiplicationRadioBtn;
        private System.Windows.Forms.RadioButton subtractionRadioBtn;
        private System.Windows.Forms.RadioButton addittionRadioBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

