namespace LabTwo
{
    partial class LabTwoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabTwoForm));
            this.RecognitionTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.FindedWordsGroupBox = new System.Windows.Forms.GroupBox();
            this.RecognizedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.FrequentWordsFirstLabel = new System.Windows.Forms.Label();
            this.FrequentWordsSecondLabel = new System.Windows.Forms.Label();
            this.FrequentWordsCheckBox = new System.Windows.Forms.CheckBox();
            this.FrequentWordsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InputGroupBox.SuspendLayout();
            this.FindedWordsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequentWordsNumericUpDown)).BeginInit();
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
            this.OpenFileButton.Size = new System.Drawing.Size(117, 23);
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
            this.FindedWordsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FindedWordsGroupBox.Controls.Add(this.RecognizedRichTextBox);
            this.FindedWordsGroupBox.Location = new System.Drawing.Point(368, 39);
            this.FindedWordsGroupBox.Name = "FindedWordsGroupBox";
            this.FindedWordsGroupBox.Size = new System.Drawing.Size(252, 210);
            this.FindedWordsGroupBox.TabIndex = 5;
            this.FindedWordsGroupBox.TabStop = false;
            this.FindedWordsGroupBox.Text = "Найденные слова";
            this.FindedWordsGroupBox.Enter += new System.EventHandler(this.FindedWordsGroupBox_Enter);
            // 
            // RecognizedRichTextBox
            // 
            this.RecognizedRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.RecognizedRichTextBox.Name = "RecognizedRichTextBox";
            this.RecognizedRichTextBox.ReadOnly = true;
            this.RecognizedRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RecognizedRichTextBox.Size = new System.Drawing.Size(240, 185);
            this.RecognizedRichTextBox.TabIndex = 1;
            this.RecognizedRichTextBox.Text = "";
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(545, 256);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 23);
            this.CountButton.TabIndex = 6;
            this.CountButton.Text = "Посчитать слова";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // FrequentWordsFirstLabel
            // 
            this.FrequentWordsFirstLabel.AutoSize = true;
            this.FrequentWordsFirstLabel.Location = new System.Drawing.Point(12, 260);
            this.FrequentWordsFirstLabel.Name = "FrequentWordsFirstLabel";
            this.FrequentWordsFirstLabel.Size = new System.Drawing.Size(57, 13);
            this.FrequentWordsFirstLabel.TabIndex = 7;
            this.FrequentWordsFirstLabel.Text = "Выделить";
            // 
            // FrequentWordsSecondLabel
            // 
            this.FrequentWordsSecondLabel.AutoSize = true;
            this.FrequentWordsSecondLabel.Location = new System.Drawing.Point(125, 261);
            this.FrequentWordsSecondLabel.Name = "FrequentWordsSecondLabel";
            this.FrequentWordsSecondLabel.Size = new System.Drawing.Size(105, 13);
            this.FrequentWordsSecondLabel.TabIndex = 8;
            this.FrequentWordsSecondLabel.Text = "самых частых слов";
            // 
            // FrequentWordsCheckBox
            // 
            this.FrequentWordsCheckBox.AutoSize = true;
            this.FrequentWordsCheckBox.Location = new System.Drawing.Point(236, 261);
            this.FrequentWordsCheckBox.Name = "FrequentWordsCheckBox";
            this.FrequentWordsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FrequentWordsCheckBox.TabIndex = 10;
            this.FrequentWordsCheckBox.UseVisualStyleBackColor = true;
            this.FrequentWordsCheckBox.CheckedChanged += new System.EventHandler(this.FrequentWordsCheckBox_CheckedChanged);
            // 
            // FrequentWordsNumericUpDown
            // 
            this.FrequentWordsNumericUpDown.Location = new System.Drawing.Point(75, 258);
            this.FrequentWordsNumericUpDown.Name = "FrequentWordsNumericUpDown";
            this.FrequentWordsNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.FrequentWordsNumericUpDown.TabIndex = 11;
            this.FrequentWordsNumericUpDown.ValueChanged += new System.EventHandler(this.FrequentWordsNumericUpDown_ValueChanged);
            // 
            // LabTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 289);
            this.Controls.Add(this.FrequentWordsNumericUpDown);
            this.Controls.Add(this.FrequentWordsCheckBox);
            this.Controls.Add(this.FrequentWordsSecondLabel);
            this.Controls.Add(this.FrequentWordsFirstLabel);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.FindedWordsGroupBox);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.InputGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabTwoForm";
            this.Text = "Вторая лабораторная работа";
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.FindedWordsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrequentWordsNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label FrequentWordsFirstLabel;
        private System.Windows.Forms.Label FrequentWordsSecondLabel;
        private System.Windows.Forms.CheckBox FrequentWordsCheckBox;
        private System.Windows.Forms.NumericUpDown FrequentWordsNumericUpDown;
        private System.Windows.Forms.RichTextBox RecognizedRichTextBox;
    }
}

