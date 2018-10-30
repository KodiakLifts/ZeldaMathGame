namespace MathApp
{
    partial class ScoreForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.scoreTitleLbl = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(101, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 278);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(244, 27);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(36, 13);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.Text = "10/10";
            // 
            // scoreTitleLbl
            // 
            this.scoreTitleLbl.AutoSize = true;
            this.scoreTitleLbl.Location = new System.Drawing.Point(200, 27);
            this.scoreTitleLbl.Name = "scoreTitleLbl";
            this.scoreTitleLbl.Size = new System.Drawing.Size(38, 13);
            this.scoreTitleLbl.TabIndex = 2;
            this.scoreTitleLbl.Text = "Score:";
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(203, 337);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(77, 23);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = true;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.scoreTitleLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label scoreTitleLbl;
        private System.Windows.Forms.Button homeBtn;
    }
}