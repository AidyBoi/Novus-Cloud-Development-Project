namespace Hangman_Game
{
    partial class Entrypoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrypoint));
            this.title = new System.Windows.Forms.Label();
            this.play_button = new System.Windows.Forms.Button();
            this.wordlist_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(430, 64);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(420, 57);
            this.title.TabIndex = 0;
            this.title.Text = "HANGMAN GAME";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // play_button
            // 
            this.play_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Font = new System.Drawing.Font("Rubik SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.ForeColor = System.Drawing.Color.Black;
            this.play_button.Location = new System.Drawing.Point(537, 256);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(206, 60);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "PLAY";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // wordlist_button
            // 
            this.wordlist_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wordlist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordlist_button.Font = new System.Drawing.Font("Rubik SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlist_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.wordlist_button.Location = new System.Drawing.Point(550, 364);
            this.wordlist_button.Name = "wordlist_button";
            this.wordlist_button.Size = new System.Drawing.Size(180, 55);
            this.wordlist_button.TabIndex = 2;
            this.wordlist_button.Text = "WORDLIST";
            this.wordlist_button.UseVisualStyleBackColor = true;
            this.wordlist_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Entrypoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.wordlist_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrypoint";
            this.Text = "Hangman - Main Menu";
            this.Load += new System.EventHandler(this.Entrypoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button wordlist_button;
    }
}