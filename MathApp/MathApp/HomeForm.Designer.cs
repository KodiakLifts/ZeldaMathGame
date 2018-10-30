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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.gameModesGrpBox = new System.Windows.Forms.GroupBox();
            this.divisionRadioBtn = new System.Windows.Forms.RadioButton();
            this.multiplicationRadioBtn = new System.Windows.Forms.RadioButton();
            this.subtractionRadioBtn = new System.Windows.Forms.RadioButton();
            this.addittionRadioBtn = new System.Windows.Forms.RadioButton();
            this.playBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.gameModesGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(34, 29);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(38, 13);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Name:";
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
            // divisionRadioBtn
            // 
            this.divisionRadioBtn.AutoSize = true;
            this.divisionRadioBtn.Location = new System.Drawing.Point(6, 131);
            this.divisionRadioBtn.Name = "divisionRadioBtn";
            this.divisionRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.divisionRadioBtn.TabIndex = 3;
            this.divisionRadioBtn.TabStop = true;
            this.divisionRadioBtn.Tag = "3";
            this.divisionRadioBtn.Text = "Division";
            this.divisionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // multiplicationRadioBtn
            // 
            this.multiplicationRadioBtn.AutoSize = true;
            this.multiplicationRadioBtn.Location = new System.Drawing.Point(6, 93);
            this.multiplicationRadioBtn.Name = "multiplicationRadioBtn";
            this.multiplicationRadioBtn.Size = new System.Drawing.Size(86, 17);
            this.multiplicationRadioBtn.TabIndex = 2;
            this.multiplicationRadioBtn.TabStop = true;
            this.multiplicationRadioBtn.Tag = "2";
            this.multiplicationRadioBtn.Text = "Multiplication";
            this.multiplicationRadioBtn.UseVisualStyleBackColor = true;
            // 
            // subtractionRadioBtn
            // 
            this.subtractionRadioBtn.AutoSize = true;
            this.subtractionRadioBtn.Location = new System.Drawing.Point(6, 56);
            this.subtractionRadioBtn.Name = "subtractionRadioBtn";
            this.subtractionRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.subtractionRadioBtn.TabIndex = 1;
            this.subtractionRadioBtn.TabStop = true;
            this.subtractionRadioBtn.Tag = "1";
            this.subtractionRadioBtn.Text = "Subtraction";
            this.subtractionRadioBtn.UseVisualStyleBackColor = true;
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
            this.addittionRadioBtn.Tag = "0";
            this.addittionRadioBtn.Text = "Addition";
            this.addittionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(34, 284);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(98, 23);
            this.playBtn.TabIndex = 7;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 278);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(34, 46);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 9;
            this.ageLbl.Text = "Age:";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.gameModesGrpBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.editUserBtn);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Game - Home";
            this.gameModesGrpBox.ResumeLayout(false);
            this.gameModesGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.GroupBox gameModesGrpBox;
        private System.Windows.Forms.RadioButton divisionRadioBtn;
        private System.Windows.Forms.RadioButton multiplicationRadioBtn;
        private System.Windows.Forms.RadioButton subtractionRadioBtn;
        private System.Windows.Forms.RadioButton addittionRadioBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ageLbl;
    }
}

