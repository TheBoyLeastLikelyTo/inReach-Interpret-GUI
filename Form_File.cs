using System;
using System.Windows.Forms;

#nullable enable

namespace Interpret_Interface
{
    public partial class Form_File : Form
    {
        public Form_File()
        {
            InitializeComponent();
        }

        public string OriginalFile { get; set; } = "";

        // Open a file into the viewer
        public void SetText(string pathString, string text)
        {
            Text_FileContents.Text = text;
            Text = pathString;
            OriginalFile = text;
        }

        // Save the contents to a file
        public (string, string) GetText()
        {
            return new (Text, Text_FileContents.Text);
        }

        public void Cut()
        {
            if (ActiveControl is TextBox Text_FileContents)
            {
                if (!Text_FileContents.SelectionLength.Equals(0))
                {
                    Clipboard.SetText(Text_FileContents.SelectedText);
                    Text_FileContents.SelectedText = "";
                }
            }
        }

        public void Copy()
        {
            if (ActiveControl is TextBox Text_FileContents)
            {
                if (!Text_FileContents.SelectionLength.Equals(0))
                {
                    Clipboard.SetText(Text_FileContents.SelectedText);
                }
            }
        }

        public void Paste()
        {
            if (ActiveControl is TextBox Text_FileContents)
            {
                Text_FileContents.Paste(Clipboard.GetText());
            }
        }

        private void Form_File_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Text_FileContents.Text != OriginalFile)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to close unsaved file, {Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the closing action
                }
            }
        }
    }
}
