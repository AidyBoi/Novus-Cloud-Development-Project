namespace Hangman_Game
{
    partial class WordSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.EditWordsBTN = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1131, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOUR WORDS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditWordsBTN
            // 
            this.EditWordsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.EditWordsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EditWordsBTN.ForeColor = System.Drawing.Color.Black;
            this.EditWordsBTN.Location = new System.Drawing.Point(539, 818);
            this.EditWordsBTN.Name = "EditWordsBTN";
            this.EditWordsBTN.Size = new System.Drawing.Size(259, 75);
            this.EditWordsBTN.TabIndex = 2;
            this.EditWordsBTN.Text = "Add Word";
            this.EditWordsBTN.UseVisualStyleBackColor = false;
            this.EditWordsBTN.Click += new System.EventHandler(this.EditWordsBTN_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.Removebutton.Location = new System.Drawing.Point(501, 457);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(259, 79);
            this.Removebutton.TabIndex = 3;
            this.Removebutton.Text = "Remove Word";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(163, 157);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(22, 17);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(539, 764);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(355, 31);
            this.addTextBox.TabIndex = 5;
            // 
            // WordSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(2528, 1310);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.EditWordsBTN);
            this.Controls.Add(this.label1);
            this.Name = "WordSelection";
            this.Text = "WordSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditWordsBTN;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox addTextBox;
    }
}