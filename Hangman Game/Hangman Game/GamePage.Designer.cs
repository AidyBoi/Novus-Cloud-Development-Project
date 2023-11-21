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
            this.txtWordFill = new System.Windows.Forms.Label();
            this.alphaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guessCount = new System.Windows.Forms.Label();
            this.numGuesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWordFill
            // 
            this.txtWordFill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtWordFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordFill.Location = new System.Drawing.Point(37, 375);
            this.txtWordFill.Name = "txtWordFill";
            this.txtWordFill.Size = new System.Drawing.Size(540, 48);
            this.txtWordFill.TabIndex = 0;
            this.txtWordFill.Text = "txtWordFill";
            // 
            // alphaPanel
            // 
            this.alphaPanel.Location = new System.Drawing.Point(12, 256);
            this.alphaPanel.Name = "alphaPanel";
            this.alphaPanel.Size = new System.Drawing.Size(622, 116);
            this.alphaPanel.TabIndex = 1;
            // 
            // guessCount
            // 
            this.guessCount.AutoSize = true;
            this.guessCount.Location = new System.Drawing.Point(12, 75);
            this.guessCount.Name = "guessCount";
            this.guessCount.Size = new System.Drawing.Size(104, 13);
            this.guessCount.TabIndex = 2;
            this.guessCount.Text = "Guesses Remaining:";
            // 
            // numGuesses
            // 
            this.numGuesses.AutoSize = true;
            this.numGuesses.Location = new System.Drawing.Point(122, 75);
            this.numGuesses.Name = "numGuesses";
            this.numGuesses.Size = new System.Drawing.Size(13, 13);
            this.numGuesses.TabIndex = 3;
            this.numGuesses.Text = "5";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numGuesses);
            this.Controls.Add(this.guessCount);
            this.Controls.Add(this.alphaPanel);
            this.Controls.Add(this.txtWordFill);
            this.Name = "GamePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWordFill;
        private System.Windows.Forms.FlowLayoutPanel alphaPanel;
        private System.Windows.Forms.Label guessCount;
        private System.Windows.Forms.Label numGuesses;
    }
}

