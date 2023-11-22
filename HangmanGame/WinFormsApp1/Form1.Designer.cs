namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuBTN = new Button();
            label1 = new Label();
            EditWordsBTN = new Button();
            listView1 = new ListView();
            Removebutton = new Button();
            addTextBox = new TextBox();
            SuspendLayout();
            // 
            // MenuBTN
            // 
            MenuBTN.Location = new Point(1109, 606);
            MenuBTN.Name = "MenuBTN";
            MenuBTN.Size = new Size(219, 46);
            MenuBTN.TabIndex = 0;
            MenuBTN.Text = "Return to Menu";
            MenuBTN.UseVisualStyleBackColor = true;
            MenuBTN.Click += MenuBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(606, 76);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 3;
            label1.Text = "Your Words";
            // 
            // EditWordsBTN
            // 
            EditWordsBTN.Location = new Point(333, 596);
            EditWordsBTN.Name = "EditWordsBTN";
            EditWordsBTN.Size = new Size(264, 46);
            EditWordsBTN.TabIndex = 4;
            EditWordsBTN.Text = "Add Words";
            EditWordsBTN.UseVisualStyleBackColor = true;
            EditWordsBTN.Click += EditWordsBTN_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(1007, 616);
            listView1.Name = "listView1";
            listView1.Size = new Size(10, 10);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Removebutton
            // 
            Removebutton.Location = new Point(27, 606);
            Removebutton.Name = "Removebutton";
            Removebutton.Size = new Size(198, 46);
            Removebutton.TabIndex = 7;
            Removebutton.Text = "Remove Word";
            Removebutton.UseVisualStyleBackColor = true;
            Removebutton.Click += Removebutton_Click;
            // 
            // addTextBox
            // 
            addTextBox.Location = new Point(642, 600);
            addTextBox.Name = "addTextBox";
            addTextBox.Size = new Size(200, 39);
            addTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 664);
            Controls.Add(addTextBox);
            Controls.Add(Removebutton);
            Controls.Add(EditWordsBTN);
            Controls.Add(label1);
            Controls.Add(MenuBTN);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MenuBTN;
        private Label label1;
        private Button EditWordsBTN;
        private ListView listView1;
        private Button Removebutton;
        private TextBox addTextBox;
    }
}