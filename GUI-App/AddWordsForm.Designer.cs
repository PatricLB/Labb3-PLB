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
            this.saveListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveListButton.Location = new System.Drawing.Point(483, 174);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(80, 24);
            this.saveListButton.TabIndex = 8;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Added words";
            // 
            // addWordsButton
            // 
            this.addWordsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addWordsButton.Location = new System.Drawing.Point(79, 174);
            this.addWordsButton.Name = "addWordsButton";
            this.addWordsButton.Size = new System.Drawing.Size(77, 23);
            this.addWordsButton.TabIndex = 5;
            this.addWordsButton.Text = "Add words";
            this.addWordsButton.UseVisualStyleBackColor = true;
            this.addWordsButton.Click += new System.EventHandler(this.addWordsButton_Click);
            // 
            // addedWordsListBox
            // 
            this.addedWordsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addedWordsListBox.FormattingEnabled = true;
            this.addedWordsListBox.ItemHeight = 15;
            this.addedWordsListBox.Location = new System.Drawing.Point(389, 22);
            this.addedWordsListBox.Name = "addedWordsListBox";
            this.addedWordsListBox.ScrollAlwaysVisible = true;
            this.addedWordsListBox.Size = new System.Drawing.Size(171, 124);
            this.addedWordsListBox.TabIndex = 6;
            // 
            // removeWordButton
            // 
            this.removeWordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeWordButton.Location = new System.Drawing.Point(389, 174);
            this.removeWordButton.Name = "removeWordButton";
            this.removeWordButton.Size = new System.Drawing.Size(75, 23);
            this.removeWordButton.TabIndex = 7;
            this.removeWordButton.Text = "Remove";
            this.removeWordButton.UseVisualStyleBackColor = true;
            this.removeWordButton.Click += new System.EventHandler(this.removeWordButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 153);
            this.panel1.TabIndex = 16;
            // 
            // AddWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 206);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeWordButton);
            this.Controls.Add(this.addedWordsListBox);
            this.Controls.Add(this.addWordsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveListButton);
            this.Name = "AddWordsForm";
            this.Text = "AddWordsTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWordsForm_FormClosing);
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