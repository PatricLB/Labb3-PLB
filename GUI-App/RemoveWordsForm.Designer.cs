namespace GUI_App
{
    partial class RemoveWordsForm
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
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.checkedWordsListBox = new System.Windows.Forms.CheckedListBox();
            this.removeWordsButton = new System.Windows.Forms.Button();
            this.saveListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(67, 17);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(176, 23);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // checkedWordsListBox
            // 
            this.checkedWordsListBox.FormattingEnabled = true;
            this.checkedWordsListBox.Location = new System.Drawing.Point(16, 59);
            this.checkedWordsListBox.Name = "checkedWordsListBox";
            this.checkedWordsListBox.ScrollAlwaysVisible = true;
            this.checkedWordsListBox.Size = new System.Drawing.Size(227, 148);
            this.checkedWordsListBox.TabIndex = 2;
            // 
            // removeWordsButton
            // 
            this.removeWordsButton.Location = new System.Drawing.Point(19, 213);
            this.removeWordsButton.Name = "removeWordsButton";
            this.removeWordsButton.Size = new System.Drawing.Size(110, 23);
            this.removeWordsButton.TabIndex = 3;
            this.removeWordsButton.Text = "Remove Selected";
            this.removeWordsButton.UseVisualStyleBackColor = true;
            this.removeWordsButton.Click += new System.EventHandler(this.removeWordsButton_Click);
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(157, 213);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(86, 23);
            this.saveListButton.TabIndex = 4;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // RemoveWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 246);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.removeWordsButton);
            this.Controls.Add(this.checkedWordsListBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RemoveWordsForm";
            this.Text = "RemoveWordsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox fileNameTextBox;
        private CheckedListBox checkedWordsListBox;
        private Button removeWordsButton;
        private Button saveListButton;
    }
}