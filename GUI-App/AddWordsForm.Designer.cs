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
            this.saveListButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addWordsButton = new System.Windows.Forms.Button();
            this.addedWordsListBox = new System.Windows.Forms.ListBox();
            this.removeWordButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(507, 218);
            this.saveListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(114, 40);
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
            // addWordsButton
            // 
            this.addWordsButton.Location = new System.Drawing.Point(113, 218);
            this.addWordsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWordsButton.Name = "addWordsButton";
            this.addWordsButton.Size = new System.Drawing.Size(110, 38);
            this.addWordsButton.TabIndex = 5;
            this.addWordsButton.Text = "Add words";
            this.addWordsButton.UseVisualStyleBackColor = true;
            this.addWordsButton.Click += new System.EventHandler(this.addWordsButton_Click);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 184);
            this.panel1.TabIndex = 16;
            // 
            // AddWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeWordButton);
            this.Controls.Add(this.addedWordsListBox);
            this.Controls.Add(this.addWordsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveListButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddWordsForm";
            this.Text = "AddWordsTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button saveListButton;
        private Label label3;
        private Button addWordsButton;
        private ListBox addedWordsListBox;
        private Button removeWordButton;
        private Panel panel1;
    }
}