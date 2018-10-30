namespace MathApp
{
    partial class UserForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.userFormLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ageNumeric = new System.Windows.Forms.NumericUpDown();
            this.nameValidationLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(154, 77);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(163, 103);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 1;
            this.ageLbl.Text = "Age:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(198, 74);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 2;
            // 
            // userFormLbl
            // 
            this.userFormLbl.AutoSize = true;
            this.userFormLbl.Location = new System.Drawing.Point(213, 31);
            this.userFormLbl.Name = "userFormLbl";
            this.userFormLbl.Size = new System.Drawing.Size(62, 13);
            this.userFormLbl.TabIndex = 4;
            this.userFormLbl.Text = "Math Game";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmBtn.Location = new System.Drawing.Point(207, 143);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 195);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ageNumeric
            // 
            this.ageNumeric.Location = new System.Drawing.Point(198, 100);
            this.ageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNumeric.Name = "ageNumeric";
            this.ageNumeric.Size = new System.Drawing.Size(100, 20);
            this.ageNumeric.TabIndex = 8;
            this.ageNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nameValidationLbl
            // 
            this.nameValidationLbl.AutoSize = true;
            this.nameValidationLbl.Location = new System.Drawing.Point(305, 77);
            this.nameValidationLbl.Name = "nameValidationLbl";
            this.nameValidationLbl.Size = new System.Drawing.Size(119, 13);
            this.nameValidationLbl.TabIndex = 9;
            this.nameValidationLbl.Text = "You must enter a name.";
            this.nameValidationLbl.Visible = false;
            // 
            // UserForm
            // 
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.nameValidationLbl);
            this.Controls.Add(this.ageNumeric);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.userFormLbl);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.nameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Game - User Data";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label userFormLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown ageNumeric;
        private System.Windows.Forms.Label nameValidationLbl;
    }
}