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
            this.listView2 = new System.Windows.Forms.ListView();
            this.toMenu = new System.Windows.Forms.Button();
            this.resetWordlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(544, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "WORDLIST";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditWordsBTN
            // 
            this.EditWordsBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditWordsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.EditWordsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditWordsBTN.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.EditWordsBTN.ForeColor = System.Drawing.Color.Black;
            this.EditWordsBTN.Location = new System.Drawing.Point(255, 334);
            this.EditWordsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.EditWordsBTN.Name = "EditWordsBTN";
            this.EditWordsBTN.Size = new System.Drawing.Size(130, 40);
            this.EditWordsBTN.TabIndex = 2;
            this.EditWordsBTN.Text = "Add Word";
            this.EditWordsBTN.UseVisualStyleBackColor = false;
            this.EditWordsBTN.Click += new System.EventHandler(this.EditWordsBTN_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.Removebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removebutton.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(895, 460);
            this.Removebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(130, 40);
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
            this.listView1.Location = new System.Drawing.Point(82, 82);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(11, 9);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addTextBox
            // 
            this.addTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTextBox.Font = new System.Drawing.Font("Rubik SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextBox.Location = new System.Drawing.Point(230, 241);
            this.addTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(180, 25);
            this.addTextBox.TabIndex = 5;
            this.addTextBox.TextChanged += new System.EventHandler(this.addTextBox_TextChanged);
            // 
            // listView2
            // 
            this.listView2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Font = new System.Drawing.Font("Rubik SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(730, 128);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(451, 313);
            this.listView2.TabIndex = 6;
            this.listView2.TileSize = new System.Drawing.Size(420, 22);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
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
            this.toMenu.TabIndex = 8;
            this.toMenu.Text = "Menu";
            this.toMenu.UseVisualStyleBackColor = true;
            this.toMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // resetWordlist
            // 
            this.resetWordlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetWordlist.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetWordlist.ForeColor = System.Drawing.Color.White;
            this.resetWordlist.Location = new System.Drawing.Point(1156, 18);
            this.resetWordlist.Name = "resetWordlist";
            this.resetWordlist.Size = new System.Drawing.Size(96, 34);
            this.resetWordlist.TabIndex = 7;
            this.resetWordlist.Text = "Reset";
            this.resetWordlist.UseVisualStyleBackColor = true;
            this.resetWordlist.Click += new System.EventHandler(this.resetWordlist_Click);
            // 
            // WordSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toMenu);
            this.Controls.Add(this.resetWordlist);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.EditWordsBTN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WordSelection";
            this.Text = "WordSelection";
            this.Load += new System.EventHandler(this.WordSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditWordsBTN;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button toMenu;
        private System.Windows.Forms.Button resetWordlist;
    }
}