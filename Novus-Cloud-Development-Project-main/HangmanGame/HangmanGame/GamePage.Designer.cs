namespace Hangman_Game
{
    partial class GamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.txtWordFill = new System.Windows.Forms.Label();
            this.button_grid = new System.Windows.Forms.FlowLayoutPanel();
            this.guessCount = new System.Windows.Forms.Label();
            this.numGuesses = new System.Windows.Forms.Label();
            this.resetGame = new System.Windows.Forms.Button();
            this.toMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWordFill
            // 
            this.txtWordFill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWordFill.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordFill.ForeColor = System.Drawing.Color.White;
            this.txtWordFill.Location = new System.Drawing.Point(370, 320);
            this.txtWordFill.Name = "txtWordFill";
            this.txtWordFill.Size = new System.Drawing.Size(540, 71);
            this.txtWordFill.TabIndex = 0;
            this.txtWordFill.Text = "Loading...";
            this.txtWordFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_grid
            // 
            this.button_grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_grid.Location = new System.Drawing.Point(256, 432);
            this.button_grid.Name = "button_grid";
            this.button_grid.Size = new System.Drawing.Size(768, 228);
            this.button_grid.TabIndex = 1;
            // 
            // guessCount
            // 
            this.guessCount.AutoSize = true;
            this.guessCount.Font = new System.Drawing.Font("Rubik SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessCount.ForeColor = System.Drawing.Color.White;
            this.guessCount.Location = new System.Drawing.Point(9, 9);
            this.guessCount.Name = "guessCount";
            this.guessCount.Size = new System.Drawing.Size(305, 45);
            this.guessCount.TabIndex = 2;
            this.guessCount.Text = "Guesses Remaining:";
            // 
            // numGuesses
            // 
            this.numGuesses.AutoSize = true;
            this.numGuesses.Font = new System.Drawing.Font("Rubik SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGuesses.ForeColor = System.Drawing.Color.White;
            this.numGuesses.Location = new System.Drawing.Point(306, 9);
            this.numGuesses.Name = "numGuesses";
            this.numGuesses.Size = new System.Drawing.Size(38, 45);
            this.numGuesses.TabIndex = 3;
            this.numGuesses.Text = "5";
            this.numGuesses.Click += new System.EventHandler(this.numGuesses_Click);
            // 
            // resetGame
            // 
            this.resetGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetGame.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGame.ForeColor = System.Drawing.Color.White;
            this.resetGame.Location = new System.Drawing.Point(1156, 18);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(96, 34);
            this.resetGame.TabIndex = 4;
            this.resetGame.Text = "Restart";
            this.resetGame.UseVisualStyleBackColor = true;
            this.resetGame.Click += new System.EventHandler(this.ResetGame_Click);
            // 
            // toMenu
            // 
            this.toMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toMenu.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMenu.ForeColor = System.Drawing.Color.White;
            this.toMenu.Location = new System.Drawing.Point(1054, 18);
            this.toMenu.Name = "toMenu";
            this.toMenu.Size = new System.Drawing.Size(96, 34);
            this.toMenu.TabIndex = 5;
            this.toMenu.Text = "Menu";
            this.toMenu.UseVisualStyleBackColor = true;
            this.toMenu.Click += new System.EventHandler(this.ToMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toMenu);
            this.Controls.Add(this.resetGame);
            this.Controls.Add(this.numGuesses);
            this.Controls.Add(this.guessCount);
            this.Controls.Add(this.button_grid);
            this.Controls.Add(this.txtWordFill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamePage";
            this.Text = "Hangman - Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWordFill;
        private System.Windows.Forms.FlowLayoutPanel button_grid;
        private System.Windows.Forms.Label guessCount;
        private System.Windows.Forms.Label numGuesses;
        private System.Windows.Forms.Button resetGame;
        private System.Windows.Forms.Button toMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

