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
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.userFormLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(179, 79);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            this.nameLbl.Click += new System.EventHandler(this.nameLbl_Click);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(188, 105);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 1;
            this.ageLbl.Text = "Age:";
            this.ageLbl.Click += new System.EventHandler(this.ageLbl_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(223, 76);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 2;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(223, 102);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ageTxtBox.TabIndex = 3;
            this.ageTxtBox.TextChanged += new System.EventHandler(this.ageTxtBox_TextChanged);
            // 
            // userFormLbl
            // 
            this.userFormLbl.AutoSize = true;
            this.userFormLbl.Location = new System.Drawing.Point(238, 33);
            this.userFormLbl.Name = "userFormLbl";
            this.userFormLbl.Size = new System.Drawing.Size(62, 13);
            this.userFormLbl.TabIndex = 4;
            this.userFormLbl.Text = "Math Game";
            // 
            // okBtn
            // 
            this.okBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.okBtn.Location = new System.Drawing.Point(232, 145);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "Confirm";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 151);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.userFormLbl);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.nameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Game - User Data";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.Label userFormLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}