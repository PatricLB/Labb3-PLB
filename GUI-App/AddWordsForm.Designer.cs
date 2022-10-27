namespace GUI_App
{
    partial class AddWordsForm
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
            this.languageTextBox1 = new System.Windows.Forms.TextBox();
            this.languageTextBox2 = new System.Windows.Forms.TextBox();
            this.saveListButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.languageTextBox3 = new System.Windows.Forms.TextBox();
            this.languageTextBox4 = new System.Windows.Forms.TextBox();
            this.addWordsButton = new System.Windows.Forms.Button();
            this.languageLabel1 = new System.Windows.Forms.Label();
            this.languageLabel2 = new System.Windows.Forms.Label();
            this.languageLabel3 = new System.Windows.Forms.Label();
            this.languageLabel4 = new System.Windows.Forms.Label();
            this.addedWordsListBox = new System.Windows.Forms.ListBox();
            this.removeWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageTextBox1
            // 
            this.languageTextBox1.Location = new System.Drawing.Point(97, 12);
            this.languageTextBox1.Name = "languageTextBox1";
            this.languageTextBox1.Size = new System.Drawing.Size(111, 23);
            this.languageTextBox1.TabIndex = 2;
            // 
            // languageTextBox2
            // 
            this.languageTextBox2.Location = new System.Drawing.Point(97, 41);
            this.languageTextBox2.Name = "languageTextBox2";
            this.languageTextBox2.Size = new System.Drawing.Size(111, 23);
            this.languageTextBox2.TabIndex = 3;
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(360, 131);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(75, 23);
            this.saveListButton.TabIndex = 5;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Added words";
            // 
            // languageTextBox3
            // 
            this.languageTextBox3.Location = new System.Drawing.Point(97, 70);
            this.languageTextBox3.Name = "languageTextBox3";
            this.languageTextBox3.Size = new System.Drawing.Size(111, 23);
            this.languageTextBox3.TabIndex = 8;
            // 
            // languageTextBox4
            // 
            this.languageTextBox4.Location = new System.Drawing.Point(97, 102);
            this.languageTextBox4.Name = "languageTextBox4";
            this.languageTextBox4.Size = new System.Drawing.Size(111, 23);
            this.languageTextBox4.TabIndex = 10;
            // 
            // addWordsButton
            // 
            this.addWordsButton.Location = new System.Drawing.Point(115, 131);
            this.addWordsButton.Name = "addWordsButton";
            this.addWordsButton.Size = new System.Drawing.Size(75, 23);
            this.addWordsButton.TabIndex = 11;
            this.addWordsButton.Text = "Add words";
            this.addWordsButton.UseVisualStyleBackColor = true;
            this.addWordsButton.Click += new System.EventHandler(this.addWordsButton_Click);
            // 
            // languageLabel1
            // 
            this.languageLabel1.AutoSize = true;
            this.languageLabel1.Location = new System.Drawing.Point(12, 15);
            this.languageLabel1.Name = "languageLabel1";
            this.languageLabel1.Size = new System.Drawing.Size(65, 15);
            this.languageLabel1.TabIndex = 12;
            this.languageLabel1.Text = "language 1";
            // 
            // languageLabel2
            // 
            this.languageLabel2.AutoSize = true;
            this.languageLabel2.Location = new System.Drawing.Point(12, 44);
            this.languageLabel2.Name = "languageLabel2";
            this.languageLabel2.Size = new System.Drawing.Size(65, 15);
            this.languageLabel2.TabIndex = 13;
            this.languageLabel2.Text = "language 2";
            // 
            // languageLabel3
            // 
            this.languageLabel3.AutoSize = true;
            this.languageLabel3.Location = new System.Drawing.Point(12, 73);
            this.languageLabel3.Name = "languageLabel3";
            this.languageLabel3.Size = new System.Drawing.Size(65, 15);
            this.languageLabel3.TabIndex = 14;
            this.languageLabel3.Text = "language 3";
            // 
            // languageLabel4
            // 
            this.languageLabel4.AutoSize = true;
            this.languageLabel4.Location = new System.Drawing.Point(12, 105);
            this.languageLabel4.Name = "languageLabel4";
            this.languageLabel4.Size = new System.Drawing.Size(65, 15);
            this.languageLabel4.TabIndex = 15;
            this.languageLabel4.Text = "language 4";
            // 
            // addedWordsListBox
            // 
            this.addedWordsListBox.FormattingEnabled = true;
            this.addedWordsListBox.ItemHeight = 15;
            this.addedWordsListBox.Location = new System.Drawing.Point(261, 22);
            this.addedWordsListBox.Name = "addedWordsListBox";
            this.addedWordsListBox.ScrollAlwaysVisible = true;
            this.addedWordsListBox.Size = new System.Drawing.Size(171, 94);
            this.addedWordsListBox.TabIndex = 16;
            // 
            // removeWordButton
            // 
            this.removeWordButton.Location = new System.Drawing.Point(261, 131);
            this.removeWordButton.Name = "removeWordButton";
            this.removeWordButton.Size = new System.Drawing.Size(75, 23);
            this.removeWordButton.TabIndex = 17;
            this.removeWordButton.Text = "Remove";
            this.removeWordButton.UseVisualStyleBackColor = true;
            this.removeWordButton.Click += new System.EventHandler(this.removeWordButton_Click);
            // 
            // AddWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 163);
            this.Controls.Add(this.removeWordButton);
            this.Controls.Add(this.addedWordsListBox);
            this.Controls.Add(this.languageLabel4);
            this.Controls.Add(this.languageLabel3);
            this.Controls.Add(this.languageLabel2);
            this.Controls.Add(this.languageLabel1);
            this.Controls.Add(this.addWordsButton);
            this.Controls.Add(this.languageTextBox4);
            this.Controls.Add(this.languageTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.languageTextBox2);
            this.Controls.Add(this.languageTextBox1);
            this.Name = "AddWordsForm";
            this.Text = "AddWordsTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox languageTextBox1;
        private TextBox languageTextBox2;
        private Button saveListButton;
        private Label label3;
        private TextBox languageTextBox3;
        private TextBox languageTextBox4;
        private Button addWordsButton;
        private Label languageLabel1;
        private Label languageLabel2;
        private Label languageLabel3;
        private Label languageLabel4;
        private ListBox addedWordsListBox;
        private Button removeWordButton;
    }
}