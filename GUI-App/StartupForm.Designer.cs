namespace GUI_App
{
    partial class StartupForm
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
            this.Listor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripNewList = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listContentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.trainWordsButton = new System.Windows.Forms.Button();
            this.addWordsButton = new System.Windows.Forms.Button();
            this.removeWordsButton = new System.Windows.Forms.Button();
            this.languageSortBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listor
            // 
            this.Listor.AutoSize = true;
            this.Listor.Location = new System.Drawing.Point(62, 24);
            this.Listor.Name = "Listor";
            this.Listor.Size = new System.Drawing.Size(36, 15);
            this.Listor.TabIndex = 1;
            this.Listor.Text = "Listor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripNewList,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripNewList
            // 
            this.openToolStripNewList.Name = "openToolStripNewList";
            this.openToolStripNewList.Size = new System.Drawing.Size(116, 22);
            this.openToolStripNewList.Text = "New list";
            this.openToolStripNewList.Click += new System.EventHandler(this.openToolStripNewList_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // listContentTextBox
            // 
            this.listContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listContentTextBox.Location = new System.Drawing.Point(195, 59);
            this.listContentTextBox.Multiline = true;
            this.listContentTextBox.Name = "listContentTextBox";
            this.listContentTextBox.ReadOnly = true;
            this.listContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listContentTextBox.Size = new System.Drawing.Size(437, 347);
            this.listContentTextBox.TabIndex = 4;
            this.listContentTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ord";
            // 
            // wordListBox
            // 
            this.wordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 15;
            this.wordListBox.Location = new System.Drawing.Point(12, 57);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(160, 334);
            this.wordListBox.TabIndex = 6;
            this.wordListBox.SelectedIndexChanged += new System.EventHandler(this.wordListBox_SelectedIndexChanged);
            // 
            // trainWordsButton
            // 
            this.trainWordsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainWordsButton.Location = new System.Drawing.Point(651, 191);
            this.trainWordsButton.Name = "trainWordsButton";
            this.trainWordsButton.Size = new System.Drawing.Size(95, 68);
            this.trainWordsButton.TabIndex = 7;
            this.trainWordsButton.Text = "Train words";
            this.trainWordsButton.UseVisualStyleBackColor = true;
            this.trainWordsButton.Click += new System.EventHandler(this.trainWordsButton_Click);
            // 
            // addWordsButton
            // 
            this.addWordsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWordsButton.Location = new System.Drawing.Point(651, 59);
            this.addWordsButton.Name = "addWordsButton";
            this.addWordsButton.Size = new System.Drawing.Size(95, 23);
            this.addWordsButton.TabIndex = 8;
            this.addWordsButton.Text = "Add words ";
            this.addWordsButton.UseVisualStyleBackColor = true;
            this.addWordsButton.Click += new System.EventHandler(this.addWordsButton_Click);
            // 
            // removeWordsButton
            // 
            this.removeWordsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeWordsButton.Location = new System.Drawing.Point(651, 97);
            this.removeWordsButton.Name = "removeWordsButton";
            this.removeWordsButton.Size = new System.Drawing.Size(95, 23);
            this.removeWordsButton.TabIndex = 9;
            this.removeWordsButton.Text = "Remove Words";
            this.removeWordsButton.UseVisualStyleBackColor = true;
            this.removeWordsButton.Click += new System.EventHandler(this.removeWordsButton_Click);
            // 
            // languageSortBox
            // 
            this.languageSortBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.languageSortBox.FormattingEnabled = true;
            this.languageSortBox.ItemHeight = 15;
            this.languageSortBox.Location = new System.Drawing.Point(651, 306);
            this.languageSortBox.Name = "languageSortBox";
            this.languageSortBox.Size = new System.Drawing.Size(95, 79);
            this.languageSortBox.TabIndex = 10;
            this.languageSortBox.SelectedIndexChanged += new System.EventHandler(this.languageSortBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sort by...";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(547, 41);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(61, 15);
            this.countLabel.TabIndex = 12;
            this.countLabel.Text = "Antal Ord:";
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(758, 412);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.languageSortBox);
            this.Controls.Add(this.removeWordsButton);
            this.Controls.Add(this.addWordsButton);
            this.Controls.Add(this.trainWordsButton);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listContentTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Listor);
            this.MaximumSize = new System.Drawing.Size(848, 644);
            this.MinimumSize = new System.Drawing.Size(498, 444);
            this.Name = "StartupForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Listor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripNewList;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private TextBox listContentTextBox;
        private Label label1;
        private ListBox wordListBox;
        private Button trainWordsButton;
        private Button addWordsButton;
        private Button removeWordsButton;
        private ListBox languageSortBox;
        private Label label2;
        private Label countLabel;
    }
}