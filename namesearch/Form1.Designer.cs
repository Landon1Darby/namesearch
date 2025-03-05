namespace namesearch
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
            label1 = new Label();
            answerLabel = new Label();
            InputTextBox = new TextBox();
            searchButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // answerLabel
            // 
            answerLabel.BorderStyle = BorderStyle.FixedSingle;
            answerLabel.Location = new Point(86, 85);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(204, 51);
            answerLabel.TabIndex = 1;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(165, 42);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(125, 27);
            InputTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(86, 152);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(210, 152);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 213);
            Controls.Add(exitButton);
            Controls.Add(searchButton);
            Controls.Add(InputTextBox);
            Controls.Add(answerLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label answerLabel;
        private TextBox InputTextBox;
        private Button searchButton;
        private Button exitButton;
    }
}
