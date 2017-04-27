using System;
using System.IO;
using System.Windows.Forms;

namespace LabFour
{
    public partial class LabFourForm : Form
    {
        public LabFourForm()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files|*.txt",
                Title = "Select a Text File"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var filename = openFileDialog.FileName;
            FilePathTextBox.Text = filename;
            RecognitionTextBox.Text = File.ReadAllText(filename);
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            var strings = RecognitionTextBox.Text.Split(new[] {"\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);
            RecognizedRichTextBox.Text = LabFour.FindSimilarities(strings);
        }
    }
}