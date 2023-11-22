namespace HangmanGame
{
    partial class Hangman_Game
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
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.AddWordsBtn = new System.Windows.Forms.Button();
            this.CustomWordsCheckBox = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Location = new System.Drawing.Point(182, 195);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(109, 51);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddWordsBtn
            // 
            this.AddWordsBtn.Location = new System.Drawing.Point(182, 276);
            this.AddWordsBtn.Name = "AddWordsBtn";
            this.AddWordsBtn.Size = new System.Drawing.Size(109, 44);
            this.AddWordsBtn.TabIndex = 1;
            this.AddWordsBtn.Text = "Add Words";
            this.AddWordsBtn.UseVisualStyleBackColor = true;
            this.AddWordsBtn.Click += new System.EventHandler(this.AddWordsBtn_Click);
            // 
            // CustomWordsCheckBox
            // 
            this.CustomWordsCheckBox.AutoSize = true;
            this.CustomWordsCheckBox.Location = new System.Drawing.Point(164, 369);
            this.CustomWordsCheckBox.Name = "CustomWordsCheckBox";
            this.CustomWordsCheckBox.Size = new System.Drawing.Size(141, 17);
            this.CustomWordsCheckBox.TabIndex = 2;
            this.CustomWordsCheckBox.Text = "Use Custom Words Only";
            this.CustomWordsCheckBox.UseVisualStyleBackColor = true;
            this.CustomWordsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(53, 44);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(346, 51);
            this.Title.TabIndex = 5;
            this.Title.Text = "HANGMAN GAME";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Hangman_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 492);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CustomWordsCheckBox);
            this.Controls.Add(this.AddWordsBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Name = "Hangman_Game";
            this.Text = "Hangman Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button AddWordsBtn;
        private System.Windows.Forms.CheckBox CustomWordsCheckBox;
        private System.Windows.Forms.Label Title;
    }
}

