namespace LabFour
{
    partial class LabFourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabFourForm));
            this.RecognitionTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.FindedWordsGroupBox = new System.Windows.Forms.GroupBox();
            this.RecognizedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.InputGroupBox.SuspendLayout();
            this.FindedWordsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecognitionTextBox
            // 
            this.RecognitionTextBox.Location = new System.Drawing.Point(6, 19);
            this.RecognitionTextBox.Multiline = true;
            this.RecognitionTextBox.Name = "RecognitionTextBox";
            this.RecognitionTextBox.Size = new System.Drawing.Size(338, 185);
            this.RecognitionTextBox.TabIndex = 0;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(368, 10);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(123, 23);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Открыть файл...";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 12);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(350, 20);
            this.FilePathTextBox.TabIndex = 3;
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.RecognitionTextBox);
            this.InputGroupBox.Location = new System.Drawing.Point(12, 39);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(350, 210);
            this.InputGroupBox.TabIndex = 4;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Текст для распознования";
            // 
            // FindedWordsGroupBox
            // 
            this.FindedWordsGroupBox.Controls.Add(this.RecognizedRichTextBox);
            this.FindedWordsGroupBox.Location = new System.Drawing.Point(368, 39);
            this.FindedWordsGroupBox.Name = "FindedWordsGroupBox";
            this.FindedWordsGroupBox.Size = new System.Drawing.Size(252, 210);
            this.FindedWordsGroupBox.TabIndex = 5;
            this.FindedWordsGroupBox.TabStop = false;
            this.FindedWordsGroupBox.Text = "Найденные слова";
            // 
            // RecognizedRichTextBox
            // 
            this.RecognizedRichTextBox.Location = new System.Drawing.Point(6, 18);
            this.RecognizedRichTextBox.Name = "RecognizedRichTextBox";
            this.RecognizedRichTextBox.ReadOnly = true;
            this.RecognizedRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RecognizedRichTextBox.Size = new System.Drawing.Size(240, 185);
            this.RecognizedRichTextBox.TabIndex = 1;
            this.RecognizedRichTextBox.Text = "";
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(497, 10);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(123, 23);
            this.CountButton.TabIndex = 6;
            this.CountButton.Text = "Посчитать слова";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // LabFourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 254);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.FindedWordsGroupBox);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.InputGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabFourForm";
            this.Text = "Четвертая лабораторная работа";
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.FindedWordsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecognitionTextBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.GroupBox FindedWordsGroupBox;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.RichTextBox RecognizedRichTextBox;
    }
}

