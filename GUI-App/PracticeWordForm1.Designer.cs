namespace GUI_App
{
    partial class PracticeWordForm
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
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.labelFromLang = new System.Windows.Forms.Label();
            this.labelToLang = new System.Windows.Forms.Label();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.randomWordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(144, 252);
            this.userAnswerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(171, 31);
            this.userAnswerTextBox.TabIndex = 0;
            this.userAnswerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userAnswerTextBox_KeyDown);
            // 
            // labelFromLang
            // 
            this.labelFromLang.AutoSize = true;
            this.labelFromLang.Location = new System.Drawing.Point(17, 130);
            this.labelFromLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFromLang.Name = "labelFromLang";
            this.labelFromLang.Size = new System.Drawing.Size(58, 25);
            this.labelFromLang.TabIndex = 1;
            this.labelFromLang.Text = "From:";
            // 
            // labelToLang
            // 
            this.labelToLang.AutoSize = true;
            this.labelToLang.Location = new System.Drawing.Point(36, 180);
            this.labelToLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToLang.Name = "labelToLang";
            this.labelToLang.Size = new System.Drawing.Size(39, 25);
            this.labelToLang.TabIndex = 3;
            this.labelToLang.Text = "To: ";
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.Location = new System.Drawing.Point(174, 300);
            this.submitAnswerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(107, 38);
            this.submitAnswerButton.TabIndex = 4;
            this.submitAnswerButton.Text = "Submit";
            this.submitAnswerButton.UseVisualStyleBackColor = true;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your answer: ";
            // 
            // randomWordTextBox
            // 
            this.randomWordTextBox.Location = new System.Drawing.Point(144, 48);
            this.randomWordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randomWordTextBox.Name = "randomWordTextBox";
            this.randomWordTextBox.ReadOnly = true;
            this.randomWordTextBox.Size = new System.Drawing.Size(171, 31);
            this.randomWordTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Translate: ";
            // 
            // PracticeWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomWordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.labelToLang);
            this.Controls.Add(this.labelFromLang);
            this.Controls.Add(this.userAnswerTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PracticeWordForm";
            this.Text = "Word Practice!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PracticeWordForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userAnswerTextBox;
        private Label labelFromLang;
        private Label labelToLang;
        private Button submitAnswerButton;
        private Label label3;
        private TextBox randomWordTextBox;
        private Label label1;
    }
}