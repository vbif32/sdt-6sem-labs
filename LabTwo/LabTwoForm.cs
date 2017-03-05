using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LabTwo
{
    public partial class LabTwoForm : Form
    {
        public LabTwoForm()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> _words;

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                Filter = "Text Files|*.txt",
                Title = "Select a Text File"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            var filename = openFileDialog1.FileName;
            FilePathTextBox.Text = filename;
            RecognitionTextBox.Text = File.ReadAllText(filename);
        }

        private void FrequentWordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FrequentWordsCheckBox.Checked)
                BoldMostOftenWords();
        }

        private void FrequentWordsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (FrequentWordsCheckBox.Checked)
                BoldMostOftenWords();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            _words = PartOne.Split(RecognitionTextBox.Text);
            RecognizedRichTextBox.Text =
                    _words.Select(i => i.Key + " " + i.Value + "\r\n").Aggregate((accumulate, s) => accumulate + s);

            if (FrequentWordsCheckBox.Checked)
                BoldMostOftenWords();
        }

        private void BoldMostOftenWords()
        {
            int i;
            int.TryParse(FrequentWordsNumericUpDown.Text, out i);
            if (i > 0 && _words != null)
            {
                var tmp = PartTwo.MostOfterWords(_words, i);
            }
            //TODO: допилить выделение
        }

    }
}