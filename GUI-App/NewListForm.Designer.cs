namespace GUI_App
{
    partial class NewListForm
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
            this.languagesToBeAddedBox = new System.Windows.Forms.ListBox();
            this.addWordsButton = new System.Windows.Forms.Button();
            this.userInputLanguageBox = new System.Windows.Forms.TextBox();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.removeLanguageButton = new System.Windows.Forms.Button();
            this.nameOfFileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // languagesToBeAddedBox
            // 
            this.languagesToBeAddedBox.FormattingEnabled = true;
            this.languagesToBeAddedBox.ItemHeight = 15;
            this.languagesToBeAddedBox.Location = new System.Drawing.Point(12, 102);
            this.languagesToBeAddedBox.Name = "languagesToBeAddedBox";
            this.languagesToBeAddedBox.Size = new System.Drawing.Size(107, 109);
            this.languagesToBeAddedBox.TabIndex = 0;
            // 
            // addWordsButton
            // 
            this.addWordsButton.Location = new System.Drawing.Point(12, 217);
            this.addWordsButton.Name = "addWordsButton";
            this.addWordsButton.Size = new System.Drawing.Size(213, 37);
            this.addWordsButton.TabIndex = 1;
            this.addWordsButton.Text = "Add Words...";
            this.addWordsButton.UseVisualStyleBackColor = true;
            this.addWordsButton.Click += new System.EventHandler(this.addWordsButton_Click);
            // 
            // userInputLanguageBox
            // 
            this.userInputLanguageBox.Location = new System.Drawing.Point(12, 73);
            this.userInputLanguageBox.Name = "userInputLanguageBox";
            this.userInputLanguageBox.PlaceholderText = "Write the language...";
            this.userInputLanguageBox.Size = new System.Drawing.Size(107, 23);
            this.userInputLanguageBox.TabIndex = 2;
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Location = new System.Drawing.Point(125, 72);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(97, 23);
            this.addLanguageButton.TabIndex = 3;
            this.addLanguageButton.Text = "Add Language";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // removeLanguageButton
            // 
            this.removeLanguageButton.Location = new System.Drawing.Point(125, 102);
            this.removeLanguageButton.Name = "removeLanguageButton";
            this.removeLanguageButton.Size = new System.Drawing.Size(97, 36);
            this.removeLanguageButton.TabIndex = 4;
            this.removeLanguageButton.Text = "Remove";
            this.removeLanguageButton.UseVisualStyleBackColor = true;
            this.removeLanguageButton.Click += new System.EventHandler(this.removeLanguageButton_Click);
            // 
            // nameOfFileBox
            // 
            this.nameOfFileBox.Location = new System.Drawing.Point(63, 16);
            this.nameOfFileBox.Name = "nameOfFileBox";
            this.nameOfFileBox.PlaceholderText = "Name of the file..";
            this.nameOfFileBox.Size = new System.Drawing.Size(155, 23);
            this.nameOfFileBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name: ";
            // 
            // NewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameOfFileBox);
            this.Controls.Add(this.removeLanguageButton);
            this.Controls.Add(this.addLanguageButton);
            this.Controls.Add(this.userInputLanguageBox);
            this.Controls.Add(this.addWordsButton);
            this.Controls.Add(this.languagesToBeAddedBox);
            this.MaximizeBox = false;
            this.Name = "NewListForm";
            this.Text = "New language list";
            this.Load += new System.EventHandler(this.NewListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox languagesToBeAddedBox;
        private Button addWordsButton;
        private TextBox userInputLanguageBox;
        private Button addLanguageButton;
        private Button removeLanguageButton;
        private TextBox nameOfFileBox;
        private Label label1;
    }
}