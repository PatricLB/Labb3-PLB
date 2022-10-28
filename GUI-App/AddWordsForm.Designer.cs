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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // languageTextBox1
            // 
            this.languageTextBox1.Location = new System.Drawing.Point(495, 287);
            this.languageTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageTextBox1.Name = "languageTextBox1";
            this.languageTextBox1.Size = new System.Drawing.Size(157, 31);
            this.languageTextBox1.TabIndex = 1;
            this.languageTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.languageTextBox1_KeyDown);
            // 
            // languageTextBox2
            // 
            this.languageTextBox2.Location = new System.Drawing.Point(495, 335);
            this.languageTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageTextBox2.Name = "languageTextBox2";
            this.languageTextBox2.Size = new System.Drawing.Size(157, 31);
            this.languageTextBox2.TabIndex = 2;
            this.languageTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.languageTextBox2_KeyDown);
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(514, 218);
            this.saveListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(107, 38);
            this.saveListButton.TabIndex = 8;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Added words";
            // 
            // languageTextBox3
            // 
            this.languageTextBox3.Location = new System.Drawing.Point(495, 384);
            this.languageTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageTextBox3.Name = "languageTextBox3";
            this.languageTextBox3.Size = new System.Drawing.Size(157, 31);
            this.languageTextBox3.TabIndex = 3;
            // 
            // languageTextBox4
            // 
            this.languageTextBox4.Location = new System.Drawing.Point(495, 437);
            this.languageTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageTextBox4.Name = "languageTextBox4";
            this.languageTextBox4.Size = new System.Drawing.Size(157, 31);
            this.languageTextBox4.TabIndex = 4;
            // 
            // addWordsButton
            // 
            this.addWordsButton.Location = new System.Drawing.Point(515, 494);
            this.addWordsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWordsButton.Name = "addWordsButton";
            this.addWordsButton.Size = new System.Drawing.Size(110, 38);
            this.addWordsButton.TabIndex = 5;
            this.addWordsButton.Text = "Add words";
            this.addWordsButton.UseVisualStyleBackColor = true;
            this.addWordsButton.Click += new System.EventHandler(this.addWordsButton_Click);
            // 
            // languageLabel1
            // 
            this.languageLabel1.AutoSize = true;
            this.languageLabel1.Location = new System.Drawing.Point(373, 292);
            this.languageLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel1.Name = "languageLabel1";
            this.languageLabel1.Size = new System.Drawing.Size(100, 25);
            this.languageLabel1.TabIndex = 12;
            this.languageLabel1.Text = "language 1";
            // 
            // languageLabel2
            // 
            this.languageLabel2.AutoSize = true;
            this.languageLabel2.Location = new System.Drawing.Point(373, 340);
            this.languageLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel2.Name = "languageLabel2";
            this.languageLabel2.Size = new System.Drawing.Size(100, 25);
            this.languageLabel2.TabIndex = 13;
            this.languageLabel2.Text = "language 2";
            // 
            // languageLabel3
            // 
            this.languageLabel3.AutoSize = true;
            this.languageLabel3.Location = new System.Drawing.Point(373, 389);
            this.languageLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel3.Name = "languageLabel3";
            this.languageLabel3.Size = new System.Drawing.Size(100, 25);
            this.languageLabel3.TabIndex = 14;
            this.languageLabel3.Text = "language 3";
            // 
            // languageLabel4
            // 
            this.languageLabel4.AutoSize = true;
            this.languageLabel4.Location = new System.Drawing.Point(373, 442);
            this.languageLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel4.Name = "languageLabel4";
            this.languageLabel4.Size = new System.Drawing.Size(100, 25);
            this.languageLabel4.TabIndex = 15;
            this.languageLabel4.Text = "language 4";
            // 
            // addedWordsListBox
            // 
            this.addedWordsListBox.FormattingEnabled = true;
            this.addedWordsListBox.ItemHeight = 25;
            this.addedWordsListBox.Location = new System.Drawing.Point(373, 37);
            this.addedWordsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addedWordsListBox.Name = "addedWordsListBox";
            this.addedWordsListBox.ScrollAlwaysVisible = true;
            this.addedWordsListBox.Size = new System.Drawing.Size(243, 154);
            this.addedWordsListBox.TabIndex = 6;
            // 
            // removeWordButton
            // 
            this.removeWordButton.Location = new System.Drawing.Point(373, 218);
            this.removeWordButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeWordButton.Name = "removeWordButton";
            this.removeWordButton.Size = new System.Drawing.Size(107, 38);
            this.removeWordButton.TabIndex = 7;
            this.removeWordButton.Text = "Remove";
            this.removeWordButton.UseVisualStyleBackColor = true;
            this.removeWordButton.Click += new System.EventHandler(this.removeWordButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 184);
            this.panel1.TabIndex = 16;
            // 
            // AddWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 559);
            this.Controls.Add(this.panel1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private Panel panel1;
    }
}