using System;
using System.Drawing;
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
                BoldFrequentWords();
        }

        private void FrequentWordsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (FrequentWordsCheckBox.Checked)
                BoldFrequentWords();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            var words = PartOne.Split(RecognitionTextBox.Text.Trim());
            // зачем писать свою сортировку, если можно использовать стандартную?
            words = words.OrderByDescending(i => i.Value);

            // Но если уж писать, то проверить её работоспосбность все равно стоит
            var keyValuePairs = words.ToList();
            PartTwo.BucketSort(ref keyValuePairs);

            RecognizedRichTextBox.Text =
                words.Select(i => i.Key + " " + i.Value + "\r\n").Aggregate((accumulate, s) => accumulate + s);

            if (FrequentWordsCheckBox.Checked)
                BoldFrequentWords();
        }

        private void BoldFrequentWords()
        {
            var rrtb = RecognizedRichTextBox;
            var count = decimal.ToInt32(FrequentWordsNumericUpDown.Value);
            if (rrtb.Lines.Length == 0) return;

            if (count > 0)
            {
                // выделяем
                var boldLength =
                    rrtb.Lines.Take(count).Select(i => i.Length).Aggregate((accumulate, s) => accumulate + s + 1);
                rrtb.SelectionStart = 0;
                rrtb.SelectionLength = boldLength;
                rrtb.SelectionFont = new Font(RecognizedRichTextBox.Font, FontStyle.Bold);

                if (count >= rrtb.Lines.Length) return;
            }

            // возвращаем обычный для следующего текста
            var normalLength =
                rrtb.Lines.Skip(count).Select(i => i.Length).Aggregate((accumulate, s) => accumulate + s + 1);
            rrtb.SelectionStart = RecognizedRichTextBox.SelectionStart + RecognizedRichTextBox.SelectionLength;
            rrtb.SelectionLength = normalLength;
            rrtb.SelectionFont = RecognizedRichTextBox.Font;

            rrtb.Select(0, 0);
        }
    }
}